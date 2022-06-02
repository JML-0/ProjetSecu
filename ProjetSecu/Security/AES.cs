using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSecu.Security
{
    class AES
    {
        /// <summary>
        /// Chiffrement AES
        /// https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography?view=net-6.0
        /// </summary>
        /// <param name="text">string</param>
        /// <param name="Key">byte[128-256] private key</param>
        /// <param name="IV">byte[4] vecteur</param>
        /// <returns>string</returns>
        public static string EncryptStringToBytes_Aes(string text, byte[] Key, byte[] IV)
        {
            // Check arg.
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream()){
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)){
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            swEncrypt.Write(text);
                        encrypted = Convert.ToBase64String(msEncrypt.ToArray());
                    }
                }
            }
            return encrypted;
        }
        /// <summary>
        /// Déchiffrement AES
        /// </summary>
        /// <param name="text">byte[]</param>
        /// <param name="Key">byte[128-256] private key</param>
        /// <param name="IV">byte[4] vecteur</param>
        /// <returns></returns>
        public static string DecryptStringFromBytes_Aes(byte[] text, byte[] Key, byte[] IV)
        {
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            string decrypted = null; //m dechi

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(text))
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    decrypted = srDecrypt.ReadToEnd();
            }
            return decrypted;
        }
    }
}
