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

namespace DiffyHellmanKeyExchangeDemo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Encode_Click(object sender, EventArgs e) {

            int g = 400;
            BigInteger n = BigInteger.Parse("17508726417851236512835781681371890561270865781246578268965871658475781364856134688");
            
            DiffyHellman Alice = new DiffyHellman(g, n, BigInteger.Parse(alice_private_key.Text));
            DiffyHellman Bob = new DiffyHellman(g, n, BigInteger.Parse(bob_private_key.Text));


            PuKA.Text = Alice.midkey.ToString("X");
            PuKB.Text = Bob.midkey.ToString("X");

            Alice.CalculatePrivateKey(Bob.midkey);
            Bob.CalculatePrivateKey(Alice.midkey);


            PKa.Text = Alice.GetFinalKey();
            PKb.Text = Bob.GetFinalKey();

        }
    }
}
