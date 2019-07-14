namespace StudentskiServis
{
    partial class FrmUgovori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUgovori));
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStavkeUgovora = new System.Windows.Forms.DataGridView();
            this.cmbPoslodavac = new System.Windows.Forms.ComboBox();
            this.cmbPosao = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnUrediStavku = new System.Windows.Forms.Button();
            this.btnUnesiStavku = new System.Windows.Forms.Button();
            this.btnSpremiStavku = new System.Windows.Forms.Button();
            this.btnOdustaniStavka = new System.Windows.Forms.Button();
            this.cmbVrstaRada = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrojSati = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZaIsplatiti = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IDStavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUgovoraStavke = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaRada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ukupno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stavkaUgovoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ugovorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Poslodavac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatnicaUgovor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trajanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPoslodavca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeUgovora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUgovoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Location = new System.Drawing.Point(929, 237);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(68, 52);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Delete";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.Transparent;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Location = new System.Drawing.Point(842, 237);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(68, 52);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Update";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Transparent;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Location = new System.Drawing.Point(751, 237);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(68, 52);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Add";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Transparent;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Location = new System.Drawing.Point(751, 237);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(68, 52);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(842, 237);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(68, 52);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentskiServis.Properties.Resources.logo128x;
            this.pictureBox1.Location = new System.Drawing.Point(977, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(748, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(748, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(748, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Job:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(748, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer:";
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            this.dgvUgovori.AutoGenerateColumns = false;
            this.dgvUgovori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Poslodavac,
            this.Posao,
            this.Student,
            this.SatnicaUgovor,
            this.Trajanje,
            this.IDUgovora,
            this.IDPoslodavca,
            this.IDPosla,
            this.IDStudenta});
            this.dgvUgovori.DataSource = this.ugovorBindingSource;
            this.dgvUgovori.Location = new System.Drawing.Point(13, 32);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(718, 257);
            this.dgvUgovori.TabIndex = 13;
            this.dgvUgovori.SelectionChanged += new System.EventHandler(this.dgvUgovori_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Existing contracts:";
            // 
            // dgvStavkeUgovora
            // 
            this.dgvStavkeUgovora.AllowUserToAddRows = false;
            this.dgvStavkeUgovora.AllowUserToDeleteRows = false;
            this.dgvStavkeUgovora.AutoGenerateColumns = false;
            this.dgvStavkeUgovora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeUgovora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeUgovora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDStavke,
            this.IDUgovoraStavke,
            this.VrstaRada,
            this.BrojSati,
            this.Cijena,
            this.Ukupno});
            this.dgvStavkeUgovora.DataSource = this.stavkaUgovoraBindingSource;
            this.dgvStavkeUgovora.Location = new System.Drawing.Point(15, 319);
            this.dgvStavkeUgovora.Name = "dgvStavkeUgovora";
            this.dgvStavkeUgovora.ReadOnly = true;
            this.dgvStavkeUgovora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkeUgovora.Size = new System.Drawing.Size(716, 194);
            this.dgvStavkeUgovora.TabIndex = 27;
            this.dgvStavkeUgovora.SelectionChanged += new System.EventHandler(this.dgvStavkeUgovora_SelectionChanged);
            // 
            // cmbPoslodavac
            // 
            this.cmbPoslodavac.FormattingEnabled = true;
            this.cmbPoslodavac.Location = new System.Drawing.Point(751, 75);
            this.cmbPoslodavac.Name = "cmbPoslodavac";
            this.cmbPoslodavac.Size = new System.Drawing.Size(187, 21);
            this.cmbPoslodavac.TabIndex = 2;
            // 
            // cmbPosao
            // 
            this.cmbPosao.FormattingEnabled = true;
            this.cmbPosao.Location = new System.Drawing.Point(751, 115);
            this.cmbPosao.Name = "cmbPosao";
            this.cmbPosao.Size = new System.Drawing.Size(187, 21);
            this.cmbPosao.TabIndex = 4;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(751, 155);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(187, 21);
            this.cmbStudent.TabIndex = 6;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(751, 196);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(132, 20);
            this.dtpOd.TabIndex = 8;
            this.dtpOd.ValueChanged += new System.EventHandler(this.dtpOd_ValueChanged);
            this.dtpOd.MouseHover += new System.EventHandler(this.dtpOd_MouseHover);
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(889, 196);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(132, 20);
            this.dtpDo.TabIndex = 9;
            this.dtpDo.MouseHover += new System.EventHandler(this.dtpDo_MouseHover);
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiStavku.Location = new System.Drawing.Point(934, 541);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(68, 52);
            this.btnObrisiStavku.TabIndex = 25;
            this.btnObrisiStavku.Text = "Delete";
            this.btnObrisiStavku.UseVisualStyleBackColor = false;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnUrediStavku
            // 
            this.btnUrediStavku.BackColor = System.Drawing.Color.Transparent;
            this.btnUrediStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrediStavku.Location = new System.Drawing.Point(847, 541);
            this.btnUrediStavku.Name = "btnUrediStavku";
            this.btnUrediStavku.Size = new System.Drawing.Size(68, 52);
            this.btnUrediStavku.TabIndex = 24;
            this.btnUrediStavku.Text = "Update";
            this.btnUrediStavku.UseVisualStyleBackColor = false;
            this.btnUrediStavku.Click += new System.EventHandler(this.btnUrediStavku_Click);
            // 
            // btnUnesiStavku
            // 
            this.btnUnesiStavku.BackColor = System.Drawing.Color.Transparent;
            this.btnUnesiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesiStavku.Location = new System.Drawing.Point(756, 541);
            this.btnUnesiStavku.Name = "btnUnesiStavku";
            this.btnUnesiStavku.Size = new System.Drawing.Size(68, 52);
            this.btnUnesiStavku.TabIndex = 23;
            this.btnUnesiStavku.Text = "Add";
            this.btnUnesiStavku.UseVisualStyleBackColor = false;
            this.btnUnesiStavku.Click += new System.EventHandler(this.btnUnesiStavku_Click);
            // 
            // btnSpremiStavku
            // 
            this.btnSpremiStavku.BackColor = System.Drawing.Color.Transparent;
            this.btnSpremiStavku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiStavku.Location = new System.Drawing.Point(756, 541);
            this.btnSpremiStavku.Name = "btnSpremiStavku";
            this.btnSpremiStavku.Size = new System.Drawing.Size(68, 52);
            this.btnSpremiStavku.TabIndex = 41;
            this.btnSpremiStavku.Text = "Spremi";
            this.btnSpremiStavku.UseVisualStyleBackColor = false;
            this.btnSpremiStavku.Click += new System.EventHandler(this.btnSpremiStavku_Click);
            // 
            // btnOdustaniStavka
            // 
            this.btnOdustaniStavka.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustaniStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustaniStavka.Location = new System.Drawing.Point(847, 541);
            this.btnOdustaniStavka.Name = "btnOdustaniStavka";
            this.btnOdustaniStavka.Size = new System.Drawing.Size(68, 52);
            this.btnOdustaniStavka.TabIndex = 40;
            this.btnOdustaniStavka.Text = "Odustani";
            this.btnOdustaniStavka.UseVisualStyleBackColor = false;
            this.btnOdustaniStavka.Click += new System.EventHandler(this.btnOdustaniStavka_Click);
            // 
            // cmbVrstaRada
            // 
            this.cmbVrstaRada.FormattingEnabled = true;
            this.cmbVrstaRada.Items.AddRange(new object[] {
            "Redoviti rad",
            "Rad noću, blagdani, nedjelja (50%)",
            "Druge naknade"});
            this.cmbVrstaRada.Location = new System.Drawing.Point(756, 347);
            this.cmbVrstaRada.Name = "cmbVrstaRada";
            this.cmbVrstaRada.Size = new System.Drawing.Size(187, 21);
            this.cmbVrstaRada.TabIndex = 14;
            this.cmbVrstaRada.TextChanged += new System.EventHandler(this.cmbVrstaRada_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(753, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type of work:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(754, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Number of hours:";
            // 
            // txtBrojSati
            // 
            this.txtBrojSati.Location = new System.Drawing.Point(757, 387);
            this.txtBrojSati.Name = "txtBrojSati";
            this.txtBrojSati.Size = new System.Drawing.Size(67, 20);
            this.txtBrojSati.TabIndex = 16;
            this.txtBrojSati.TextChanged += new System.EventHandler(this.txtBrojSati_TextChanged);
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(757, 426);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(67, 20);
            this.txtCijena.TabIndex = 18;
            this.txtCijena.TextChanged += new System.EventHandler(this.txtCijena_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(754, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price:";
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(756, 465);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(67, 20);
            this.txtUkupno.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(753, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total:";
            // 
            // txtZaIsplatiti
            // 
            this.txtZaIsplatiti.Enabled = false;
            this.txtZaIsplatiti.Location = new System.Drawing.Point(1006, 347);
            this.txtZaIsplatiti.Name = "txtZaIsplatiti";
            this.txtZaIsplatiti.ReadOnly = true;
            this.txtZaIsplatiti.Size = new System.Drawing.Size(91, 20);
            this.txtZaIsplatiti.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(1003, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "To pay:";
            // 
            // IDStavke
            // 
            this.IDStavke.DataPropertyName = "ID_stavke";
            this.IDStavke.HeaderText = "Line ID";
            this.IDStavke.Name = "IDStavke";
            this.IDStavke.ReadOnly = true;
            // 
            // IDUgovoraStavke
            // 
            this.IDUgovoraStavke.DataPropertyName = "ID_ugovora";
            this.IDUgovoraStavke.HeaderText = "Agreement ID";
            this.IDUgovoraStavke.Name = "IDUgovoraStavke";
            this.IDUgovoraStavke.ReadOnly = true;
            this.IDUgovoraStavke.Visible = false;
            // 
            // VrstaRada
            // 
            this.VrstaRada.DataPropertyName = "VrstaRada";
            this.VrstaRada.HeaderText = "Type of work";
            this.VrstaRada.Name = "VrstaRada";
            this.VrstaRada.ReadOnly = true;
            // 
            // BrojSati
            // 
            this.BrojSati.DataPropertyName = "BrojSati";
            this.BrojSati.HeaderText = "Number of hours";
            this.BrojSati.Name = "BrojSati";
            this.BrojSati.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Price";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Ukupno
            // 
            this.Ukupno.DataPropertyName = "Ukupno";
            this.Ukupno.HeaderText = "Total";
            this.Ukupno.Name = "Ukupno";
            this.Ukupno.ReadOnly = true;
            // 
            // stavkaUgovoraBindingSource
            // 
            this.stavkaUgovoraBindingSource.DataSource = typeof(StudentskiServis.StavkaUgovora);
            // 
            // ugovorBindingSource
            // 
            this.ugovorBindingSource.DataSource = typeof(StudentskiServis.Ugovor);
            // 
            // Poslodavac
            // 
            this.Poslodavac.DataPropertyName = "Poslodavac";
            this.Poslodavac.HeaderText = "Employer";
            this.Poslodavac.Name = "Poslodavac";
            this.Poslodavac.ReadOnly = true;
            // 
            // Posao
            // 
            this.Posao.DataPropertyName = "Posao";
            this.Posao.HeaderText = "Job";
            this.Posao.Name = "Posao";
            this.Posao.ReadOnly = true;
            // 
            // Student
            // 
            this.Student.DataPropertyName = "Student";
            this.Student.HeaderText = "Student";
            this.Student.Name = "Student";
            this.Student.ReadOnly = true;
            // 
            // SatnicaUgovor
            // 
            this.SatnicaUgovor.DataPropertyName = "Satnica";
            this.SatnicaUgovor.HeaderText = "Satnica";
            this.SatnicaUgovor.Name = "SatnicaUgovor";
            this.SatnicaUgovor.ReadOnly = true;
            // 
            // Trajanje
            // 
            this.Trajanje.DataPropertyName = "Trajanje";
            this.Trajanje.HeaderText = "Trajanje";
            this.Trajanje.Name = "Trajanje";
            this.Trajanje.ReadOnly = true;
            // 
            // IDUgovora
            // 
            this.IDUgovora.DataPropertyName = "ID_ugovora";
            this.IDUgovora.HeaderText = "ID_ugovora";
            this.IDUgovora.Name = "IDUgovora";
            this.IDUgovora.ReadOnly = true;
            this.IDUgovora.Visible = false;
            // 
            // IDPoslodavca
            // 
            this.IDPoslodavca.DataPropertyName = "ID_poslodavca";
            this.IDPoslodavca.HeaderText = "ID_poslodavca";
            this.IDPoslodavca.Name = "IDPoslodavca";
            this.IDPoslodavca.ReadOnly = true;
            this.IDPoslodavca.Visible = false;
            // 
            // IDPosla
            // 
            this.IDPosla.DataPropertyName = "ID_posla";
            this.IDPosla.HeaderText = "ID_posla";
            this.IDPosla.Name = "IDPosla";
            this.IDPosla.ReadOnly = true;
            this.IDPosla.Visible = false;
            // 
            // IDStudenta
            // 
            this.IDStudenta.DataPropertyName = "ID_studenta";
            this.IDStudenta.HeaderText = "ID_studenta";
            this.IDStudenta.Name = "IDStudenta";
            this.IDStudenta.ReadOnly = true;
            this.IDStudenta.Visible = false;
            // 
            // FrmUgovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1117, 606);
            this.Controls.Add(this.txtZaIsplatiti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBrojSati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVrstaRada);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnUrediStavku);
            this.Controls.Add(this.btnUnesiStavku);
            this.Controls.Add(this.btnSpremiStavku);
            this.Controls.Add(this.btnOdustaniStavka);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.cmbPosao);
            this.Controls.Add(this.cmbPoslodavac);
            this.Controls.Add(this.dgvStavkeUgovora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUgovori);
            this.MaximumSize = new System.Drawing.Size(1133, 645);
            this.MinimumSize = new System.Drawing.Size(1133, 645);
            this.Name = "FrmUgovori";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.FrmUgovori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeUgovora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stavkaUgovoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ugovorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStavkeUgovora;
        private System.Windows.Forms.ComboBox cmbPoslodavac;
        private System.Windows.Forms.ComboBox cmbPosao;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnUrediStavku;
        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnUnesiStavku;
        private System.Windows.Forms.Button btnSpremiStavku;
        private System.Windows.Forms.Button btnOdustaniStavka;
        private System.Windows.Forms.ComboBox cmbVrstaRada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrojSati;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource stavkaUgovoraBindingSource;
        private System.Windows.Forms.TextBox txtZaIsplatiti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUgovoraStavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaRada;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojSati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ukupno;
        private System.Windows.Forms.BindingSource ugovorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poslodavac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatnicaUgovor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trajanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUgovora;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPoslodavca;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDStudenta;
    }
}