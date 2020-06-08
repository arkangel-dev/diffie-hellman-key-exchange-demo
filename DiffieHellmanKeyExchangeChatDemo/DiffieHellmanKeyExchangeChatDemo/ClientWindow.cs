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
using System.Threading;
using System.Net.Sockets;
using System.IO;
using NAudio.Wave;

namespace DiffieHellmanKeyExchangeChatDemo {
    public partial class ClientWindow : Form {

        BigInteger private_key_p;
        DiffieHellmanKeyExchange ExchangeAgent = null;
        public NetworkStream networkStream;
        public string servername = "";
        public int port = 5555;
        public bool EnableEncryption = false;

        Color ok_color = Color.FromArgb(13, 77, 0);
        Color er_color = Color.FromArgb(77, 0, 0);

        Color lo_message = Color.FromArgb(0, 66, 105);
        Color re_message = Color.FromArgb(105, 0, 103);

        public ClientWindow(string private_key, string server, int portid) {
            InitializeComponent();
            // Set the keys and server details...
            private_key_p = BigInteger.Parse(private_key, System.Globalization.NumberStyles.HexNumber);
            servername = server;
            port = portid;
            StartConnectionThread();
  
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

        public void StartConnectionThread() {
            var childSocketThread = new Thread(() => Connect()); // Create a new thread from the UI thread for the connection
            childSocketThread.Start();  // Start the thread...
        }



        public void Connect() {
            var client = new TcpClient();
            client.Connect(servername, port); // Connect to the server
            networkStream = client.GetStream();
            var reader = new StreamReader(networkStream, Encoding.UTF8);
            
            string g = null;
            string n = null;
            string midkey = null;

            PrintLine("Connecting to server...\n", color: ok_color);

            while (true) {
                byte[] data = new byte[1024];
                int size = networkStream.Read(data,0, 1024);



                var incomingdata = "";
                for (int i = 0; i < size; i++) { // Convert the ByteStream into a string... or something...
                    incomingdata += Convert.ToChar(data[i]).ToString();
                }

                if (EnableEncryption) { // if the encryption is enabled, then decrypt it before processeding...
                    incomingdata = ExchangeAgent.Decrypt(incomingdata);
                    PrintLine("Server : " + incomingdata + "\n", color: re_message);
                    playNewMessage();
                } else {
                    
                    if (String.IsNullOrWhiteSpace(incomingdata)) {
                        continue;
                    }
                    var substr = "";
                    var inc_data = "";
                    try {
                        substr = incomingdata.Substring(0, 3);
                        inc_data = incomingdata.Substring(4, incomingdata.Length - 4);
                    } catch { }

                    if (substr == "100") { // if the header is 100 its a public key
                        midkey = inc_data;
                        PrintLine("Received Public Key...\n", color: ok_color);
                    } else if (substr == "120") { // if its 120 its the public large key
                        n = inc_data;
                        PrintLine("Recieved Large Key...\n", color: ok_color);
                    } else if (substr == "130") { // if its 130 its the public prime key
                        g = inc_data;
                        PrintLine("Recieved Public Prime Key...\n", color: ok_color);
                    } else { // otherwise, just print the data
                        PrintLine("Unsecure : Server : " + incomingdata, color: er_color);
                        
                    }
                    

                    if ((g != null) && (n != null) && (midkey != null)) { // if all needed components are collected, Enable encryption...
                        PrintLine("Sending Public Key...\n", color: ok_color);

                        ExchangeAgent = new DiffieHellmanKeyExchange(
                            Int32.Parse(g, System.Globalization.NumberStyles.HexNumber),
                            BigInteger.Parse(n, System.Globalization.NumberStyles.HexNumber),
                            private_key_p
                        );

                        Send("100 " + ExchangeAgent.midkey.ToString("X"), false); // and send local public key
                        ExchangeAgent.CalculatePrivateKey(BigInteger.Parse(midkey, System.Globalization.NumberStyles.HexNumber));
                        EnableEncryption = true;
                        PrintLine("Connection successful...\n\n", color: ok_color);
                        playSuccess();
                    }
                }
            }
        }

        private void SendButton_Click(object sender, EventArgs e) {
            Send(MessageBox.Text);
            MessageBox.Text = "";
        }

        private void Send(string message, bool show = true) {

            if (EnableEncryption) {
                byte[] bytes = Encoding.UTF8.GetBytes(ExchangeAgent.Encrypt(message));
                networkStream.Write(bytes, 0, bytes.Length);
                if (show) {
                    PrintLine("You : " + message + "\n", color: lo_message);
                }
            } else {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                networkStream.Write(bytes, 0, bytes.Length);

                if (show) {
                    PrintLine("Unsecure : You : " + message + "\n", color: er_color);
                }

            }
        }

        private delegate void SafeCallDelegate(string text, bool bold, Color color);
        private void PrintLine(string text, bool bold = false, Color color = default(Color)) {
            if (MessageBox.InvokeRequired) {
                var d = new SafeCallDelegate(PrintLine);
                consoleTextArea.Invoke(d, new object[] { text, bold , color});
            } else {

                consoleTextArea.SelectionFont = bold ? new Font(consoleTextArea.Font, FontStyle.Bold) : new Font(consoleTextArea.Font, FontStyle.Regular);
                if (color.IsEmpty) { color = Color.Black; }
                consoleTextArea.SelectionColor = color;
                consoleTextArea.AppendText(text);
                consoleTextArea.ScrollToCaret();
            }
        }

        private void MessageBox_TextChanged(object sender, EventArgs e) {
            SendButton.Enabled = (!String.IsNullOrWhiteSpace(MessageBox.Text));
        }
    }
}
