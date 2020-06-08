using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace DiffieHellmanKeyExchangeChatDemo {
    public partial class LandingPage : Form {
        public LandingPage() {
            InitializeComponent();
            Init();
        }

        public void Init() {
            gen_a_Click(null, null);
            gen_b_Click(null, null);
            gen_c_Click(null, null);
            gen_d_Click(null, null);
        }


        static Random random = new Random();
        public static string GetRandomHexNumber(int digits) {
            var final = random.Next(1, 9).ToString();
            for (int i = 0; i < digits - 1; i++) {
                final += random.Next(0, 9).ToString();
            }
            return BigInteger.Parse(final).ToString("X");
        }

        private void gen_a_Click(object sender, EventArgs e) {
            public_big_number.Text = GetRandomHexNumber(128);
        }

        private void gen_b_Click(object sender, EventArgs e) {
            public_prime_number.Text = GetRandomHexNumber(3);
        }

        private void gen_c_Click(object sender, EventArgs e) {
            private_key.Text = GetRandomHexNumber(128);
        }

        private void gen_d_Click(object sender, EventArgs e) {
            local_private_key.Text = GetRandomHexNumber(128);
        }

        private void host_server_Click(object sender, EventArgs e) {
            var connectionWindow = new ConnectionWindow(bind_Address.Text, Int32.Parse(bind_Port.Text),"SERVER", public_big_number.Text, public_prime_number.Text, private_key.Text);
            this.Hide();
            connectionWindow.ShowDialog();
            connectionWindow.Dispose();
            this.Show();
        }

        private void connect_to_server_Click(object sender, EventArgs e) {
            var clientWindow = new ClientWindow(local_private_key.Text, server_address.Text, Int32.Parse(server_port.Text));
            this.Hide();
            clientWindow.ShowDialog();
            clientWindow.Dispose();
            this.Show();
        }
    }
}
