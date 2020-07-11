namespace IHM_Gestion_Note
{
    partial class form_Login
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txt_login = new MetroFramework.Controls.MetroTextBox();
            this.txt_pass = new MetroFramework.Controls.MetroTextBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            // 
            // 
            // 
            this.txt_login.CustomButton.Image = null;
            this.txt_login.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txt_login.CustomButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_login.CustomButton.Name = "";
            this.txt_login.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_login.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_login.CustomButton.TabIndex = 1;
            this.txt_login.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_login.CustomButton.UseSelectable = true;
            this.txt_login.CustomButton.Visible = false;
            this.txt_login.Lines = new string[0];
            this.txt_login.Location = new System.Drawing.Point(267, 51);
            this.txt_login.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_login.MaxLength = 32767;
            this.txt_login.Name = "txt_login";
            this.txt_login.PasswordChar = '\0';
            this.txt_login.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_login.SelectedText = "";
            this.txt_login.SelectionLength = 0;
            this.txt_login.SelectionStart = 0;
            this.txt_login.ShortcutsEnabled = true;
            this.txt_login.Size = new System.Drawing.Size(140, 19);
            this.txt_login.TabIndex = 0;
            this.txt_login.UseSelectable = true;
            this.txt_login.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_login.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_pass
            // 
            // 
            // 
            // 
            this.txt_pass.CustomButton.Image = null;
            this.txt_pass.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.txt_pass.CustomButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_pass.CustomButton.Name = "";
            this.txt_pass.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txt_pass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_pass.CustomButton.TabIndex = 1;
            this.txt_pass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_pass.CustomButton.UseSelectable = true;
            this.txt_pass.CustomButton.Visible = false;
            this.txt_pass.Lines = new string[0];
            this.txt_pass.Location = new System.Drawing.Point(267, 129);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_pass.MaxLength = 32767;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_pass.SelectedText = "";
            this.txt_pass.SelectionLength = 0;
            this.txt_pass.SelectionStart = 0;
            this.txt_pass.ShortcutsEnabled = true;
            this.txt_pass.Size = new System.Drawing.Size(140, 19);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.UseSelectable = true;
            this.txt_pass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_pass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(66, 213);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(129, 43);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Log in";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(244, 213);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(163, 43);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseSelectable = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(195, 129);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Password :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(195, 51);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Log in :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "منظومة التصرف في الطلبة";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IHM_Gestion_Note.Properties.Resources.loginstud;
            this.pictureBox1.Location = new System.Drawing.Point(36, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Font = new System.Drawing.Font("Andalus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(61, 273);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(319, 26);
            this.labelerror.TabIndex = 6;
            this.labelerror.Text = "Vérifier votre login et mot de passe svp !";
            this.labelerror.Visible = false;
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 316);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_login);
            this.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "form_Login";
            this.Padding = new System.Windows.Forms.Padding(33, 60, 33, 17);
            this.Validated += new System.EventHandler(this.btn_login_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private MetroFramework.Controls.MetroTextBox txt_login;
        private MetroFramework.Controls.MetroTextBox txt_pass;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelerror;
    }
}