using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.IO;

namespace DiffieHellmanKeyExchangeChatDemo {
    public class DiffieHellmanKeyExchange {

        public BigInteger midkey = 0; // This is the key that is calculated and publicly sent over the network
        private BigInteger pa = 0; // This is the local private key
        public BigInteger n = 0; // This is the publicly accessible big number
        
       
        public string FinalKey = null; // This is the final key calculated with the diffie hellman key exchange algorithim
        public string ShortKey = ""; // This is the final key but reduced to 32 bits because the current encryption (AES) supports 32 bits
        public int cutoff = 32; // This is the cut off length
        public int g = 0; // This is the publicly accessible prime number

        public DiffieHellmanKeyExchange(int gin, BigInteger nin, BigInteger key_in) {
            Random generator = new Random();
            pa = key_in;
            g = gin;
            n = nin;
            midkey = BigInteger.ModPow(g, pa, n); // Calculate the public key
        }

        public void SetPrivateKey(BigInteger keyIn) {
            pa = keyIn; // Set the private key manually
        }

        public string GetFinalKey() {
            return FinalKey; // Fetch the private key
        }

        public void CalculatePrivateKey(BigInteger bkey_in) {
            this.FinalKey = (BigInteger.ModPow(bkey_in, pa, n)).ToString("X"); // Calculate the local keys...
            this.ShortKey = FinalKey.Substring(0, cutoff); //... and shorten it to 32 bits
        }

        public string Encrypt(string plainText) { // Encrypt the messages
            byte[] iv = new byte[16];
            byte[] array;
            using (Aes aes = Aes.Create()) {
                aes.Key = Encoding.UTF8.GetBytes(ShortKey);
                aes.IV = iv;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream()) {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write)) {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream)) {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(array);
        }



        public string Decrypt(string cipherText) { // Decrypt the messages
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create()) {
                aes.Key = Encoding.UTF8.GetBytes(ShortKey);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer)) {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read)) {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream)) {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

    }
}
