using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSecu.Security;

namespace ProjetSecu.Sql
{
    class Auth
    {
        public static SqlConnection SqlConn;

        /// <summary>
        /// Vérification de la combinaison des @params
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Exist(string username, string password)
        {
            Open();

            using (SqlCommand cmd = new SqlCommand("Login", SqlConn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", AES.EncryptStringToBytes_Aes(Hash.Sha512(password), Hash.Sha256_b(password), Config.IV)));

                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                Close();

                if (result == 0)    return false;
                else                return true;
            }
        }
        /// <summary>
        /// Ouverture d'une connexion SQL Server
        /// </summary>
        public static void Open()
        {
            SqlConn = new SqlConnection(Config.SqlConnectionString);
            SqlConn.Open();
        }
        /// <summary>
        /// Fermeture d'une connexion SQL Server
        /// </summary>
        public static void Close() => SqlConn.Close();
    }
}
