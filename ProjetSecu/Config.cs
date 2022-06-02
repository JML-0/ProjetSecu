using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetSecu
{
    /// <summary>
    /// Fichier config du logiciel
    /// </summary>
    class Config
    {
        /// <summary>
        /// Chemin de la base de données (DB1.mdf)
        /// </summary>
        static string path = AppDomain.CurrentDomain.BaseDirectory;
        public static string SqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                                    AttachDbFilename=" + path + "DB1.mdf;" +
                                                    "Integrated Security=True;" +
                                                    "Connect Timeout=30";

        /// <summary>
        /// Vecteur aléatoire
        /// Convert.ToBase64String(Aes.Create().IV));
        /// </summary>
        public readonly static byte[] IV = Convert.FromBase64String("6Dc8lysXc0hCw1M0GtJq2A==");
    }
}
