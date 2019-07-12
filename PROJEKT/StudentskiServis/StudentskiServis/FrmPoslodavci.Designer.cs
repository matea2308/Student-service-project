namespace StudentskiServis
{
    partial class FrmPoslodavci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoslodavci));
            this.dgvPoslodavci = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSjediste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOIB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IDPoslodavca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sjediste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OIB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poslodavacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslodavci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslodavacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPoslodavci
            // 
            this.dgvPoslodavci.AllowUserToAddRows = false;
            this.dgvPoslodavci.AllowUserToDeleteRows = false;
            this.dgvPoslodavci.AutoGenerateColumns = false;
            this.dgvPoslodavci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPoslodavci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslodavci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPoslodavca,
            this.Sifra,
            this.Naziv,
            this.Sjediste,
            this.OIB});
            this.dgvPoslodavci.DataSource = this.poslodavacBindingSource;
            this.dgvPoslodavci.Location = new System.Drawing.Point(13, 38);
            this.dgvPoslodavci.Name = "dgvPoslodavci";
            this.dgvPoslodavci.ReadOnly = true;
            this.dgvPoslodavci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslodavci.Size = new System.Drawing.Size(673, 368);
            this.dgvPoslodavci.TabIndex = 0;
            this.dgvPoslodavci.SelectionChanged += new System.EventHandler(this.dgvPoslodavci_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(692, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employer\'s code:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(695, 167);
            this.txtSifra.MaxLength = 4;
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(187, 20);
            this.txtSifra.TabIndex = 2;
            this.txtSifra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifra_KeyPress);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(695, 207);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(187, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(692, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employer\'s name:";
            // 
            // txtSjediste
            // 
            this.txtSjediste.Location = new System.Drawing.Point(695, 247);
            this.txtSjediste.Name = "txtSjediste";
            this.txtSjediste.Size = new System.Drawing.Size(187, 20);
            this.txtSjediste.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(692, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Place:";
            // 
            // txtOIB
            // 
            this.txtOIB.Location = new System.Drawing.Point(695, 287);
            this.txtOIB.MaxLength = 11;
            this.txtOIB.Name = "txtOIB";
            this.txtOIB.Size = new System.Drawing.Size(187, 20);
            this.txtOIB.TabIndex = 8;
            this.txtOIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOIB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(692, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentskiServis.Properties.Resources.logo128x;
            this.pictureBox1.Location = new System.Drawing.Point(813, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Transparent;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Location = new System.Drawing.Point(695, 354);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(68, 52);
            this.btnUnesi.TabIndex = 10;
            this.btnUnesi.Text = "Add";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.Transparent;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Location = new System.Drawing.Point(786, 354);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(68, 52);
            this.btnUredi.TabIndex = 11;
            this.btnUredi.Text = "Update";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Transparent;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Location = new System.Drawing.Point(695, 354);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(68, 52);
            this.btnSpremi.TabIndex = 22;
            this.btnSpremi.Text = "Save";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(786, 354);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(68, 52);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Location = new System.Drawing.Point(873, 354);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(68, 52);
            this.btnObrisi.TabIndex = 12;
            this.btnObrisi.Text = "Delete";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Existing employers:";
            // 
            // IDPoslodavca
            // 
            this.IDPoslodavca.DataPropertyName = "ID_poslodavca";
            this.IDPoslodavca.HeaderText = "Employer ID";
            this.IDPoslodavca.Name = "IDPoslodavca";
            this.IDPoslodavca.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Code";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Name";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Sjediste
            // 
            this.Sjediste.DataPropertyName = "Sjediste";
            this.Sjediste.HeaderText = "Place";
            this.Sjediste.Name = "Sjediste";
            this.Sjediste.ReadOnly = true;
            // 
            // OIB
            // 
            this.OIB.DataPropertyName = "OIB";
            this.OIB.HeaderText = "OIB";
            this.OIB.Name = "OIB";
            this.OIB.ReadOnly = true;
            // 
            // poslodavacBindingSource
            // 
            this.poslodavacBindingSource.DataSource = typeof(StudentskiServis.Poslodavac);
            // 
            // FrmPoslodavci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOIB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSjediste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoslodavci);
            this.MaximumSize = new System.Drawing.Size(988, 489);
            this.MinimumSize = new System.Drawing.Size(988, 489);
            this.Name = "FrmPoslodavci";
            this.Text = "Employers";
            this.Load += new System.EventHandler(this.FrmPoslodavci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslodavci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poslodavacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPoslodavci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSjediste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOIB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource poslodavacBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPoslodavca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sjediste;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIB;
    }
}