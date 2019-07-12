namespace StudentskiServis
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.btnPoslodavci = new System.Windows.Forms.Button();
            this.btnPoslovi = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPoslodavci
            // 
            this.btnPoslodavci.BackColor = System.Drawing.Color.Transparent;
            this.btnPoslodavci.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPoslodavci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoslodavci.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoslodavci.ForeColor = System.Drawing.Color.Black;
            this.btnPoslodavci.Location = new System.Drawing.Point(94, 398);
            this.btnPoslodavci.Name = "btnPoslodavci";
            this.btnPoslodavci.Size = new System.Drawing.Size(120, 40);
            this.btnPoslodavci.TabIndex = 0;
            this.btnPoslodavci.Text = "Employers";
            this.btnPoslodavci.UseVisualStyleBackColor = false;
            this.btnPoslodavci.Click += new System.EventHandler(this.btnPoslodavci_Click);
            // 
            // btnPoslovi
            // 
            this.btnPoslovi.BackColor = System.Drawing.Color.Transparent;
            this.btnPoslovi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPoslovi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoslovi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoslovi.ForeColor = System.Drawing.Color.Black;
            this.btnPoslovi.Location = new System.Drawing.Point(473, 398);
            this.btnPoslovi.Name = "btnPoslovi";
            this.btnPoslovi.Size = new System.Drawing.Size(120, 40);
            this.btnPoslovi.TabIndex = 3;
            this.btnPoslovi.Text = "Jobs";
            this.btnPoslovi.UseVisualStyleBackColor = false;
            this.btnPoslovi.Click += new System.EventHandler(this.btnPoslovi_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.BackColor = System.Drawing.Color.Transparent;
            this.btnUgovori.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUgovori.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUgovori.ForeColor = System.Drawing.Color.Black;
            this.btnUgovori.Location = new System.Drawing.Point(220, 398);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(120, 40);
            this.btnUgovori.TabIndex = 1;
            this.btnUgovori.Text = "Contracts";
            this.btnUgovori.UseVisualStyleBackColor = false;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // btnStudenti
            // 
            this.btnStudenti.BackColor = System.Drawing.Color.Transparent;
            this.btnStudenti.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStudenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudenti.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStudenti.ForeColor = System.Drawing.Color.Black;
            this.btnStudenti.Location = new System.Drawing.Point(346, 398);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(120, 40);
            this.btnStudenti.TabIndex = 2;
            this.btnStudenti.Text = "Students";
            this.btnStudenti.UseVisualStyleBackColor = false;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.Transparent;
            this.btnIzvjestaj.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIzvjestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaj.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaj.ForeColor = System.Drawing.Color.Black;
            this.btnIzvjestaj.Location = new System.Drawing.Point(599, 398);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(120, 40);
            this.btnIzvjestaj.TabIndex = 4;
            this.btnIzvjestaj.Text = "Reports";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnStudenti);
            this.Controls.Add(this.btnUgovori);
            this.Controls.Add(this.btnPoslovi);
            this.Controls.Add(this.btnPoslodavci);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmGlavna";
            this.Text = "Student service";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoslodavci;
        private System.Windows.Forms.Button btnPoslovi;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}

