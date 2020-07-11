namespace IHM_Gestion_Note
{
    partial class form_module
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_del_Mod = new MetroFramework.Controls.MetroButton();
            this.btn_clse_mod = new MetroFramework.Controls.MetroButton();
            this.btn_srch_Mod = new MetroFramework.Controls.MetroButton();
            this.btn_add_Mod = new MetroFramework.Controls.MetroButton();
            this.btn_edit_Mod = new MetroFramework.Controls.MetroButton();
            this.btn_remv_Mod = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.nbAbsance = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.noteModule = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.noteCours = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.noteTP = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DG_Mod = new MetroFramework.Controls.MetroGrid();
            this.id_module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note_Cours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note_Module = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nb_Absance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coéffission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.année = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_Ens = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.annUniv = new MetroFramework.Controls.MetroComboBox();
            this.enseignant = new MetroFramework.Controls.MetroComboBox();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enseignantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_NoteDataSet1 = new IHM_Gestion_Note.Base_NoteDataSet1();
            this.etudient = new MetroFramework.Controls.MetroComboBox();
            this.moduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etudientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.base_NoteDataSet2 = new IHM_Gestion_Note.Base_NoteDataSet2();
            this.semestre = new MetroFramework.Controls.MetroComboBox();
            this.coff = new MetroFramework.Controls.MetroComboBox();
            this.regime = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.enseignantsTableAdapter = new IHM_Gestion_Note.Base_NoteDataSet1TableAdapters.EnseignantsTableAdapter();
            this.etudientsTableAdapter = new IHM_Gestion_Note.Base_NoteDataSet2TableAdapters.EtudientsTableAdapter();
            this.Id_mod = new MetroFramework.Controls.MetroTextBox();
            this.nom_mod = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Mod)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enseignantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_NoteDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_NoteDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 277);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(885, 272);
            this.metroGrid1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn_del_Mod);
            this.groupBox2.Controls.Add(this.btn_clse_mod);
            this.groupBox2.Controls.Add(this.btn_srch_Mod);
            this.groupBox2.Controls.Add(this.btn_add_Mod);
            this.groupBox2.Controls.Add(this.btn_edit_Mod);
            this.groupBox2.Controls.Add(this.btn_remv_Mod);
            this.groupBox2.Location = new System.Drawing.Point(24, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 87);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // btn_del_Mod
            // 
            this.btn_del_Mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.document_refresh;
            this.btn_del_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_del_Mod.Location = new System.Drawing.Point(403, 13);
            this.btn_del_Mod.Name = "btn_del_Mod";
            this.btn_del_Mod.Size = new System.Drawing.Size(75, 68);
            this.btn_del_Mod.TabIndex = 16;
            this.btn_del_Mod.UseSelectable = true;
            this.btn_del_Mod.Click += new System.EventHandler(this.btn_del_Mod_Click);
            // 
            // btn_clse_mod
            // 
            this.btn_clse_mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.close;
            this.btn_clse_mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clse_mod.Location = new System.Drawing.Point(484, 13);
            this.btn_clse_mod.Name = "btn_clse_mod";
            this.btn_clse_mod.Size = new System.Drawing.Size(75, 68);
            this.btn_clse_mod.TabIndex = 15;
            this.btn_clse_mod.UseSelectable = true;
            this.btn_clse_mod.Click += new System.EventHandler(this.btn_clse_mod_Click);
            // 
            // btn_srch_Mod
            // 
            this.btn_srch_Mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.document_find;
            this.btn_srch_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_srch_Mod.Location = new System.Drawing.Point(249, 13);
            this.btn_srch_Mod.Name = "btn_srch_Mod";
            this.btn_srch_Mod.Size = new System.Drawing.Size(75, 68);
            this.btn_srch_Mod.TabIndex = 14;
            this.btn_srch_Mod.UseSelectable = true;
            this.btn_srch_Mod.Click += new System.EventHandler(this.btn_srch_Mod_Click);
            // 
            // btn_add_Mod
            // 
            this.btn_add_Mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.document_add;
            this.btn_add_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add_Mod.Location = new System.Drawing.Point(6, 13);
            this.btn_add_Mod.Name = "btn_add_Mod";
            this.btn_add_Mod.Size = new System.Drawing.Size(75, 68);
            this.btn_add_Mod.TabIndex = 11;
            this.btn_add_Mod.UseSelectable = true;
            this.btn_add_Mod.Click += new System.EventHandler(this.btn_add_ens_Click);
            // 
            // btn_edit_Mod
            // 
            this.btn_edit_Mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.document_edit;
            this.btn_edit_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit_Mod.Location = new System.Drawing.Point(168, 13);
            this.btn_edit_Mod.Name = "btn_edit_Mod";
            this.btn_edit_Mod.Size = new System.Drawing.Size(75, 68);
            this.btn_edit_Mod.TabIndex = 13;
            this.btn_edit_Mod.UseSelectable = true;
            this.btn_edit_Mod.Click += new System.EventHandler(this.btn_edit_Mod_Click);
            // 
            // btn_remv_Mod
            // 
            this.btn_remv_Mod.BackgroundImage = global::IHM_Gestion_Note.Properties.Resources.document_error;
            this.btn_remv_Mod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remv_Mod.Location = new System.Drawing.Point(87, 13);
            this.btn_remv_Mod.Name = "btn_remv_Mod";
            this.btn_remv_Mod.Size = new System.Drawing.Size(75, 68);
            this.btn_remv_Mod.TabIndex = 12;
            this.btn_remv_Mod.UseSelectable = true;
            this.btn_remv_Mod.Click += new System.EventHandler(this.btn_remv_Mod_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(343, 113);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(61, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Regime :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(343, 144);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Coéffission :";
            // 
            // nbAbsance
            // 
            // 
            // 
            // 
            this.nbAbsance.CustomButton.Image = null;
            this.nbAbsance.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.nbAbsance.CustomButton.Name = "";
            this.nbAbsance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nbAbsance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nbAbsance.CustomButton.TabIndex = 1;
            this.nbAbsance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nbAbsance.CustomButton.UseSelectable = true;
            this.nbAbsance.CustomButton.Visible = false;
            this.nbAbsance.Lines = new string[0];
            this.nbAbsance.Location = new System.Drawing.Point(435, 75);
            this.nbAbsance.MaxLength = 32767;
            this.nbAbsance.Name = "nbAbsance";
            this.nbAbsance.PasswordChar = '\0';
            this.nbAbsance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nbAbsance.SelectedText = "";
            this.nbAbsance.SelectionLength = 0;
            this.nbAbsance.SelectionStart = 0;
            this.nbAbsance.ShortcutsEnabled = true;
            this.nbAbsance.Size = new System.Drawing.Size(154, 23);
            this.nbAbsance.TabIndex = 8;
            this.nbAbsance.UseSelectable = true;
            this.nbAbsance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nbAbsance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(343, 81);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(92, 19);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Nb Absances :";
            // 
            // noteModule
            // 
            // 
            // 
            // 
            this.noteModule.CustomButton.Image = null;
            this.noteModule.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.noteModule.CustomButton.Name = "";
            this.noteModule.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.noteModule.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noteModule.CustomButton.TabIndex = 1;
            this.noteModule.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noteModule.CustomButton.UseSelectable = true;
            this.noteModule.CustomButton.Visible = false;
            this.noteModule.Lines = new string[0];
            this.noteModule.Location = new System.Drawing.Point(435, 39);
            this.noteModule.MaxLength = 32767;
            this.noteModule.Name = "noteModule";
            this.noteModule.PasswordChar = '\0';
            this.noteModule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteModule.SelectedText = "";
            this.noteModule.SelectionLength = 0;
            this.noteModule.SelectionStart = 0;
            this.noteModule.ShortcutsEnabled = true;
            this.noteModule.Size = new System.Drawing.Size(154, 23);
            this.noteModule.TabIndex = 9;
            this.noteModule.UseSelectable = true;
            this.noteModule.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noteModule.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(343, 43);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 19);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "Note Module ;";
            // 
            // noteCours
            // 
            // 
            // 
            // 
            this.noteCours.CustomButton.Image = null;
            this.noteCours.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.noteCours.CustomButton.Name = "";
            this.noteCours.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.noteCours.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noteCours.CustomButton.TabIndex = 1;
            this.noteCours.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noteCours.CustomButton.UseSelectable = true;
            this.noteCours.CustomButton.Visible = false;
            this.noteCours.Lines = new string[0];
            this.noteCours.Location = new System.Drawing.Point(139, 144);
            this.noteCours.MaxLength = 32767;
            this.noteCours.Name = "noteCours";
            this.noteCours.PasswordChar = '\0';
            this.noteCours.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteCours.SelectedText = "";
            this.noteCours.SelectionLength = 0;
            this.noteCours.SelectionStart = 0;
            this.noteCours.ShortcutsEnabled = true;
            this.noteCours.Size = new System.Drawing.Size(154, 23);
            this.noteCours.TabIndex = 1;
            this.noteCours.UseSelectable = true;
            this.noteCours.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noteCours.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 144);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Note Cours :";
            // 
            // noteTP
            // 
            // 
            // 
            // 
            this.noteTP.CustomButton.Image = null;
            this.noteTP.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.noteTP.CustomButton.Name = "";
            this.noteTP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.noteTP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.noteTP.CustomButton.TabIndex = 1;
            this.noteTP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.noteTP.CustomButton.UseSelectable = true;
            this.noteTP.CustomButton.Visible = false;
            this.noteTP.Lines = new string[0];
            this.noteTP.Location = new System.Drawing.Point(139, 111);
            this.noteTP.MaxLength = 32767;
            this.noteTP.Name = "noteTP";
            this.noteTP.PasswordChar = '\0';
            this.noteTP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.noteTP.SelectedText = "";
            this.noteTP.SelectionLength = 0;
            this.noteTP.SelectionStart = 0;
            this.noteTP.ShortcutsEnabled = true;
            this.noteTP.Size = new System.Drawing.Size(154, 23);
            this.noteTP.TabIndex = 1;
            this.noteTP.UseSelectable = true;
            this.noteTP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.noteTP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 106);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(64, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Note TP :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Nom :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(94, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Num Module :";
            // 
            // DG_Mod
            // 
            this.DG_Mod.AllowUserToResizeRows = false;
            this.DG_Mod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Mod.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DG_Mod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Mod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Mod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Mod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Mod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Mod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_module,
            this.nom_Module,
            this.note,
            this.Note_Cours,
            this.Note_Module,
            this.nb_Absance,
            this.regim,
            this.coéffission,
            this.Semestr,
            this.année,
            this.num_Ens});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Mod.DefaultCellStyle = dataGridViewCellStyle5;
            this.DG_Mod.EnableHeadersVisualStyles = false;
            this.DG_Mod.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DG_Mod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DG_Mod.Location = new System.Drawing.Point(19, 309);
            this.DG_Mod.Name = "DG_Mod";
            this.DG_Mod.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Mod.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Mod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DG_Mod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Mod.Size = new System.Drawing.Size(885, 255);
            this.DG_Mod.TabIndex = 6;
            this.DG_Mod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Mod_CellContentClick);
            // 
            // id_module
            // 
            this.id_module.HeaderText = "ID";
            this.id_module.Name = "id_module";
            // 
            // nom_Module
            // 
            this.nom_Module.HeaderText = "Nom";
            this.nom_Module.Name = "nom_Module";
            // 
            // note
            // 
            this.note.HeaderText = "NoteTP";
            this.note.Name = "note";
            // 
            // Note_Cours
            // 
            this.Note_Cours.HeaderText = "Note Cours";
            this.Note_Cours.Name = "Note_Cours";
            // 
            // Note_Module
            // 
            this.Note_Module.HeaderText = "Note  Mod";
            this.Note_Module.Name = "Note_Module";
            // 
            // nb_Absance
            // 
            this.nb_Absance.HeaderText = "Nb Absance";
            this.nb_Absance.Name = "nb_Absance";
            // 
            // regim
            // 
            this.regim.HeaderText = "Regime";
            this.regim.Name = "regim";
            // 
            // coéffission
            // 
            this.coéffission.HeaderText = "COF";
            this.coéffission.Name = "coéffission";
            // 
            // Semestr
            // 
            this.Semestr.HeaderText = "Semestre";
            this.Semestr.Name = "Semestr";
            // 
            // année
            // 
            this.année.HeaderText = "AnnUniv";
            this.année.Name = "année";
            // 
            // num_Ens
            // 
            this.num_Ens.HeaderText = "LeProf";
            this.num_Ens.Name = "num_Ens";
            this.num_Ens.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.nom_mod);
            this.groupBox1.Controls.Add(this.Id_mod);
            this.groupBox1.Controls.Add(this.annUniv);
            this.groupBox1.Controls.Add(this.enseignant);
            this.groupBox1.Controls.Add(this.etudient);
            this.groupBox1.Controls.Add(this.semestre);
            this.groupBox1.Controls.Add(this.coff);
            this.groupBox1.Controls.Add(this.regime);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel10);
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.metroGrid1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.nbAbsance);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.noteModule);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.noteCours);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.noteTP);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(885, 268);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Modules :";
            // 
            // annUniv
            // 
            this.annUniv.FormattingEnabled = true;
            this.annUniv.ItemHeight = 23;
            this.annUniv.Items.AddRange(new object[] {
            "2010/2011",
            "2011/2012",
            "2012/2013",
            "2013/2014",
            "2014/2015",
            "2015/2016",
            "2016/2017",
            "2017/2018",
            "2018/2019",
            "2019/2020"});
            this.annUniv.Location = new System.Drawing.Point(706, 75);
            this.annUniv.Name = "annUniv";
            this.annUniv.Size = new System.Drawing.Size(154, 29);
            this.annUniv.TabIndex = 32;
            this.annUniv.UseSelectable = true;
            // 
            // enseignant
            // 
            this.enseignant.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.moduleBindingSource, "Enseignant", true));
            this.enseignant.DataSource = this.enseignantsBindingSource;
            this.enseignant.DisplayMember = "num_Ens";
            this.enseignant.FormattingEnabled = true;
            this.enseignant.ItemHeight = 23;
            this.enseignant.Location = new System.Drawing.Point(706, 110);
            this.enseignant.Name = "enseignant";
            this.enseignant.Size = new System.Drawing.Size(154, 29);
            this.enseignant.TabIndex = 31;
            this.enseignant.UseSelectable = true;
            this.enseignant.ValueMember = "num_Ens";
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataSource = typeof(Entities.Module);
            // 
            // enseignantsBindingSource
            // 
            this.enseignantsBindingSource.DataMember = "Enseignants";
            this.enseignantsBindingSource.DataSource = this.base_NoteDataSet1;
            // 
            // base_NoteDataSet1
            // 
            this.base_NoteDataSet1.DataSetName = "Base_NoteDataSet1";
            this.base_NoteDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudient
            // 
            this.etudient.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.moduleBindingSource1, "Etudient", true));
            this.etudient.DataSource = this.etudientsBindingSource;
            this.etudient.DisplayMember = "num_Etud";
            this.etudient.FormattingEnabled = true;
            this.etudient.ItemHeight = 23;
            this.etudient.Location = new System.Drawing.Point(706, 145);
            this.etudient.Name = "etudient";
            this.etudient.Size = new System.Drawing.Size(154, 29);
            this.etudient.TabIndex = 30;
            this.etudient.UseSelectable = true;
            this.etudient.ValueMember = "num_Etud";
            // 
            // moduleBindingSource1
            // 
            this.moduleBindingSource1.DataSource = typeof(Entities.Module);
            // 
            // etudientsBindingSource
            // 
            this.etudientsBindingSource.DataMember = "Etudients";
            this.etudientsBindingSource.DataSource = this.base_NoteDataSet2;
            // 
            // base_NoteDataSet2
            // 
            this.base_NoteDataSet2.DataSetName = "Base_NoteDataSet2";
            this.base_NoteDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // semestre
            // 
            this.semestre.FormattingEnabled = true;
            this.semestre.ItemHeight = 23;
            this.semestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.semestre.Location = new System.Drawing.Point(706, 36);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(154, 29);
            this.semestre.TabIndex = 29;
            this.semestre.UseSelectable = true;
            // 
            // coff
            // 
            this.coff.FormattingEnabled = true;
            this.coff.ItemHeight = 23;
            this.coff.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
            this.coff.Location = new System.Drawing.Point(435, 138);
            this.coff.Name = "coff";
            this.coff.Size = new System.Drawing.Size(154, 29);
            this.coff.TabIndex = 28;
            this.coff.UseSelectable = true;
            // 
            // regime
            // 
            this.regime.FormattingEnabled = true;
            this.regime.ItemHeight = 23;
            this.regime.Items.AddRange(new object[] {
            "Principale",
            "Secondaire"});
            this.regime.Location = new System.Drawing.Point(435, 105);
            this.regime.Name = "regime";
            this.regime.Size = new System.Drawing.Size(154, 29);
            this.regime.TabIndex = 27;
            this.regime.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(614, 113);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(78, 19);
            this.metroLabel9.TabIndex = 17;
            this.metroLabel9.Text = "Enseignant :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(614, 144);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 19);
            this.metroLabel10.TabIndex = 18;
            this.metroLabel10.Text = "Etudient :";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(614, 81);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(80, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "Année univ :";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(614, 43);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(70, 19);
            this.metroLabel12.TabIndex = 20;
            this.metroLabel12.Text = "Semestre ;";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Silver;
            this.metroLabel13.ForeColor = System.Drawing.Color.Red;
            this.metroLabel13.Location = new System.Drawing.Point(321, 567);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(234, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "© Copyright SALEM JAMEL DSIR 2020";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // enseignantsTableAdapter
            // 
            this.enseignantsTableAdapter.ClearBeforeFill = true;
            // 
            // etudientsTableAdapter
            // 
            this.etudientsTableAdapter.ClearBeforeFill = true;
            // 
            // Id_mod
            // 
            // 
            // 
            // 
            this.Id_mod.CustomButton.Image = null;
            this.Id_mod.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.Id_mod.CustomButton.Name = "";
            this.Id_mod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Id_mod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Id_mod.CustomButton.TabIndex = 1;
            this.Id_mod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Id_mod.CustomButton.UseSelectable = true;
            this.Id_mod.CustomButton.Visible = false;
            this.Id_mod.Lines = new string[0];
            this.Id_mod.Location = new System.Drawing.Point(139, 39);
            this.Id_mod.MaxLength = 32767;
            this.Id_mod.Name = "Id_mod";
            this.Id_mod.PasswordChar = '\0';
            this.Id_mod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Id_mod.SelectedText = "";
            this.Id_mod.SelectionLength = 0;
            this.Id_mod.SelectionStart = 0;
            this.Id_mod.ShortcutsEnabled = true;
            this.Id_mod.Size = new System.Drawing.Size(154, 23);
            this.Id_mod.TabIndex = 35;
            this.Id_mod.UseSelectable = true;
            this.Id_mod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Id_mod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nom_mod
            // 
            // 
            // 
            // 
            this.nom_mod.CustomButton.Image = null;
            this.nom_mod.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.nom_mod.CustomButton.Name = "";
            this.nom_mod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom_mod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom_mod.CustomButton.TabIndex = 1;
            this.nom_mod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom_mod.CustomButton.UseSelectable = true;
            this.nom_mod.CustomButton.Visible = false;
            this.nom_mod.Lines = new string[0];
            this.nom_mod.Location = new System.Drawing.Point(139, 71);
            this.nom_mod.MaxLength = 32767;
            this.nom_mod.Name = "nom_mod";
            this.nom_mod.PasswordChar = '\0';
            this.nom_mod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom_mod.SelectedText = "";
            this.nom_mod.SelectionLength = 0;
            this.nom_mod.SelectionStart = 0;
            this.nom_mod.ShortcutsEnabled = true;
            this.nom_mod.Size = new System.Drawing.Size(154, 23);
            this.nom_mod.TabIndex = 36;
            this.nom_mod.UseSelectable = true;
            this.nom_mod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom_mod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // form_module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 597);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.DG_Mod);
            this.Controls.Add(this.groupBox1);
            this.Name = "form_module";
            this.Text = "form_module";
            this.Load += new System.EventHandler(this.form_module_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Mod)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enseignantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_NoteDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base_NoteDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_del_Mod;
        private MetroFramework.Controls.MetroButton btn_clse_mod;
        private MetroFramework.Controls.MetroButton btn_srch_Mod;
        private MetroFramework.Controls.MetroButton btn_add_Mod;
        private MetroFramework.Controls.MetroButton btn_edit_Mod;
        private MetroFramework.Controls.MetroButton btn_remv_Mod;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox nbAbsance;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox noteModule;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox noteCours;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox noteTP;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid DG_Mod;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox regime;
        private MetroFramework.Controls.MetroComboBox semestre;
        private MetroFramework.Controls.MetroComboBox coff;
        private MetroFramework.Controls.MetroComboBox annUniv;
        private MetroFramework.Controls.MetroComboBox enseignant;
        private MetroFramework.Controls.MetroComboBox etudient;
        private Base_NoteDataSet1 base_NoteDataSet1;
        private System.Windows.Forms.BindingSource enseignantsBindingSource;
        private Base_NoteDataSet1TableAdapters.EnseignantsTableAdapter enseignantsTableAdapter;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private Base_NoteDataSet2 base_NoteDataSet2;
        private System.Windows.Forms.BindingSource etudientsBindingSource;
        private Base_NoteDataSet2TableAdapters.EtudientsTableAdapter etudientsTableAdapter;
        private System.Windows.Forms.BindingSource moduleBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_module;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note_Cours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note_Module;
        private System.Windows.Forms.DataGridViewTextBoxColumn nb_Absance;
        private System.Windows.Forms.DataGridViewTextBoxColumn regim;
        private System.Windows.Forms.DataGridViewTextBoxColumn coéffission;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn année;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_Ens;
        private MetroFramework.Controls.MetroTextBox nom_mod;
        private MetroFramework.Controls.MetroTextBox Id_mod;
    }
}