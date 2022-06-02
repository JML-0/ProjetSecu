using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecu.Forms
{
    public partial class Register : Form
    {
        /// <summary>
        /// Instance
        /// </summary>
        public Login login;
        public Register()
        {
            InitializeComponent();
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void link_random_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txt_user.Text = "Bob";
            txt_password.Text = txt_password2.Text = "password";
            txt_mail.Text = "mail@mail.com";
            txt_address.Text = "245 Avenue de la Belle Gabrielle Paris France";
            num_age.Value = 25;
            combo_sex.SelectedIndex = 1;
            txt_password.UseSystemPasswordChar = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            /* Check simple des .text */
            if (!checkText()) return;

            /* Check si username disponible */
            if (Sql.User.Exist(txt_user.Text))
            {
                lbl_status.Text = "Nom de compte non disponible";
                lbl_status.Visible = true;
                return;
            }

            /* Création d'un nouvel utilisateur */
            Structures.User newUser = new Structures.User();
            newUser.Username = txt_user.Text;
            newUser.Password = txt_password.Text;
            newUser.Email = txt_mail.Text;
            newUser.Address = txt_address.Text;
            newUser.Age = (int)num_age.Value;
            newUser.Sex = (Enums.SexEnum)combo_sex.SelectedIndex;

            if (Sql.User.Add(newUser))
            {
                MessageBox.Show("Compte créé !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                login.txt_user.Text = txt_user.Text;
                login.txt_password.Text = txt_password.Text;
                this.Close();
            }
            else
            {
                lbl_status.Text = "Impossible de créer le compte";
                lbl_status.Visible = true;
                return;
            }
        }

        /// <summary>
        /// Check simple des .text
        /// Regex, ...
        /// </summary>
        /// <returns></returns>
        private bool checkText()
        {
            if (txt_user.Text.Length == 0)
            {
                errorProvider.SetError(txt_user, "Champ vide !");
            }
            else if (txt_password.Text.Length == 0)
            {
                errorProvider.SetError(txt_password, "Champ vide !");
            }
            else if (txt_password2.Text.Length == 0)
            {
                errorProvider.SetError(txt_password2, "Champ vide !");
            }
            else if (txt_password.Text != txt_password2.Text)
            {
                errorProvider.SetError(txt_password2, "Mot de passe différent !");
            }
            else if (txt_mail.Text.Length == 0)
            {
                errorProvider.SetError(txt_mail, "Champ vide !");
            }
            else if (txt_address.Text.Length == 0)
            {
                errorProvider.SetError(txt_address, "Champ vide !");
            }
            else if (combo_sex.SelectedItem == null)
            {
                errorProvider.SetError(combo_sex, "Champ vide !");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
