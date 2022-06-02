using ProjetSecu.Structures;
using ProjetSecu.Enums;
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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Instance
        /// </summary>
        public Main main;
        public User user { get; set; }
        public EditEnum EditEnu { get; set; }

        private void Edit_Load(object sender, EventArgs e)
        {
            /* Affichage du bon composant */
            switch (EditEnu)
            {
                case EditEnum.Username:
                    txt_edit.Visible = true;
                    num_age.Visible = false;
                    combo_sex.Visible = false;
                    break;
                case EditEnum.Password:
                    txt_edit.Visible = true;
                    num_age.Visible = false;
                    combo_sex.Visible = false;
                    break;
                case EditEnum.Email:
                    txt_edit.Visible = true;
                    num_age.Visible = false;
                    combo_sex.Visible = false;
                    break;
                case EditEnum.Address:
                    txt_edit.Visible = true;
                    num_age.Visible = false;
                    combo_sex.Visible = false;
                    break;
                case EditEnum.Age:
                    txt_edit.Visible = false;
                    num_age.Visible = true;
                    combo_sex.Visible = false;
                    break;
                case EditEnum.Sex:
                    txt_edit.Visible = false;
                    num_age.Visible = false;
                    combo_sex.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            User editUser = user;

            switch (EditEnu)
            {
                case EditEnum.Username:
                    editUser.Username = txt_edit.Text;
                    main.lbl_user.Text = txt_edit.Text;
                    break;
                case EditEnum.Password:
                    editUser.Password = txt_edit.Text;
                    main.lbl_password.Text = txt_edit.Text;
                    break;
                case EditEnum.Email:
                    editUser.Email = txt_edit.Text;
                    main.lbl_mail.Text = txt_edit.Text;
                    break;
                case EditEnum.Address:
                    editUser.Address = txt_edit.Text;
                    main.lbl_address.Text = txt_edit.Text;
                    break;
                case EditEnum.Age:
                    editUser.Age = (int)num_age.Value;
                    main.lbl_age.Text = num_age.Value.ToString();
                    break;
                case EditEnum.Sex:
                    editUser.Sex = (SexEnum)combo_sex.SelectedIndex;
                    main.lbl_sex.Text = ((SexEnum)combo_sex.SelectedIndex).ToString();
                    break;
                default:
                    break;
            }
            if (Sql.User.Edit(editUser))
            {
                MessageBox.Show(this.Text + " modifié avec succés !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.user = editUser;
                this.Close();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue !", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
