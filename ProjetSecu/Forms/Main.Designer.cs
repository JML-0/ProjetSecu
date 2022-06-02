
namespace ProjetSecu.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkEdit_sex = new System.Windows.Forms.LinkLabel();
            this.linkEdit_age = new System.Windows.Forms.LinkLabel();
            this.linkEdit_adress = new System.Windows.Forms.LinkLabel();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkEdit_mail = new System.Windows.Forms.LinkLabel();
            this.linkEdit_password = new System.Windows.Forms.LinkLabel();
            this.linkEdit_user = new System.Windows.Forms.LinkLabel();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_CpyNoStudent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkDelete_user = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkEdit_sex);
            this.groupBox2.Controls.Add(this.linkEdit_age);
            this.groupBox2.Controls.Add(this.linkEdit_adress);
            this.groupBox2.Controls.Add(this.lbl_sex);
            this.groupBox2.Controls.Add(this.lbl_age);
            this.groupBox2.Controls.Add(this.lbl_address);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 188);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Données personnelles";
            // 
            // linkEdit_sex
            // 
            this.linkEdit_sex.Location = new System.Drawing.Point(342, 142);
            this.linkEdit_sex.Name = "linkEdit_sex";
            this.linkEdit_sex.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_sex.TabIndex = 19;
            this.linkEdit_sex.TabStop = true;
            this.linkEdit_sex.Text = "Modifier";
            this.linkEdit_sex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_sex.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_sex_LinkClicked);
            // 
            // linkEdit_age
            // 
            this.linkEdit_age.Location = new System.Drawing.Point(342, 93);
            this.linkEdit_age.Name = "linkEdit_age";
            this.linkEdit_age.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_age.TabIndex = 18;
            this.linkEdit_age.TabStop = true;
            this.linkEdit_age.Text = "Modifier";
            this.linkEdit_age.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_age.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_age_LinkClicked);
            // 
            // linkEdit_adress
            // 
            this.linkEdit_adress.Location = new System.Drawing.Point(342, 43);
            this.linkEdit_adress.Name = "linkEdit_adress";
            this.linkEdit_adress.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_adress.TabIndex = 17;
            this.linkEdit_adress.TabStop = true;
            this.linkEdit_adress.Text = "Modifier";
            this.linkEdit_adress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_adress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_adress_LinkClicked);
            // 
            // lbl_sex
            // 
            this.lbl_sex.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sex.ForeColor = System.Drawing.Color.Black;
            this.lbl_sex.Location = new System.Drawing.Point(59, 142);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(277, 21);
            this.lbl_sex.TabIndex = 16;
            this.lbl_sex.Text = "Nom de compte";
            this.lbl_sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_age
            // 
            this.lbl_age.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.ForeColor = System.Drawing.Color.Black;
            this.lbl_age.Location = new System.Drawing.Point(59, 93);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(277, 21);
            this.lbl_age.TabIndex = 15;
            this.lbl_age.Text = "Nom de compte";
            this.lbl_age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoEllipsis = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(59, 43);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(277, 21);
            this.lbl_address.TabIndex = 14;
            this.lbl_address.Text = "Nom de compte";
            this.lbl_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(59, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Adresse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(59, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sexe";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(59, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Age";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkEdit_mail);
            this.groupBox1.Controls.Add(this.linkEdit_password);
            this.groupBox1.Controls.Add(this.linkEdit_user);
            this.groupBox1.Controls.Add(this.lbl_mail);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.lbl_user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 188);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données du compte";
            // 
            // linkEdit_mail
            // 
            this.linkEdit_mail.Location = new System.Drawing.Point(342, 144);
            this.linkEdit_mail.Name = "linkEdit_mail";
            this.linkEdit_mail.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_mail.TabIndex = 18;
            this.linkEdit_mail.TabStop = true;
            this.linkEdit_mail.Text = "Modifier";
            this.linkEdit_mail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_mail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_mail_LinkClicked);
            // 
            // linkEdit_password
            // 
            this.linkEdit_password.Location = new System.Drawing.Point(342, 95);
            this.linkEdit_password.Name = "linkEdit_password";
            this.linkEdit_password.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_password.TabIndex = 17;
            this.linkEdit_password.TabStop = true;
            this.linkEdit_password.Text = "Modifier";
            this.linkEdit_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_password_LinkClicked);
            // 
            // linkEdit_user
            // 
            this.linkEdit_user.Location = new System.Drawing.Point(342, 45);
            this.linkEdit_user.Name = "linkEdit_user";
            this.linkEdit_user.Size = new System.Drawing.Size(86, 21);
            this.linkEdit_user.TabIndex = 16;
            this.linkEdit_user.TabStop = true;
            this.linkEdit_user.Text = "Modifier";
            this.linkEdit_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkEdit_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEdit_user_LinkClicked);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoEllipsis = true;
            this.lbl_mail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mail.ForeColor = System.Drawing.Color.Black;
            this.lbl_mail.Location = new System.Drawing.Point(59, 144);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(277, 21);
            this.lbl_mail.TabIndex = 15;
            this.lbl_mail.Text = "Nom de compte";
            this.lbl_mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoEllipsis = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(59, 95);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(277, 21);
            this.lbl_password.TabIndex = 14;
            this.lbl_password.Text = "Nom de compte";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(59, 45);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(277, 21);
            this.lbl_user.TabIndex = 13;
            this.lbl_user.Text = "Nom de compte";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de compte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(59, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mot de passe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CpyNoStudent
            // 
            this.lbl_CpyNoStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CpyNoStudent.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lbl_CpyNoStudent.ForeColor = System.Drawing.Color.Gray;
            this.lbl_CpyNoStudent.Location = new System.Drawing.Point(568, 197);
            this.lbl_CpyNoStudent.Name = "lbl_CpyNoStudent";
            this.lbl_CpyNoStudent.Size = new System.Drawing.Size(126, 16);
            this.lbl_CpyNoStudent.TabIndex = 18;
            this.lbl_CpyNoStudent.Text = "Levacher Jimmy - 18901505";
            this.lbl_CpyNoStudent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_CpyNoStudent.Click += new System.EventHandler(this.lbl_CpyNoStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetSecu.Properties.Resources._1200px_Paris_VIII_svg;
            this.pictureBox1.Location = new System.Drawing.Point(455, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // linkDelete_user
            // 
            this.linkDelete_user.Location = new System.Drawing.Point(455, 375);
            this.linkDelete_user.Name = "linkDelete_user";
            this.linkDelete_user.Size = new System.Drawing.Size(239, 21);
            this.linkDelete_user.TabIndex = 20;
            this.linkDelete_user.TabStop = true;
            this.linkDelete_user.Text = "Supprimer le compte";
            this.linkDelete_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkDelete_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDelete_user_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 410);
            this.Controls.Add(this.linkDelete_user);
            this.Controls.Add(this.lbl_CpyNoStudent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkEdit_sex;
        private System.Windows.Forms.LinkLabel linkEdit_age;
        private System.Windows.Forms.LinkLabel linkEdit_adress;
        private System.Windows.Forms.LinkLabel linkEdit_mail;
        private System.Windows.Forms.LinkLabel linkEdit_password;
        private System.Windows.Forms.LinkLabel linkEdit_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_CpyNoStudent;
        public System.Windows.Forms.Label lbl_user;
        public System.Windows.Forms.Label lbl_sex;
        public System.Windows.Forms.Label lbl_age;
        public System.Windows.Forms.Label lbl_address;
        public System.Windows.Forms.Label lbl_mail;
        public System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.LinkLabel linkDelete_user;
    }
}