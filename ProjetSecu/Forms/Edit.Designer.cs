
namespace ProjetSecu.Forms
{
    partial class Edit
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
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_edit = new System.Windows.Forms.TextBox();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.combo_sex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(186, 39);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(103, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_edit
            // 
            this.txt_edit.Location = new System.Drawing.Point(12, 10);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.Size = new System.Drawing.Size(277, 23);
            this.txt_edit.TabIndex = 1;
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(12, 10);
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
            this.num_age.Size = new System.Drawing.Size(277, 23);
            this.num_age.TabIndex = 7;
            this.num_age.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.num_age.Visible = false;
            // 
            // combo_sex
            // 
            this.combo_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_sex.FormattingEnabled = true;
            this.combo_sex.Items.AddRange(new object[] {
            "Femme",
            "Homme",
            "Autre"});
            this.combo_sex.Location = new System.Drawing.Point(12, 10);
            this.combo_sex.Name = "combo_sex";
            this.combo_sex.Size = new System.Drawing.Size(277, 23);
            this.combo_sex.TabIndex = 8;
            this.combo_sex.Visible = false;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 73);
            this.Controls.Add(this.num_age);
            this.Controls.Add(this.combo_sex);
            this.Controls.Add(this.txt_edit);
            this.Controls.Add(this.btn_save);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox txt_edit;
        public System.Windows.Forms.NumericUpDown num_age;
        public System.Windows.Forms.ComboBox combo_sex;
    }
}