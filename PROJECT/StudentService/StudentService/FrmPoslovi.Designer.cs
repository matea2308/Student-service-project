namespace StudentskiServis
{
    partial class FrmPoslovi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPoslovi));
            this.label6 = new System.Windows.Forms.Label();
            this.txtSatnica = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPoslovi = new System.Windows.Forms.DataGridView();
            this.IDPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGrupe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoObavljanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Satnica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrupaPosla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGrupePoslova = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(840, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A group of work:";
            // 
            // txtSatnica
            // 
            this.txtSatnica.Location = new System.Drawing.Point(843, 299);
            this.txtSatnica.Name = "txtSatnica";
            this.txtSatnica.Size = new System.Drawing.Size(187, 20);
            this.txtSatnica.TabIndex = 10;
            this.txtSatnica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSatnica_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(840, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hourly rate:";
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.Transparent;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Location = new System.Drawing.Point(1017, 345);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(68, 52);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Delete";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.Transparent;
            this.btnUredi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUredi.Location = new System.Drawing.Point(930, 345);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(68, 52);
            this.btnUredi.TabIndex = 12;
            this.btnUredi.Text = "Update";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Transparent;
            this.btnUnesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnesi.Location = new System.Drawing.Point(839, 345);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(68, 52);
            this.btnUnesi.TabIndex = 11;
            this.btnUnesi.Text = "Add";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Transparent;
            this.btnSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremi.Location = new System.Drawing.Point(839, 345);
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
            this.btnOdustani.Location = new System.Drawing.Point(930, 345);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(68, 52);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Cancel";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(843, 259);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(187, 20);
            this.txtMjesto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(840, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Place:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(843, 219);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(187, 20);
            this.txtOpis.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(840, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(843, 137);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(187, 20);
            this.txtVrsta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(840, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of work:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentskiServis.Properties.Resources.logo128x;
            this.pictureBox1.Location = new System.Drawing.Point(953, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPoslovi
            // 
            this.dgvPoslovi.AllowUserToAddRows = false;
            this.dgvPoslovi.AllowUserToDeleteRows = false;
            this.dgvPoslovi.AutoGenerateColumns = false;
            this.dgvPoslovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDPosla,
            this.IDGrupe,
            this.VrstaPosla,
            this.Opis,
            this.MjestoObavljanja,
            this.Satnica,
            this.GrupaPosla});
            this.dgvPoslovi.DataSource = this.posaoBindingSource;
            this.dgvPoslovi.Location = new System.Drawing.Point(12, 33);
            this.dgvPoslovi.MaximumSize = new System.Drawing.Size(805, 364);
            this.dgvPoslovi.MinimumSize = new System.Drawing.Size(805, 364);
            this.dgvPoslovi.Name = "dgvPoslovi";
            this.dgvPoslovi.ReadOnly = true;
            this.dgvPoslovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPoslovi.Size = new System.Drawing.Size(805, 364);
            this.dgvPoslovi.TabIndex = 29;
            this.dgvPoslovi.SelectionChanged += new System.EventHandler(this.dgvPoslovi_SelectionChanged);
            // 
            // IDPosla
            // 
            this.IDPosla.DataPropertyName = "ID_posla";
            this.IDPosla.HeaderText = "Job ID";
            this.IDPosla.Name = "IDPosla";
            this.IDPosla.ReadOnly = true;
            this.IDPosla.Width = 127;
            // 
            // IDGrupe
            // 
            this.IDGrupe.DataPropertyName = "ID_grupe";
            this.IDGrupe.HeaderText = "Group ID";
            this.IDGrupe.Name = "IDGrupe";
            this.IDGrupe.ReadOnly = true;
            this.IDGrupe.Visible = false;
            // 
            // VrstaPosla
            // 
            this.VrstaPosla.DataPropertyName = "VrstaPosla";
            this.VrstaPosla.HeaderText = "Type of work";
            this.VrstaPosla.Name = "VrstaPosla";
            this.VrstaPosla.ReadOnly = true;
            this.VrstaPosla.Width = 127;
            // 
            // Opis
            // 
            this.Opis.DataPropertyName = "Opis";
            this.Opis.HeaderText = "Description";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 127;
            // 
            // MjestoObavljanja
            // 
            this.MjestoObavljanja.DataPropertyName = "MjestoObavljanja";
            this.MjestoObavljanja.HeaderText = "Place";
            this.MjestoObavljanja.Name = "MjestoObavljanja";
            this.MjestoObavljanja.ReadOnly = true;
            this.MjestoObavljanja.Width = 127;
            // 
            // Satnica
            // 
            this.Satnica.DataPropertyName = "Satnica";
            this.Satnica.HeaderText = "Hourly rate";
            this.Satnica.Name = "Satnica";
            this.Satnica.ReadOnly = true;
            this.Satnica.Width = 127;
            // 
            // GrupaPosla
            // 
            this.GrupaPosla.DataPropertyName = "GrupaPosla";
            this.GrupaPosla.HeaderText = "A group of work";
            this.GrupaPosla.Name = "GrupaPosla";
            this.GrupaPosla.ReadOnly = true;
            this.GrupaPosla.Width = 127;
            // 
            // posaoBindingSource
            // 
            this.posaoBindingSource.DataSource = typeof(StudentskiServis.Posao);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Existing jobs:";
            // 
            // cmbGrupePoslova
            // 
            this.cmbGrupePoslova.FormattingEnabled = true;
            this.cmbGrupePoslova.Location = new System.Drawing.Point(843, 180);
            this.cmbGrupePoslova.Name = "cmbGrupePoslova";
            this.cmbGrupePoslova.Size = new System.Drawing.Size(187, 21);
            this.cmbGrupePoslova.TabIndex = 4;
            // 
            // FrmPoslovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 515);
            this.Controls.Add(this.cmbGrupePoslova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSatnica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPoslovi);
            this.Name = "FrmPoslovi";
            this.Text = "Jobs";
            this.Load += new System.EventHandler(this.FrmPoslovi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatnica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPoslovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGrupePoslova;
        private System.Windows.Forms.BindingSource posaoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGrupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaPosla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoObavljanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satnica;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrupaPosla;
    }
}