using System;
using System.Windows.Forms;

namespace StudentskiServis
{
    public partial class FrmStudenti : Form
    {
        private bool uredjivanjeStudenta = false;
        private int ID_studenta;

        public FrmStudenti()
        {
            InitializeComponent();
        }

        private void OsvjeziPrikaz()
        {
            studentBindingSource.DataSource = Upiti.PopisStudenata();
        }

        private void FrmStudenti_Load(object sender, EventArgs e)
        {         
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtOIB.Enabled = false;
            txtAdresa.Enabled = false;
            txtBrStudIskaz.Enabled = false;
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            cmbStrucneSpreme.Enabled = false;
            dtpDatumRodenja.Enabled = false;
            studentBindingSource.DataSource = Upiti.PopisStudenata();
            cmbStrucneSpreme.DataSource = Upiti.PopisStrucnihSprema();
            cmbStrucneSpreme.DisplayMember = "Naziv";
            cmbStrucneSpreme.ValueMember = "ID_spreme";
            //dtpDatumRodenja.MaxDate = DateTime.Now.AddYears(-15);
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            SakrijGlavneButtone();
            ObrisiSve();
            uredjivanjeStudenta = false;
            ID_studenta = -1;          
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            if (dgvStudenti.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected student?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int indeksOznacenog = dgvStudenti.SelectedCells[0].RowIndex;

                    DataGridViewRow oznaceniRed = dgvStudenti.Rows[indeksOznacenog];

                    int ID = int.Parse(oznaceniRed.Cells["IDStudenta"].Value.ToString());

                    uspjeh = Upiti.ObrisiStudenta(ID);
                }

            }
            if(uspjeh)
                OsvjeziPrikaz();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            uredjivanjeStudenta = true;
            SakrijGlavneButtone();
            if (dgvStudenti.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvStudenti.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvStudenti.Rows[indeksOznacenog];

                ID_studenta = int.Parse(oznaceniRed.Cells["IDStudenta"].Value.ToString());
                txtOIB.Text = oznaceniRed.Cells["OIB"].Value.ToString();
                txtAdresa.Text = oznaceniRed.Cells["Adresa"].Value.ToString();
                txtBrStudIskaz.Text = oznaceniRed.Cells["BrojIskaznice"].Value.ToString();
                txtIme.Text = oznaceniRed.Cells["Ime"].Value.ToString();
                txtPrezime.Text = oznaceniRed.Cells["Prezime"].Value.ToString();
                cmbStrucneSpreme.SelectedValue = int.Parse(oznaceniRed.Cells["IDSpreme"].Value.ToString());
                dtpDatumRodenja.Value = DateTime.Parse(oznaceniRed.Cells["DatumRodjenja"].Value.ToString());
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            Student student = new Student();
            
            student.ID_spreme = int.Parse(cmbStrucneSpreme.SelectedValue.ToString());
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.Adresa = txtAdresa.Text;
            student.DatumRodjenja = dtpDatumRodenja.Value;
            student.OIB = txtOIB.Text;
            student.BrojIskaznice = txtBrStudIskaz.Text;

            if (uredjivanjeStudenta)
            {
                student.ID_studenta = ID_studenta;
                uspjeh = Upiti.UrediStudenta(student);
            }
            else uspjeh = Upiti.UnesiStudenta(student);

            if (uspjeh)
            {
                OsvjeziPrikaz();
                PrikaziGlavneButtone();
                ObrisiSve();
            }  
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PrikaziGlavneButtone();
            ObrisiSve();
        }

        private void dgvStudenti_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudenti.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvStudenti.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvStudenti.Rows[indeksOznacenog];

                txtOIB.Text = oznaceniRed.Cells["OIB"].Value.ToString();
                txtAdresa.Text = oznaceniRed.Cells["Adresa"].Value.ToString();
                txtBrStudIskaz.Text = oznaceniRed.Cells["BrojIskaznice"].Value.ToString();
                txtIme.Text = oznaceniRed.Cells["Ime"].Value.ToString();
                txtPrezime.Text = oznaceniRed.Cells["Prezime"].Value.ToString();
                cmbStrucneSpreme.SelectedValue = int.Parse(oznaceniRed.Cells["IDSpreme"].Value.ToString());
                dtpDatumRodenja.Value = DateTime.Parse(oznaceniRed.Cells["DatumRodjenja"].Value.ToString());

            }
        }

        private void SakrijGlavneButtone()
        {
            btnObrisi.Hide();
            btnUnesi.Hide();
            btnUredi.Hide();
            btnSpremi.Show();
            btnOdustani.Show();
            txtOIB.Enabled = true;
            txtAdresa.Enabled = true;
            txtBrStudIskaz.Enabled = true;
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            cmbStrucneSpreme.Enabled = true;
            dtpDatumRodenja.Enabled = true;
          
        }

        private void PrikaziGlavneButtone()
        {
            btnObrisi.Show();
            btnUnesi.Show();
            btnUredi.Show();
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtOIB.Enabled = false;
            txtAdresa.Enabled = false;
            txtBrStudIskaz.Enabled = false;
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            cmbStrucneSpreme.Enabled = false;
            dtpDatumRodenja.Enabled = false;

        }

        private void ObrisiSve()
        {
            txtAdresa.Clear();
            txtBrStudIskaz.Clear();
            txtIme.Clear();
            txtOIB.Clear();
            txtPrezime.Clear();
            cmbStrucneSpreme.ResetText();
           

        }

        private void txtOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBrStudIskaz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
