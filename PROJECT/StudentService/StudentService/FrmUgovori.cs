using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentskiServis
{
    public partial class FrmUgovori : Form
    {
        private bool uredjivanjeUgovora = false;
        private bool uredjivanjeStavke = false;
        private int ID_ugovora;
        private int ID_stavke;
        private double satnica;
        private DateTime minDatum;

        public FrmUgovori()
        {
            InitializeComponent();
        }

        private void OsvjeziPrikaz()
        {
            ugovorBindingSource.DataSource = Upiti.PopisUgovora();
        }

        private void OsvjeziStavke(int ID_ugovora)
        {
            stavkaUgovoraBindingSource.DataSource = Upiti.PopisStavkiUgovora(ID_ugovora);
        }

        private void FrmUgovori_Load(object sender, EventArgs e)
        {
            dtpOd.Value = DateTime.Now.Date;
            dtpDo.Value = DateTime.Now.Date;
            dtpDo.MinDate = dtpOd.Value.Date;
            btnSpremi.Hide();
            btnOdustani.Hide();
            PrikaziGlavneButtone();
            PrikaziGlavneButtoneStavke();
            ugovorBindingSource.DataSource = Upiti.PopisUgovora();
            cmbStudent.DataSource = Upiti.PopisStudenata();
            cmbStudent.DisplayMember = "imeiprezime";
            cmbStudent.ValueMember = "ID_studenta";
            cmbPoslodavac.DataSource = Upiti.PopisPoslodavaca();
            cmbPoslodavac.DisplayMember = "Naziv";
            cmbPoslodavac.ValueMember = "ID_poslodavca";
            cmbPosao.DataSource = Upiti.PopisPoslova();
            cmbPosao.DisplayMember = "vrstaposla";
            cmbPosao.ValueMember = "ID_posla";
            minDatum = dtpOd.Value;
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            SakrijGlavneButtone();
            ObrisiGlavnaPolja();
            uredjivanjeUgovora = false;
            ID_ugovora = -1;
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            if (dgvUgovori.SelectedCells.Count > 0)
            {
                if (dgvStavkeUgovora.SelectedCells.Count > 0)
                {
                    MessageBox.Show("It's not possible to delete contract who has lines!", "Warning", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete the selected contract?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int indeksOznacenog = dgvUgovori.SelectedCells[0].RowIndex;

                        DataGridViewRow oznaceniRed = dgvUgovori.Rows[indeksOznacenog];

                        int ID = int.Parse(oznaceniRed.Cells["IDUgovora"].Value.ToString());

                        uspjeh = Upiti.ObrisiUgovor(ID);
                        if (uspjeh)
                        {
                            OsvjeziPrikaz();
                            OsvjeziStavke(ID_ugovora);
                        }  
                    }
                }
            } 

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            uredjivanjeUgovora = true;
            SakrijGlavneButtone();
            if (dgvUgovori.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvUgovori.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvUgovori.Rows[indeksOznacenog];

                ID_ugovora = int.Parse(oznaceniRed.Cells["IDUgovora"].Value.ToString());
                cmbPoslodavac.SelectedValue = int.Parse(oznaceniRed.Cells["IDPoslodavca"].Value.ToString());
                cmbPosao.SelectedValue = int.Parse(oznaceniRed.Cells["IDPosla"].Value.ToString());
                cmbStudent.SelectedValue = int.Parse(oznaceniRed.Cells["IDStudenta"].Value.ToString());
                NpgsqlRange<DateTime> trajanje = NpgsqlRange<DateTime>.Parse(oznaceniRed.Cells["Trajanje"].Value.ToString());
                dtpOd.Value = trajanje.LowerBound;
                dtpDo.Value = trajanje.UpperBound;
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            Ugovor ugovor = new Ugovor();

            ugovor.ID_poslodavca = int.Parse(cmbPoslodavac.SelectedValue.ToString());
            ugovor.ID_posla = int.Parse(cmbPosao.SelectedValue.ToString());
            ugovor.ID_studenta = int.Parse(cmbStudent.SelectedValue.ToString());
            ugovor.Trajanje = new NpgsqlRange<DateTime>(dtpOd.Value, dtpDo.Value);

            if (uredjivanjeUgovora)
            {
                ugovor.ID_ugovora = ID_ugovora;
                uspjeh = Upiti.UrediUgovor(ugovor);
            }
            else uspjeh = Upiti.UnesiUgovor(ugovor);

            if (uspjeh)
            {
                OsvjeziPrikaz();
                PrikaziGlavneButtone();
                ObrisiGlavnaPolja();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            PrikaziGlavneButtone();
            ObrisiGlavnaPolja();
        }

        private void SakrijGlavneButtone()
        {
            btnObrisi.Hide();
            btnUnesi.Hide();
            btnUredi.Hide();
            btnSpremi.Show();
            btnOdustani.Show();
            cmbPosao.Enabled = true;
            cmbPoslodavac.Enabled = true;
            cmbStudent.Enabled = true;
            dtpOd.Enabled = true;
            dtpDo.Enabled = true;
        }

        private void PrikaziGlavneButtone()
        {
            btnObrisi.Show();
            btnUnesi.Show();
            btnUredi.Show();           
            btnSpremi.Hide();
            btnOdustani.Hide();
            cmbPosao.Enabled = false;
            cmbPoslodavac.Enabled = false;
            cmbStudent.Enabled = false;
            dtpOd.Enabled = false;
            dtpDo.Enabled = false;
        }

        private void SakrijGlavneButtoneStavke()
        {
            btnObrisiStavku.Hide();
            btnUnesiStavku.Hide();
            btnUrediStavku.Hide();
            btnSpremiStavku.Show();
            btnOdustaniStavka.Show();
            cmbVrstaRada.Enabled = true;
            txtBrojSati.Enabled = true;
            txtCijena.Enabled = true;            
        }

        private void PrikaziGlavneButtoneStavke()
        {
            btnObrisiStavku.Show();
            btnUnesiStavku.Show();
            btnUrediStavku.Show();
            btnSpremiStavku.Hide();
            btnOdustaniStavka.Hide();
            cmbVrstaRada.Enabled = false;
            txtBrojSati.Enabled = false;
            txtCijena.Enabled = false;
            txtUkupno.Enabled = false;

        }

        private void ObrisiGlavnaPolja()
        {
            cmbPosao.ResetText();
            cmbPoslodavac.ResetText();
            cmbStudent.ResetText();

        }

        private void ObrisiPoljaStavki()
        {
            cmbVrstaRada.ResetText();
            txtBrojSati.Clear();
            txtCijena.Clear();
            txtUkupno.Clear();
        }

        private void OsvjeziUkupnuCijenu()
        {
            int sati;
            if (!int.TryParse(txtBrojSati.Text, out sati)) sati = 1;
            double cijena;
            if (!double.TryParse(txtCijena.Text, out  cijena)) cijena = 23.44;
            txtUkupno.Text = (sati * cijena).ToString();
        }

        private void dgvUgovori_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUgovori.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvUgovori.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvUgovori.Rows[indeksOznacenog];
                ID_ugovora = int.Parse(oznaceniRed.Cells["IDUgovora"].Value.ToString());
                satnica = double.Parse(oznaceniRed.Cells["SatnicaUgovor"].Value.ToString());
                cmbPoslodavac.SelectedValue = int.Parse(oznaceniRed.Cells["IDPoslodavca"].Value.ToString());
                cmbPosao.SelectedValue = int.Parse(oznaceniRed.Cells["IDPosla"].Value.ToString());
                cmbStudent.SelectedValue = int.Parse(oznaceniRed.Cells["IDStudenta"].Value.ToString());
                NpgsqlRange<DateTime> trajanje = NpgsqlRange<DateTime>.Parse(oznaceniRed.Cells["Trajanje"].Value.ToString());
                dtpOd.Value = trajanje.LowerBound;
                dtpDo.Value = trajanje.UpperBound;

                txtZaIsplatiti.Text = Upiti.DohvatiIznosZaIsplatiti(ID_ugovora);
                OsvjeziStavke(ID_ugovora);
            }
        }

        private void dgvStavkeUgovora_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStavkeUgovora.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvStavkeUgovora.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvStavkeUgovora.Rows[indeksOznacenog];
                ID_ugovora = int.Parse(oznaceniRed.Cells["IDUgovoraStavke"].Value.ToString());
                ID_stavke = int.Parse(oznaceniRed.Cells["IDStavke"].Value.ToString());
                cmbVrstaRada.Text = oznaceniRed.Cells["VrstaRada"].Value.ToString();
                txtBrojSati.Text = oznaceniRed.Cells["BrojSati"].Value.ToString();
                txtCijena.Text = oznaceniRed.Cells["Cijena"].Value.ToString();
                txtUkupno.Text = oznaceniRed.Cells["Ukupno"].Value.ToString();
            }
        }

        private void dtpOd_MouseHover(object sender, EventArgs e)
        {
            DateTimePicker tb = (DateTimePicker)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Početak", tb, 0, 20, 1000);
        }

        private void dtpDo_MouseHover(object sender, EventArgs e)
        {
            DateTimePicker tb = (DateTimePicker)sender;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Završetak", tb, 0, 20, 1000);
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpOd.Value < minDatum) dtpDo.MinDate = dtpOd.Value;
            minDatum = dtpOd.Value;

            int zadnjiDan = DateTime.DaysInMonth(int.Parse(minDatum.Year.ToString()), int.Parse(minDatum.Month.ToString()));
            dtpDo.MaxDate = new DateTime(minDatum.Year, minDatum.Month, zadnjiDan);
            
            if (dtpDo.Value < dtpOd.Value) dtpDo.Value = dtpOd.Value;
            dtpDo.MinDate = minDatum;
            
        }

        private void btnUnesiStavku_Click(object sender, EventArgs e)
        {
            ProvjeriVrstuRada();
            SakrijGlavneButtoneStavke();
            uredjivanjeStavke = false;
            ObrisiPoljaStavki();
            txtCijena.Text = satnica.ToString();
            
        }

        private void btnUrediStavku_Click(object sender, EventArgs e)
        {
            ProvjeriVrstuRada();
            uredjivanjeStavke = true;
            SakrijGlavneButtoneStavke();
            if (dgvStavkeUgovora.SelectedCells.Count > 0)
            {
                int indeksOznacenog = dgvStavkeUgovora.SelectedCells[0].RowIndex;

                DataGridViewRow oznaceniRed = dgvStavkeUgovora.Rows[indeksOznacenog];

                ID_ugovora = int.Parse(oznaceniRed.Cells["IDUgovoraStavke"].Value.ToString());
                cmbVrstaRada.SelectedItem = oznaceniRed.Cells["VrstaRada"].Value.ToString();
                txtBrojSati.Text = oznaceniRed.Cells["BrojSati"].Value.ToString();
                txtCijena.Text = oznaceniRed.Cells["Cijena"].Value.ToString();
                txtUkupno.Text = oznaceniRed.Cells["Ukupno"].Value.ToString();
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            if (dgvStavkeUgovora.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Da li želite obrisati označenu stavku?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int indeksOznacenog = dgvStavkeUgovora.SelectedCells[0].RowIndex;

                    DataGridViewRow oznaceniRed = dgvStavkeUgovora.Rows[indeksOznacenog];

                    int ID = int.Parse(oznaceniRed.Cells["IDStavke"].Value.ToString());

                    uspjeh = Upiti.ObrisiStavkuUgovora(ID);

                    if (uspjeh)
                    {
                        OsvjeziPrikaz();
                        OsvjeziStavke(ID_ugovora);
                    }
                }
            }
            
        }

        private void btnSpremiStavku_Click(object sender, EventArgs e)
        {
            bool uspjeh = false;
            StavkaUgovora stavka = new StavkaUgovora();

            stavka.ID_ugovora = ID_ugovora;
            stavka.VrstaRada = cmbVrstaRada.SelectedItem.ToString();
            stavka.BrojSati = int.Parse(txtBrojSati.Text);
            stavka.Cijena = double.Parse(txtCijena.Text);
            stavka.Ukupno = double.Parse(txtUkupno.Text);
            txtUkupno.Text = stavka.Ukupno.ToString();

            if (!uredjivanjeStavke)
            {
                uspjeh = Upiti.UnesiStavkuUgovora(stavka);
            }
            else
            {
                stavka.ID_stavke = ID_stavke;
                uspjeh = Upiti.UrediStavkuUgovora(stavka);
            }

            if (uspjeh)
            {
                ObrisiPoljaStavki();
                PrikaziGlavneButtoneStavke();
                OsvjeziStavke(ID_ugovora);
                txtZaIsplatiti.Text = Upiti.DohvatiIznosZaIsplatiti(ID_ugovora);
            }  
        }

        private void btnOdustaniStavka_Click(object sender, EventArgs e)
        {
            PrikaziGlavneButtoneStavke();
            //ObrisiSve();
        }

        private void txtBrojSati_TextChanged(object sender, EventArgs e)
        {
            OsvjeziUkupnuCijenu();
        }

        private void txtCijena_TextChanged(object sender, EventArgs e)
        {
            OsvjeziUkupnuCijenu();
        }

        private void cmbVrstaRada_TextChanged(object sender, EventArgs e)
        {
            ProvjeriVrstuRada();
        }

        private void ProvjeriVrstuRada()
        {
            if (cmbVrstaRada.Text.Equals("Druge naknade"))
            {
                txtCijena.Enabled = true;
                txtCijena.Text = satnica.ToString();
            }
            else {
                if (cmbVrstaRada.Text.Equals("Redoviti rad")) txtCijena.Text = satnica.ToString();
                else txtCijena.Text = (satnica * 1.5).ToString();
                txtCijena.Enabled = false;
            }
        }
    }
}
