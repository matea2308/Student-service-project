namespace StudentskiServis
{
    partial class FrmIzvjestaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIzvjestaj));
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDodatniFilter = new System.Windows.Forms.ComboBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.Mjesec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivStudenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnoSati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGlavniFilter = new System.Windows.Forms.ComboBox();
            this.lblDodatniFilter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NazivPoslodavca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupnaCijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izvjestajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.Location = new System.Drawing.Point(722, 345);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(68, 52);
            this.btnFiltriraj.TabIndex = 5;
            this.btnFiltriraj.Text = "Filter";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(588, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter by:";
            // 
            // cmbDodatniFilter
            // 
            this.cmbDodatniFilter.FormattingEnabled = true;
            this.cmbDodatniFilter.Location = new System.Drawing.Point(588, 68);
            this.cmbDodatniFilter.Name = "cmbDodatniFilter";
            this.cmbDodatniFilter.Size = new System.Drawing.Size(187, 21);
            this.cmbDodatniFilter.TabIndex = 4;
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.AutoGenerateColumns = false;
            this.dgvIzvjestaj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivPoslodavca,
            this.Mjesec,
            this.NazivStudenta,
            this.UkupnaCijena,
            this.UkupnoSati});
            this.dgvIzvjestaj.DataSource = this.izvjestajBindingSource;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(12, 12);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(570, 385);
            this.dgvIzvjestaj.TabIndex = 48;
            // 
            // Mjesec
            // 
            this.Mjesec.DataPropertyName = "Mjesec";
            this.Mjesec.HeaderText = "Month";
            this.Mjesec.Name = "Mjesec";
            this.Mjesec.ReadOnly = true;
            // 
            // NazivStudenta
            // 
            this.NazivStudenta.DataPropertyName = "NazivStudenta";
            this.NazivStudenta.HeaderText = "Student\'s name";
            this.NazivStudenta.Name = "NazivStudenta";
            this.NazivStudenta.ReadOnly = true;
            // 
            // UkupnoSati
            // 
            this.UkupnoSati.DataPropertyName = "UkupnoSati";
            this.UkupnoSati.HeaderText = "Total hours";
            this.UkupnoSati.Name = "UkupnoSati";
            this.UkupnoSati.ReadOnly = true;
            // 
            // cmbGlavniFilter
            // 
            this.cmbGlavniFilter.FormattingEnabled = true;
            this.cmbGlavniFilter.Items.AddRange(new object[] {
            "Mjesecu",
            "Studentu",
            "Poslodavcu"});
            this.cmbGlavniFilter.Location = new System.Drawing.Point(588, 28);
            this.cmbGlavniFilter.Name = "cmbGlavniFilter";
            this.cmbGlavniFilter.Size = new System.Drawing.Size(187, 21);
            this.cmbGlavniFilter.TabIndex = 2;
            this.cmbGlavniFilter.TextChanged += new System.EventHandler(this.cmbGlavniFilter_TextChanged);
            // 
            // lblDodatniFilter
            // 
            this.lblDodatniFilter.AutoSize = true;
            this.lblDodatniFilter.BackColor = System.Drawing.Color.Transparent;
            this.lblDodatniFilter.Location = new System.Drawing.Point(588, 52);
            this.lblDodatniFilter.Name = "lblDodatniFilter";
            this.lblDodatniFilter.Size = new System.Drawing.Size(45, 13);
            this.lblDodatniFilter.TabIndex = 3;
            this.lblDodatniFilter.Text = "Months:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentskiServis.Properties.Resources.logo128x;
            this.pictureBox1.Location = new System.Drawing.Point(832, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // NazivPoslodavca
            // 
            this.NazivPoslodavca.DataPropertyName = "NazivPoslodavca";
            this.NazivPoslodavca.HeaderText = "Employer\'s name";
            this.NazivPoslodavca.Name = "NazivPoslodavca";
            this.NazivPoslodavca.ReadOnly = true;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.DataPropertyName = "UkupnaCijena";
            this.UkupnaCijena.HeaderText = "Total price";
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.ReadOnly = true;
            // 
            // izvjestajBindingSource
            // 
            this.izvjestajBindingSource.DataSource = typeof(StudentskiServis.Izvjestaj);
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(976, 522);
            this.Controls.Add(this.lblDodatniFilter);
            this.Controls.Add(this.cmbGlavniFilter);
            this.Controls.Add(this.dgvIzvjestaj);
            this.Controls.Add(this.cmbDodatniFilter);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(992, 561);
            this.MinimumSize = new System.Drawing.Size(992, 561);
            this.Name = "FrmIzvjestaj";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.FrmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvjestajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDodatniFilter;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.ComboBox cmbGlavniFilter;
        private System.Windows.Forms.Label lblDodatniFilter;
        private System.Windows.Forms.BindingSource izvjestajBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPoslodavca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mjesec;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnaCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupnoSati;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}