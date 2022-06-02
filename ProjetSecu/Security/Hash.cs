using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSecu.Security
{
    class Hash
    {
        /// <summary>
        /// Retourne un hash SHA256 en Bytes Array
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Array</returns>
        public static byte[] Sha256_b(string value)
        {
            Byte[] result;

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                result = hash.ComputeHash(enc.GetBytes(value));
            }
            return result;
        }

        /// <summary>
        /// Retourne un hash SHA512 en String
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Sha512(string value)
        {
            SHA512 sha512 = SHA512.Create();

            byte[] data = sha512.ComputeHash(Encoding.UTF8.GetBytes(value));

            var sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
                sb.Append(data[i].ToString("x2"));

            return sb.ToString();
        }
    }
}
