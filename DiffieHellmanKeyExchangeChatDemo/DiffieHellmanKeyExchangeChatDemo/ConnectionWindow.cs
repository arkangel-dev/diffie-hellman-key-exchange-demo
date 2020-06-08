using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using NAudio;
using NAudio.Wave;

namespace DiffieHellmanKeyExchangeChatDemo {
    public partial class ConnectionWindow : Form {

        public Color ok_color = Color.FromArgb(13, 77, 0);
        public Color er_color = Color.FromArgb(77, 0, 0);

        public Color lo_message = Color.FromArgb(0, 66, 105);
        public Color re_message = Color.FromArgb(105, 0, 103);
        public ConnectionWindow(string ip, int port, string Mode, string public_big_num, string public_prime_key, string private_key) {
            InitializeComponent();

            server = new TcpListener(System.Net.IPAddress.Parse(ip), port);

            ppk = Int32.Parse(Int32.Parse(public_prime_key, System.Globalization.NumberStyles.HexNumber).ToString());
            pbn = BigInteger.Parse(public_big_num, System.Globalization.NumberStyles.HexNumber);
            pk = BigInteger.Parse(private_key, System.Globalization.NumberStyles.HexNumber);

            var server_thread = new Thread(() => StartServer());
            server_thread.Start();
        }

        public void playSuccess() {
            new Thread(() => {
                IWavePlayer waveOutDevice = new WaveOut();
                AudioFileReader audioFileReader = new AudioFileReader("connected.mp3");
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                Thread.Sleep(1200);
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
            }).Start();
        }

        public void playNewMessage() {
            new Thread(() => {
                IWavePlayer waveOutDevice = new WaveOut();
                AudioFileReader audioFileReader = new AudioFileReader("sound.mp3");
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
                Thread.Sleep(1200);
                waveOutDevice.Dispose();
                audioFileReader.Dispose();
            }).Start();
        }

        private void StartServer() {
            Thread.Sleep(250);
            while (true) {
                PrintLine("Starting server listener...\n", ok_color);
                PrintLine("Waiting for connections...\n", ok_color);
                server.Start();
                client = server.AcceptSocket();
                PrintLine("Connection accepted...\n", ok_color);
                PrintLine("Sending secure connection data...\n", ok_color);
                server.Stop();

                var childSocketThread = new Thread(() => ProcessClient());
                childSocketThread.Start();

            }
        }

        int ppk;
        BigInteger pbn;
        BigInteger pk;

        TcpListener server = null;

        private delegate void SafeCallDelegate(string text, Color color);
        public bool EnableEncryption = false;

        private void PrintLine(string text, Color color) {
            if (consoleTextArea.InvokeRequired) {
                var d = new SafeCallDelegate(PrintLine);
                consoleTextArea.Invoke(d, new object[] { text, color});
            } else {


                Invoke(new Action(() => consoleTextArea.SelectionColor = color));
                Invoke(new Action(() => consoleTextArea.AppendText(text)));
                Invoke(new Action(() => consoleTextArea.ScrollToCaret()));
                //consoleTextArea.Text += text;
            }
        }




        Socket client;
        public DiffieHellmanKeyExchange ExchangeAgent;

        private void ProcessClient() {
            

            ExchangeAgent = new DiffieHellmanKeyExchange(ppk, pbn, pk);
            client.Send(Encoding.ASCII.GetBytes("100 " + ExchangeAgent.midkey.ToString("X")));
            Thread.Sleep(100);
            client.Send(Encoding.ASCII.GetBytes("120 " + ExchangeAgent.n.ToString("X")));
            Thread.Sleep(100);
            client.Send(Encoding.ASCII.GetBytes("130 " + ExchangeAgent.g.ToString("X")));
            client.Send(Encoding.ASCII.GetBytes(""));



            try {
                while (true) {
                    byte[] data = new byte[1024];
                    int size = client.Receive(data);
                    if (size == 0) {
                        PrintLine("Connection Closed...\n", ok_color);
                        break;
                    }

                    var incomingdata = "";
                    for (int i = 0; i < size; i++) {
                        incomingdata += Convert.ToChar(data[i]).ToString();
                    }

                    if (EnableEncryption) {
                        incomingdata = ExchangeAgent.Decrypt(incomingdata);
                        PrintLine("Client : " + incomingdata + "\n", re_message);
                        playNewMessage();
                    } else {
                        
                        if (incomingdata.Substring(0, 3) == "100") {
                            ExchangeAgent.CalculatePrivateKey(
                                BigInteger.Parse(
                                    incomingdata.Substring(4, incomingdata.Length - 4),
                                    System.Globalization.NumberStyles.HexNumber
                            ));
                            EnableEncryption = true;
                            PrintLine("Secure Connection Ready...\n\n", ok_color);
                            playSuccess();
                        } else {
                            PrintLine("Unsecure : Client : " + incomingdata + "\n", er_color);
                            playNewMessage();
                        }
                    }

                    
                }
            } catch (System.Net.Sockets.SocketException e) {
                PrintLine("Closed Connection...\n", er_color);
            }
        }


        private void SendMessage(string message, bool show = true) {
            if (EnableEncryption) {
                client.Send(Encoding.ASCII.GetBytes(ExchangeAgent.Encrypt(message)));
                if (show) {
                    PrintLine("You : " + message + "\n", lo_message);
                }
            } else {
                client.Send(Encoding.ASCII.GetBytes(message));
                if (show) {
                    PrintLine("Unsecure : You : " + message + "\n", er_color);
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e) {
            SendMessage(SendMessageBox.Text);
        }

        private void ConnectionWindow_FormClosing(object sender, FormClosingEventArgs e) {
            if (client != null) { client.Close(); }
            server.Stop();
        }
    }
}
