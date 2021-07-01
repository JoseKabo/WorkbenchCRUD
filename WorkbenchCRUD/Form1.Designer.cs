
namespace WorkbenchCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_birthday = new System.Windows.Forms.DateTimePicker();
            this.txt_genre = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_phone = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_country = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_adress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_nss = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_name = new MetroSet_UI.Controls.MetroSetTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save_consulta = new System.Windows.Forms.Button();
            this.txt_tratamiento = new System.Windows.Forms.TextBox();
            this.txt_diagnostico = new System.Windows.Forms.TextBox();
            this.txt_datos = new System.Windows.Forms.TextBox();
            this.dtp_fecha_consulta = new System.Windows.Forms.DateTimePicker();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.dgv_pacientes_consulta = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtp_fecha_act = new System.Windows.Forms.DateTimePicker();
            this.txt_genre_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_phone_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_country_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_adress_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_nss_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txt_name_act = new MetroSet_UI.Controls.MetroSetTextBox();
            this.dgv_pacientes_act = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes_consulta)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes_act)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 137);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 437);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1084, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1084, 403);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_save);
            this.tabPage3.Controls.Add(this.dtp_birthday);
            this.tabPage3.Controls.Add(this.txt_genre);
            this.tabPage3.Controls.Add(this.txt_phone);
            this.tabPage3.Controls.Add(this.txt_country);
            this.tabPage3.Controls.Add(this.txt_adress);
            this.tabPage3.Controls.Add(this.txt_nss);
            this.tabPage3.Controls.Add(this.txt_name);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1090, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Agregar Paciente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Location = new System.Drawing.Point(828, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(227, 23);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_birthday
            // 
            this.dtp_birthday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_birthday.Location = new System.Drawing.Point(28, 134);
            this.dtp_birthday.Name = "dtp_birthday";
            this.dtp_birthday.Size = new System.Drawing.Size(1027, 23);
            this.dtp_birthday.TabIndex = 7;
            // 
            // txt_genre
            // 
            this.txt_genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_genre.AutoCompleteCustomSource = null;
            this.txt_genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_genre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_genre.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_genre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_genre.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_genre.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_genre.Image = null;
            this.txt_genre.Lines = null;
            this.txt_genre.Location = new System.Drawing.Point(28, 318);
            this.txt_genre.MaxLength = 32767;
            this.txt_genre.Multiline = false;
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.ReadOnly = false;
            this.txt_genre.Size = new System.Drawing.Size(1027, 30);
            this.txt_genre.Style = MetroSet_UI.Design.Style.Light;
            this.txt_genre.StyleManager = null;
            this.txt_genre.TabIndex = 6;
            this.txt_genre.Text = "genero";
            this.txt_genre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_genre.ThemeAuthor = "Narwin";
            this.txt_genre.ThemeName = "MetroLite";
            this.txt_genre.UseSystemPasswordChar = false;
            this.txt_genre.WatermarkText = "";
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.AutoCompleteCustomSource = null;
            this.txt_phone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_phone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_phone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_phone.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_phone.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_phone.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_phone.Image = null;
            this.txt_phone.Lines = null;
            this.txt_phone.Location = new System.Drawing.Point(28, 273);
            this.txt_phone.MaxLength = 32767;
            this.txt_phone.Multiline = false;
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.ReadOnly = false;
            this.txt_phone.Size = new System.Drawing.Size(1027, 30);
            this.txt_phone.Style = MetroSet_UI.Design.Style.Light;
            this.txt_phone.StyleManager = null;
            this.txt_phone.TabIndex = 5;
            this.txt_phone.Text = "Telefono";
            this.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_phone.ThemeAuthor = "Narwin";
            this.txt_phone.ThemeName = "MetroLite";
            this.txt_phone.UseSystemPasswordChar = false;
            this.txt_phone.WatermarkText = "";
            // 
            // txt_country
            // 
            this.txt_country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_country.AutoCompleteCustomSource = null;
            this.txt_country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_country.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_country.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_country.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_country.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_country.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_country.Image = null;
            this.txt_country.Lines = null;
            this.txt_country.Location = new System.Drawing.Point(28, 226);
            this.txt_country.MaxLength = 32767;
            this.txt_country.Multiline = false;
            this.txt_country.Name = "txt_country";
            this.txt_country.ReadOnly = false;
            this.txt_country.Size = new System.Drawing.Size(1027, 30);
            this.txt_country.Style = MetroSet_UI.Design.Style.Light;
            this.txt_country.StyleManager = null;
            this.txt_country.TabIndex = 4;
            this.txt_country.Text = "Ciudad";
            this.txt_country.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_country.ThemeAuthor = "Narwin";
            this.txt_country.ThemeName = "MetroLite";
            this.txt_country.UseSystemPasswordChar = false;
            this.txt_country.WatermarkText = "";
            // 
            // txt_adress
            // 
            this.txt_adress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_adress.AutoCompleteCustomSource = null;
            this.txt_adress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_adress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_adress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_adress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_adress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_adress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_adress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_adress.Image = null;
            this.txt_adress.Lines = null;
            this.txt_adress.Location = new System.Drawing.Point(28, 177);
            this.txt_adress.MaxLength = 32767;
            this.txt_adress.Multiline = false;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.ReadOnly = false;
            this.txt_adress.Size = new System.Drawing.Size(1027, 30);
            this.txt_adress.Style = MetroSet_UI.Design.Style.Light;
            this.txt_adress.StyleManager = null;
            this.txt_adress.TabIndex = 3;
            this.txt_adress.Text = "Direccion";
            this.txt_adress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_adress.ThemeAuthor = "Narwin";
            this.txt_adress.ThemeName = "MetroLite";
            this.txt_adress.UseSystemPasswordChar = false;
            this.txt_adress.WatermarkText = "";
            // 
            // txt_nss
            // 
            this.txt_nss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nss.AutoCompleteCustomSource = null;
            this.txt_nss.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_nss.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_nss.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_nss.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_nss.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_nss.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_nss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nss.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_nss.Image = null;
            this.txt_nss.Lines = null;
            this.txt_nss.Location = new System.Drawing.Point(28, 83);
            this.txt_nss.MaxLength = 32767;
            this.txt_nss.Multiline = false;
            this.txt_nss.Name = "txt_nss";
            this.txt_nss.ReadOnly = false;
            this.txt_nss.Size = new System.Drawing.Size(1027, 30);
            this.txt_nss.Style = MetroSet_UI.Design.Style.Light;
            this.txt_nss.StyleManager = null;
            this.txt_nss.TabIndex = 1;
            this.txt_nss.Text = "Numero de seguridad social";
            this.txt_nss.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nss.ThemeAuthor = "Narwin";
            this.txt_nss.ThemeName = "MetroLite";
            this.txt_nss.UseSystemPasswordChar = false;
            this.txt_nss.WatermarkText = "";
            // 
            // txt_name
            // 
            this.txt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name.AutoCompleteCustomSource = null;
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_name.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_name.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_name.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_name.Image = null;
            this.txt_name.Lines = null;
            this.txt_name.Location = new System.Drawing.Point(28, 40);
            this.txt_name.MaxLength = 32767;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = false;
            this.txt_name.Size = new System.Drawing.Size(1027, 30);
            this.txt_name.Style = MetroSet_UI.Design.Style.Light;
            this.txt_name.StyleManager = null;
            this.txt_name.TabIndex = 0;
            this.txt_name.Text = "Nombre";
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.ThemeAuthor = "Narwin";
            this.txt_name.ThemeName = "MetroLite";
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.WatermarkText = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.btn_save_consulta);
            this.tabPage4.Controls.Add(this.txt_tratamiento);
            this.tabPage4.Controls.Add(this.txt_diagnostico);
            this.tabPage4.Controls.Add(this.txt_datos);
            this.tabPage4.Controls.Add(this.dtp_fecha_consulta);
            this.tabPage4.Controls.Add(this.txt_observaciones);
            this.tabPage4.Controls.Add(this.dgv_pacientes_consulta);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1090, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Agregar Consulta";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Debes seleccionar un registro de la tabla";
            // 
            // btn_save_consulta
            // 
            this.btn_save_consulta.Location = new System.Drawing.Point(488, 257);
            this.btn_save_consulta.Name = "btn_save_consulta";
            this.btn_save_consulta.Size = new System.Drawing.Size(256, 23);
            this.btn_save_consulta.TabIndex = 6;
            this.btn_save_consulta.Text = "Guardar";
            this.btn_save_consulta.UseVisualStyleBackColor = true;
            this.btn_save_consulta.Click += new System.EventHandler(this.btn_save_consulta_Click);
            // 
            // txt_tratamiento
            // 
            this.txt_tratamiento.Location = new System.Drawing.Point(20, 208);
            this.txt_tratamiento.Name = "txt_tratamiento";
            this.txt_tratamiento.Size = new System.Drawing.Size(724, 23);
            this.txt_tratamiento.TabIndex = 5;
            this.txt_tratamiento.Text = "Tratamiento";
            // 
            // txt_diagnostico
            // 
            this.txt_diagnostico.Location = new System.Drawing.Point(20, 165);
            this.txt_diagnostico.Name = "txt_diagnostico";
            this.txt_diagnostico.Size = new System.Drawing.Size(724, 23);
            this.txt_diagnostico.TabIndex = 4;
            this.txt_diagnostico.Text = "Diagnostico";
            // 
            // txt_datos
            // 
            this.txt_datos.Location = new System.Drawing.Point(20, 119);
            this.txt_datos.Name = "txt_datos";
            this.txt_datos.Size = new System.Drawing.Size(724, 23);
            this.txt_datos.TabIndex = 3;
            this.txt_datos.Text = "Datos de interes";
            // 
            // dtp_fecha_consulta
            // 
            this.dtp_fecha_consulta.Location = new System.Drawing.Point(20, 74);
            this.dtp_fecha_consulta.Name = "dtp_fecha_consulta";
            this.dtp_fecha_consulta.Size = new System.Drawing.Size(724, 23);
            this.dtp_fecha_consulta.TabIndex = 2;
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(20, 30);
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(724, 23);
            this.txt_observaciones.TabIndex = 1;
            this.txt_observaciones.Text = "Observaciones";
            // 
            // dgv_pacientes_consulta
            // 
            this.dgv_pacientes_consulta.AllowUserToAddRows = false;
            this.dgv_pacientes_consulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pacientes_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes_consulta.Location = new System.Drawing.Point(820, 30);
            this.dgv_pacientes_consulta.Name = "dgv_pacientes_consulta";
            this.dgv_pacientes_consulta.ReadOnly = true;
            this.dgv_pacientes_consulta.RowTemplate.Height = 25;
            this.dgv_pacientes_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pacientes_consulta.Size = new System.Drawing.Size(240, 337);
            this.dgv_pacientes_consulta.TabIndex = 0;
            this.dgv_pacientes_consulta.SelectionChanged += new System.EventHandler(this.dgv_pacientes_consulta_SelectionChanged);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.dtp_fecha_act);
            this.tabPage5.Controls.Add(this.txt_genre_act);
            this.tabPage5.Controls.Add(this.txt_phone_act);
            this.tabPage5.Controls.Add(this.txt_country_act);
            this.tabPage5.Controls.Add(this.txt_adress_act);
            this.tabPage5.Controls.Add(this.txt_nss_act);
            this.tabPage5.Controls.Add(this.txt_name_act);
            this.tabPage5.Controls.Add(this.dgv_pacientes_act);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1090, 409);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Actualizar paciente";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(0, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Debes seleccionar un registro de la tabla";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(548, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtp_fecha_act
            // 
            this.dtp_fecha_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_fecha_act.CustomFormat = "yyyy/MM/dd";
            this.dtp_fecha_act.Enabled = false;
            this.dtp_fecha_act.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha_act.Location = new System.Drawing.Point(32, 121);
            this.dtp_fecha_act.Name = "dtp_fecha_act";
            this.dtp_fecha_act.Size = new System.Drawing.Size(743, 23);
            this.dtp_fecha_act.TabIndex = 15;
            // 
            // txt_genre_act
            // 
            this.txt_genre_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_genre_act.AutoCompleteCustomSource = null;
            this.txt_genre_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_genre_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_genre_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_genre_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_genre_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_genre_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_genre_act.Enabled = false;
            this.txt_genre_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_genre_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_genre_act.Image = null;
            this.txt_genre_act.Lines = null;
            this.txt_genre_act.Location = new System.Drawing.Point(32, 305);
            this.txt_genre_act.MaxLength = 32767;
            this.txt_genre_act.Multiline = false;
            this.txt_genre_act.Name = "txt_genre_act";
            this.txt_genre_act.ReadOnly = false;
            this.txt_genre_act.Size = new System.Drawing.Size(743, 30);
            this.txt_genre_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_genre_act.StyleManager = null;
            this.txt_genre_act.TabIndex = 14;
            this.txt_genre_act.Text = "genero";
            this.txt_genre_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_genre_act.ThemeAuthor = "Narwin";
            this.txt_genre_act.ThemeName = "MetroLite";
            this.txt_genre_act.UseSystemPasswordChar = false;
            this.txt_genre_act.WatermarkText = "";
            // 
            // txt_phone_act
            // 
            this.txt_phone_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone_act.AutoCompleteCustomSource = null;
            this.txt_phone_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_phone_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_phone_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_phone_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_phone_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_phone_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_phone_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_phone_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_phone_act.Image = null;
            this.txt_phone_act.Lines = null;
            this.txt_phone_act.Location = new System.Drawing.Point(32, 260);
            this.txt_phone_act.MaxLength = 32767;
            this.txt_phone_act.Multiline = false;
            this.txt_phone_act.Name = "txt_phone_act";
            this.txt_phone_act.ReadOnly = false;
            this.txt_phone_act.Size = new System.Drawing.Size(743, 30);
            this.txt_phone_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_phone_act.StyleManager = null;
            this.txt_phone_act.TabIndex = 13;
            this.txt_phone_act.Text = "Telefono";
            this.txt_phone_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_phone_act.ThemeAuthor = "Narwin";
            this.txt_phone_act.ThemeName = "MetroLite";
            this.txt_phone_act.UseSystemPasswordChar = false;
            this.txt_phone_act.WatermarkText = "";
            // 
            // txt_country_act
            // 
            this.txt_country_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_country_act.AutoCompleteCustomSource = null;
            this.txt_country_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_country_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_country_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_country_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_country_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_country_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_country_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_country_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_country_act.Image = null;
            this.txt_country_act.Lines = null;
            this.txt_country_act.Location = new System.Drawing.Point(32, 213);
            this.txt_country_act.MaxLength = 32767;
            this.txt_country_act.Multiline = false;
            this.txt_country_act.Name = "txt_country_act";
            this.txt_country_act.ReadOnly = false;
            this.txt_country_act.Size = new System.Drawing.Size(743, 30);
            this.txt_country_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_country_act.StyleManager = null;
            this.txt_country_act.TabIndex = 12;
            this.txt_country_act.Text = "Ciudad";
            this.txt_country_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_country_act.ThemeAuthor = "Narwin";
            this.txt_country_act.ThemeName = "MetroLite";
            this.txt_country_act.UseSystemPasswordChar = false;
            this.txt_country_act.WatermarkText = "";
            // 
            // txt_adress_act
            // 
            this.txt_adress_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_adress_act.AutoCompleteCustomSource = null;
            this.txt_adress_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_adress_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_adress_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_adress_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_adress_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_adress_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_adress_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_adress_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_adress_act.Image = null;
            this.txt_adress_act.Lines = null;
            this.txt_adress_act.Location = new System.Drawing.Point(32, 164);
            this.txt_adress_act.MaxLength = 32767;
            this.txt_adress_act.Multiline = false;
            this.txt_adress_act.Name = "txt_adress_act";
            this.txt_adress_act.ReadOnly = false;
            this.txt_adress_act.Size = new System.Drawing.Size(743, 30);
            this.txt_adress_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_adress_act.StyleManager = null;
            this.txt_adress_act.TabIndex = 11;
            this.txt_adress_act.Text = "Direccion";
            this.txt_adress_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_adress_act.ThemeAuthor = "Narwin";
            this.txt_adress_act.ThemeName = "MetroLite";
            this.txt_adress_act.UseSystemPasswordChar = false;
            this.txt_adress_act.WatermarkText = "";
            // 
            // txt_nss_act
            // 
            this.txt_nss_act.AutoCompleteCustomSource = null;
            this.txt_nss_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_nss_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_nss_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_nss_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_nss_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_nss_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_nss_act.Enabled = false;
            this.txt_nss_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nss_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_nss_act.Image = null;
            this.txt_nss_act.Lines = null;
            this.txt_nss_act.Location = new System.Drawing.Point(32, 70);
            this.txt_nss_act.MaxLength = 32767;
            this.txt_nss_act.Multiline = false;
            this.txt_nss_act.Name = "txt_nss_act";
            this.txt_nss_act.ReadOnly = false;
            this.txt_nss_act.Size = new System.Drawing.Size(743, 30);
            this.txt_nss_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_nss_act.StyleManager = null;
            this.txt_nss_act.TabIndex = 10;
            this.txt_nss_act.Text = "Numero de seguridad social";
            this.txt_nss_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nss_act.ThemeAuthor = "Narwin";
            this.txt_nss_act.ThemeName = "MetroLite";
            this.txt_nss_act.UseSystemPasswordChar = false;
            this.txt_nss_act.WatermarkText = "";
            // 
            // txt_name_act
            // 
            this.txt_name_act.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_act.AutoCompleteCustomSource = null;
            this.txt_name_act.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name_act.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name_act.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_name_act.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txt_name_act.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txt_name_act.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txt_name_act.Enabled = false;
            this.txt_name_act.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name_act.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txt_name_act.Image = null;
            this.txt_name_act.Lines = null;
            this.txt_name_act.Location = new System.Drawing.Point(32, 27);
            this.txt_name_act.MaxLength = 32767;
            this.txt_name_act.Multiline = false;
            this.txt_name_act.Name = "txt_name_act";
            this.txt_name_act.ReadOnly = false;
            this.txt_name_act.Size = new System.Drawing.Size(743, 30);
            this.txt_name_act.Style = MetroSet_UI.Design.Style.Light;
            this.txt_name_act.StyleManager = null;
            this.txt_name_act.TabIndex = 9;
            this.txt_name_act.Text = "Nombre";
            this.txt_name_act.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name_act.ThemeAuthor = "Narwin";
            this.txt_name_act.ThemeName = "MetroLite";
            this.txt_name_act.UseSystemPasswordChar = false;
            this.txt_name_act.WatermarkText = "";
            // 
            // dgv_pacientes_act
            // 
            this.dgv_pacientes_act.AllowUserToAddRows = false;
            this.dgv_pacientes_act.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_pacientes_act.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pacientes_act.Location = new System.Drawing.Point(826, 27);
            this.dgv_pacientes_act.Name = "dgv_pacientes_act";
            this.dgv_pacientes_act.ReadOnly = true;
            this.dgv_pacientes_act.RowTemplate.Height = 25;
            this.dgv_pacientes_act.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pacientes_act.Size = new System.Drawing.Size(240, 346);
            this.dgv_pacientes_act.TabIndex = 1;
            this.dgv_pacientes_act.SelectionChanged += new System.EventHandler(this.dgv_pacientes_act_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Pacientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WORKBENCH TENPIS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes_consulta)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pacientes_act)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_birthday;
        private MetroSet_UI.Controls.MetroSetTextBox txt_genre;
        private MetroSet_UI.Controls.MetroSetTextBox txt_phone;
        private MetroSet_UI.Controls.MetroSetTextBox txt_country;
        private MetroSet_UI.Controls.MetroSetTextBox txt_adress;
        private MetroSet_UI.Controls.MetroSetTextBox txt_nss;
        private MetroSet_UI.Controls.MetroSetTextBox txt_name;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_save_consulta;
        private System.Windows.Forms.TextBox txt_tratamiento;
        private System.Windows.Forms.TextBox txt_diagnostico;
        private System.Windows.Forms.TextBox txt_datos;
        private System.Windows.Forms.DateTimePicker dtp_fecha_consulta;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.DataGridView dgv_pacientes_consulta;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_pacientes_act;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtp_fecha_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_genre_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_phone_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_country_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_adress_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_nss_act;
        private MetroSet_UI.Controls.MetroSetTextBox txt_name_act;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

