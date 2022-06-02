using ProjetSecu.Security;
using ProjetSecu.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSecu.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public User user { get; set; }
        private void Main_Load(object sender, EventArgs e)
        {
            lbl_user.Text = user.Username;
            lbl_password.Text = user.Password;
            lbl_mail.Text = user.Email;
            lbl_address.Text = user.Address;
            lbl_age.Text = user.Age.ToString();
            lbl_sex.Text = user.Sex.ToString();
        }

        private async void lbl_CpyNoStudent_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("18901505"); // Copie No étudiant dans le presse papier
            lbl_CpyNoStudent.Text = "Numéro d'étudiant copié !";
            await Task.Delay(2000);
            lbl_CpyNoStudent.Text = "Levacher Jimmy - 18901505";
        }

        private void linkEdit_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Nom de compte";
            edit.txt_edit.Text = lbl_user.Text;
            edit.EditEnu = Enums.EditEnum.Username;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkEdit_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Mot de passe";
            edit.txt_edit.Text = lbl_password.Text;
            edit.EditEnu = Enums.EditEnum.Password;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkEdit_mail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Mail";
            edit.txt_edit.Text = lbl_mail.Text;
            edit.EditEnu = Enums.EditEnum.Email;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkEdit_adress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Addresse";
            edit.txt_edit.Text = lbl_address.Text;
            edit.EditEnu = Enums.EditEnum.Address;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkEdit_age_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Age";
            edit.num_age.Value = Convert.ToDecimal(lbl_age.Text);
            edit.EditEnu = Enums.EditEnum.Age;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkEdit_sex_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Edit edit = new Edit();
            edit.Text = "Sexe";
            edit.combo_sex.SelectedIndex = (int)Enum.Parse(typeof(Enums.SexEnum), lbl_sex.Text);
            edit.EditEnu = Enums.EditEnum.Sex;
            edit.user = user;
            edit.main = this;
            edit.ShowDialog();
        }

        private void linkDelete_user_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string message = "Voulez-vous vraiment supprimer ce compte ?";
            string title = "Supprimer ce compte";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                if (Sql.User.Delete(user.Id))
                {
                    this.Close();
                }
            }
        }
    }
}
