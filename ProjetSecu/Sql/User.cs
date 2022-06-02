using ProjetSecu.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecu.Sql
{
    class User
    {
        /// <summary>
        /// Récupère & déchiffre les données du compte
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static Structures.User Data(string username, string password)
        {
            Auth.Open();

            Structures.User newUser = new Structures.User();

            using (SqlCommand cmd = new SqlCommand("ReadUser", Auth.SqlConn)) /* Procédure SQL */
            {
                byte[] key = Hash.Sha256_b(password);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);

                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 320);
                cmd.Parameters["@email"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar, 120);
                cmd.Parameters["@address"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@age", SqlDbType.NVarChar, 24);
                cmd.Parameters["@age"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@sex", SqlDbType.NVarChar, 24);
                cmd.Parameters["@sex"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();

                newUser.Id = Convert.ToInt16(cmd.Parameters["@id"].Value);
                newUser.Username = username;
                newUser.Password = password;
                newUser.Email = AES.DecryptStringFromBytes_Aes(Convert.FromBase64String(cmd.Parameters["@email"].Value.ToString()), key, Config.IV);
                newUser.Address = AES.DecryptStringFromBytes_Aes(Convert.FromBase64String(cmd.Parameters["@address"].Value.ToString()), key, Config.IV);
                newUser.Age = Convert.ToInt16(AES.DecryptStringFromBytes_Aes(Convert.FromBase64String(cmd.Parameters["@age"].Value.ToString()), key, Config.IV));
                newUser.Sex = (Enums.SexEnum)Convert.ToInt16(AES.DecryptStringFromBytes_Aes(Convert.FromBase64String(cmd.Parameters["@sex"].Value.ToString()), key, Config.IV));
            }
            Auth.Close();

            return newUser;
        }
        /// <summary>
        /// Modifie un compte
        /// </summary>
        /// <param name="user">Struct User</param>
        /// <returns></returns>
        public static bool Edit(Structures.User user)
        {
            Auth.Open();

            using (SqlCommand cmd = new SqlCommand("EditUser", Auth.SqlConn)) /* Procédure SQL */
            {
                byte[] key = Hash.Sha256_b(user.Password);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@typeEdit", "Update");
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", AES.EncryptStringToBytes_Aes(Hash.Sha512(user.Password), key, Config.IV));
                cmd.Parameters.AddWithValue("@email", AES.EncryptStringToBytes_Aes(user.Email, key, Config.IV));
                cmd.Parameters.AddWithValue("@address", AES.EncryptStringToBytes_Aes(user.Address, key, Config.IV));
                cmd.Parameters.AddWithValue("@age", AES.EncryptStringToBytes_Aes(user.Age.ToString(), key, Config.IV));
                cmd.Parameters.AddWithValue("@sex", AES.EncryptStringToBytes_Aes(((int)user.Sex).ToString(), key, Config.IV));

                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                Auth.Close();

                if (result == 0)    return false;
                else                return true;
            }
        }
        /// <summary>
        /// Supprime un compte
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool Delete(int id)
        {
            Auth.Open();

            using (SqlCommand cmd = new SqlCommand("EditUser", Auth.SqlConn)) /* Procédure SQL */
            {

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@typeEdit", "Delete");
                cmd.Parameters.AddWithValue("@username", 0);
                cmd.Parameters.AddWithValue("@password", 0);
                cmd.Parameters.AddWithValue("@email", 0);
                cmd.Parameters.AddWithValue("@address", 0);
                cmd.Parameters.AddWithValue("@age", 0);
                cmd.Parameters.AddWithValue("@sex", 0);

                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                Auth.Close();

                if (result == 0) return false;
                else return true;
            }
        }
        /// <summary>
        /// Crée un compte
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Add(Structures.User user)
        {
            Auth.Open();

            using (SqlCommand cmd = new SqlCommand("EditUser", Auth.SqlConn)) /* Procédure SQL */
            {
                byte[] key = Hash.Sha256_b(user.Password);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", user.Id);
                cmd.Parameters.AddWithValue("@typeEdit", "Insert");
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", AES.EncryptStringToBytes_Aes(Hash.Sha512(user.Password), key, Config.IV));
                cmd.Parameters.AddWithValue("@email", AES.EncryptStringToBytes_Aes(user.Email, key, Config.IV));
                cmd.Parameters.AddWithValue("@address", AES.EncryptStringToBytes_Aes(user.Address, key, Config.IV));
                cmd.Parameters.AddWithValue("@age", AES.EncryptStringToBytes_Aes(user.Age.ToString(), key, Config.IV));
                cmd.Parameters.AddWithValue("@sex", AES.EncryptStringToBytes_Aes(((int)user.Sex).ToString(), key, Config.IV));

                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                Auth.Close();

                if (result == 0) return false;
                else return true;
            }
        }
        /// <summary>
        /// Vérifie si un compte éxiste déjà
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static bool Exist(string username)
        {
            Auth.Open();

            using (SqlCommand cmd = new SqlCommand("EditUser", Auth.SqlConn)) /* Procédure SQL */
            {

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", 0);
                cmd.Parameters.AddWithValue("@typeEdit", "Exist");
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", 0);
                cmd.Parameters.AddWithValue("@email", 0);
                cmd.Parameters.AddWithValue("@address", 0);
                cmd.Parameters.AddWithValue("@age", 0);
                cmd.Parameters.AddWithValue("@sex", 0);

                var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                cmd.ExecuteNonQuery();

                int result = (int)returnParameter.Value;

                Auth.Close();

                if (result == 0) return false;
                else return true;
            }
        }
    }
}
