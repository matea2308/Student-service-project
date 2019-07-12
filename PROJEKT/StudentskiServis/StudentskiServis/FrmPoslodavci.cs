using System;
using System.Windows.Forms;

namespace StudentskiServis
{
    public partial class FrmPoslodavci : Form
    {
        private bool uredjivanjePoslodavca = false;
        private int ID_poslodavca;

        public FrmPoslodavci()
        {
            InitializeComponent();
        }

        private void OsvjeziPrikaz()
        {
            poslodavacBindingSource.DataSource = Upiti.PopisPoslodavaca();
        }

        private void FrmPoslodavci_Load(object sender, EventArgs e)
        {
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtOIB.Enabled = false;
            txtSifra.Enabled = false;
            txtNaziv.Enabled = false;
            txtSjediste.Enabled = false;
            txtOIB.Enabled = false;        
            poslodavacBindingSource.DataSource = Upiti.PopisPoslodavaca();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            uredjivanjePoslodavca = true;
            SakrijGlavneButtone();
            if (dgvPoslodavci.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvPoslodavci.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvPoslodavci.Rows[indeksOznacenog];

                ID_poslodavca = int.Parse(oznaceniRed.Cells["IDPoslodavca"].Value.ToString());
                txtSifra.Text = oznaceniRed.Cells["Sifra"].Value.ToString();
                txtNaziv.Text = oznaceniRed.Cells["Naziv"].Value.ToString();
                txtSjediste.Text = oznaceniRed.Cells["Sjediste"].Value.ToString();
                txtOIB.Text = oznaceniRed.Cells["OIB"].Value.ToString();
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {          
            SakrijGlavneButtone();
            ObrisiSve();
            uredjivanjePoslodavca = false;
            ID_poslodavca = -1;            
            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            if (dgvPoslodavci.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected employer?" , "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int indeksOznacenog = dgvPoslodavci.SelectedCells[0].RowIndex;

                    DataGridViewRow oznaceniRed = dgvPoslodavci.Rows[indeksOznacenog];

                    int ID = int.Parse(oznaceniRed.Cells["IDPoslodavca"].Value.ToString());

                    uspjeh = Upiti.ObrisiPoslodavca(ID);
                }
                if(uspjeh)
                    OsvjeziPrikaz();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PrikaziGlavneButtone();
            ObrisiSve();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            Poslodavac poslodavac = new Poslodavac();

            poslodavac.Sifra = txtSifra.Text;
            poslodavac.Naziv = txtNaziv.Text;
            poslodavac.Sjediste = txtSjediste.Text;
            poslodavac.OIB = txtOIB.Text;
            

            if (uredjivanjePoslodavca)
            {
                poslodavac.ID_poslodavca = ID_poslodavca;
                uspjeh = Upiti.UrediPoslodavca(poslodavac);
            }
            else uspjeh = Upiti.UnesiPoslodavca(poslodavac);

            if (uspjeh)
            {
                OsvjeziPrikaz();
                PrikaziGlavneButtone();
                ObrisiSve();
            }
        }

        private void dgvPoslodavci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPoslodavci.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvPoslodavci.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvPoslodavci.Rows[indeksOznacenog];
                txtSifra.Text = oznaceniRed.Cells[1].Value.ToString();
                txtNaziv.Text = oznaceniRed.Cells[2].Value.ToString();
                txtSjediste.Text = oznaceniRed.Cells[3].Value.ToString();
                txtOIB.Text = oznaceniRed.Cells[4].Value.ToString();
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
            txtNaziv.Enabled = true;
            txtSifra.Enabled = true;
            txtSjediste.Enabled = true;
        }

        private void PrikaziGlavneButtone()
        {
            btnObrisi.Show();
            btnUnesi.Show();
            btnUredi.Show();
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtOIB.Enabled = false;
            txtNaziv.Enabled = false;
            txtSifra.Enabled = false;
            txtSjediste.Enabled = false;
        }

        private void ObrisiSve()
        {
            txtNaziv.Clear();
            txtOIB.Clear();
            txtSifra.Clear();
            txtSjediste.Clear();
        }

        private void txtSifra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtOIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
