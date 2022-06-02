using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetSecu.Security;
using ProjetSecu.Sql;

namespace ProjetSecu.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void link_Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            r.login = this;
            r.ShowDialog();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            /* Vérification des combinaisons */
            bool Exist = Auth.Exist(txt_user.Text, txt_password.Text);
            if (!Exist)
            {
                lbl_status.Text = "Nom de compte ou mot de passe incorrect";
                lbl_status.Show();
                return;
            }
            lbl_status.Hide();

            Structures.User user = User.Data(txt_user.Text, txt_password.Text);

            Main main = new Main();
            main.user = user;
            main.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //TEST
            //using (Aes Aes_o = Aes.Create())
            //{
            //    Aes_o.Key = Hash.Sha256_b("password");
            //    Aes_o.IV = Config.IV;

            //    // chiffrement du hash512 du password
            //    string encrypted = AES.EncryptStringToBytes_Aes("mot", Aes_o.Key, Aes_o.IV);

            //    string roundtrip = AES.DecryptStringFromBytes_Aes(Convert.FromBase64String(encrypted), Aes_o.Key, Aes_o.IV);


            //    Console.WriteLine("Key:   {0}", BitConverter.ToString(Aes_o.Key));
            //    Console.WriteLine("Encrypt:   {0}", encrypted);
            //    //byte[] bytes = Convert.FromBase64String(BitConverter.ToString(encrypted));
            //    //Console.WriteLine("Encrypt:   {0}", BitConverter.ToString(bytes));
            //    Console.WriteLine("Decrypt: {0}", roundtrip);

            //    Console.WriteLine("PASS : {0}", AES.EncryptStringToBytes_Aes(Hash.Sha512("password"), Hash.Sha256_b("password"), Config.IV));
            //}

            //return;
        }
    }
}
