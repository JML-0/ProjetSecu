
namespace ProjetSecu.Forms
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.combo_sex = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.link_random = new System.Windows.Forms.LinkLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mot de passe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom de compte";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(62, 96);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(313, 23);
            this.txt_password.TabIndex = 1;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(62, 47);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(313, 23);
            this.txt_user.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(59, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Répétez le mot de passe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_password2
            // 
            this.txt_password2.Location = new System.Drawing.Point(62, 145);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(313, 23);
            this.txt_password2.TabIndex = 2;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(59, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(62, 194);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(313, 23);
            this.txt_mail.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_user);
            this.groupBox1.Controls.Add(this.txt_mail);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_password2);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 240);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Données du compte";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_age);
            this.groupBox2.Controls.Add(this.combo_sex);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 188);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Données personnelles";
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(62, 95);
            this.num_age.Maximum = new decimal(new int[] {
            110,
            0,
            0,
            0});
            this.num_age.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(313, 23);
            this.num_age.TabIndex = 5;
            this.num_age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // combo_sex
            // 
            this.combo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sex.FormattingEnabled = true;
            this.combo_sex.Items.AddRange(new object[] {
            "Femme",
            "Homme",
            "Autre"});
            this.combo_sex.Location = new System.Drawing.Point(62, 145);
            this.combo_sex.Name = "combo_sex";
            this.combo_sex.Size = new System.Drawing.Size(313, 23);
            this.combo_sex.TabIndex = 6;
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
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(62, 46);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(313, 23);
            this.txt_address.TabIndex = 4;
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
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(276, 451);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(170, 28);
            this.btn_create.TabIndex = 7;
            this.btn_create.Text = "Créer un compte";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(12, 451);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(258, 28);
            this.lbl_status.TabIndex = 16;
            this.lbl_status.Text = "Nom de compte incorrect";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_status.Visible = false;
            // 
            // link_random
            // 
            this.link_random.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.link_random.Location = new System.Drawing.Point(387, -3);
            this.link_random.Name = "link_random";
            this.link_random.Size = new System.Drawing.Size(62, 20);
            this.link_random.TabIndex = 17;
            this.link_random.TabStop = true;
            this.link_random.Text = "Pré-remplir";
            this.link_random.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.link_random.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_random_LinkClicked);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 491);
            this.Controls.Add(this.link_random);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créer un compte";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox combo_sex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.LinkLabel link_random;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}