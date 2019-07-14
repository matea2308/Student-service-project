using System;
using System.Windows.Forms;

namespace StudentskiServis
{
    public partial class FrmPoslovi : Form
    {
        private bool uredjivanjeposla = false;
        private int ID_posla;

        public FrmPoslovi()
        {
            InitializeComponent();
        }

        private void OsvjeziPrikaz()
        {
            posaoBindingSource.DataSource = Upiti.PopisPoslova();
        }

        private void FrmPoslovi_Load(object sender, EventArgs e)
        {
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtMjesto.Enabled = false;
            txtOpis.Enabled = false;
            txtSatnica.Enabled = false;
            txtVrsta.Enabled = false;
            cmbGrupePoslova.Enabled = false;
            posaoBindingSource.DataSource = Upiti.PopisPoslova();
            cmbGrupePoslova.DataSource = Upiti.PopisGrupaPoslova();
            cmbGrupePoslova.DisplayMember = "naziv_grupe";
            cmbGrupePoslova.ValueMember = "ID_grupe";
            ObrisiSve();
            
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            SakrijGlavneButtone();
            ObrisiSve();
            uredjivanjeposla = false;
            ID_posla = -1;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            if (dgvPoslovi.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected job? ", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int indeksOznacenog = dgvPoslovi.SelectedCells[0].RowIndex;

                    DataGridViewRow oznaceniRed = dgvPoslovi.Rows[indeksOznacenog];

                    int ID = int.Parse(oznaceniRed.Cells["IDPosla"].Value.ToString());

                    uspjeh = Upiti.ObrisiPosao(ID);
                }

            }
            if(uspjeh)
                OsvjeziPrikaz();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            uredjivanjeposla = true;
            SakrijGlavneButtone();
            if (dgvPoslovi.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvPoslovi.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvPoslovi.Rows[indeksOznacenog];

                ID_posla = int.Parse(oznaceniRed.Cells["IDPosla"].Value.ToString());
                txtVrsta.Text = oznaceniRed.Cells["VrstaPosla"].Value.ToString();
                txtOpis.Text = oznaceniRed.Cells["Opis"].Value.ToString();
                txtMjesto.Text = oznaceniRed.Cells["MjestoObavljanja"].Value.ToString();
                txtSatnica.Text = oznaceniRed.Cells["Satnica"].Value.ToString();
                cmbGrupePoslova.SelectedValue = int.Parse(oznaceniRed.Cells["IDGrupe"].Value.ToString());

            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            Posao posao = new Posao();

            posao.ID_grupe = int.Parse(cmbGrupePoslova.SelectedValue.ToString());
            posao.VrstaPosla = txtVrsta.Text;
            posao.Opis = txtOpis.Text;
            posao.MjestoObavljanja = txtMjesto.Text;
            posao.Satnica = double.Parse(txtSatnica.Text.ToString());
            

            if (uredjivanjeposla)
            {
                posao.ID_posla = ID_posla;
                uspjeh = Upiti.UrediPosao(posao);
            }
            else uspjeh = Upiti.UnesiPosao(posao);

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

        private void dgvPoslovi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPoslovi.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvPoslovi.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvPoslovi.Rows[indeksOznacenog];
                txtVrsta.Text = oznaceniRed.Cells["VrstaPosla"].Value.ToString();
                txtOpis.Text = oznaceniRed.Cells["Opis"].Value.ToString();
                txtMjesto.Text = oznaceniRed.Cells["MjestoObavljanja"].Value.ToString();
                txtSatnica.Text = oznaceniRed.Cells["Satnica"].Value.ToString();
                cmbGrupePoslova.SelectedValue = int.Parse(oznaceniRed.Cells["IDGrupe"].Value.ToString());

            }
        }

        private void SakrijGlavneButtone()
        {
            btnObrisi.Hide();
            btnUnesi.Hide();
            btnUredi.Hide();
            btnSpremi.Show();
            btnOdustani.Show();
            txtVrsta.Enabled = true;
            txtSatnica.Enabled = true;
            txtOpis.Enabled = true;
            txtMjesto.Enabled = true;
            cmbGrupePoslova.Enabled = true;
            
        }

        private void PrikaziGlavneButtone()
        {
            btnObrisi.Show();
            btnUnesi.Show();
            btnUredi.Show();
            btnSpremi.Hide();
            btnOdustani.Hide();
            txtVrsta.Enabled = false;
            txtSatnica.Enabled = false;
            txtOpis.Enabled = false;
            txtMjesto.Enabled = false;
            cmbGrupePoslova.Enabled = false;
        }

        private void ObrisiSve()
        {
            txtMjesto.Clear();
            txtOpis.Clear();
            txtSatnica.Clear();
            txtVrsta.Clear();
            cmbGrupePoslova.ResetText();


        }

        private void txtSatnica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
