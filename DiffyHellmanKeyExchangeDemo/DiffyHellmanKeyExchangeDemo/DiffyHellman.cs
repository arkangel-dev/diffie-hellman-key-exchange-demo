using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DiffyHellmanKeyExchangeDemo {
    class DiffyHellman {
        public string FinalKey = "";
        public int g = 0;
        public BigInteger n = 0;
        public BigInteger midkey = 0;

        
        private BigInteger pa = 0;

        public DiffyHellman(int gin, BigInteger nin, BigInteger key_in) {
            Random generator = new Random();
            pa = key_in;
            g = gin;
            n = nin;

            midkey = BigInteger.ModPow(g, pa, n);
            Console.WriteLine(g.ToString());
        }

        public void SetPrivateKey(BigInteger keyIn) {
            pa = keyIn;
        }

        public string GetFinalKey() {
            return FinalKey;
        }

        public void CalculatePrivateKey(BigInteger bkey_in) {
            this.FinalKey = (BigInteger.ModPow(bkey_in, pa, n)).ToString("X");
        }

    }
}
