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
    public partial class FrmIzvjestaj : Form
    {
        private string poduvjet;

        public FrmIzvjestaj()
        {
            InitializeComponent();
        }

        private void FrmIzvjestaj_Load(object sender, EventArgs e)
        {
            cmbDodatniFilter.DataSource = PopuniSporedniFilter();
            cmbDodatniFilter.ValueMember = "IDMjeseca";
            cmbDodatniFilter.DisplayMember = "NazivMjeseca";
        }

        private void OsvjeziPrikaz()
        {
            BindingList<Izvjestaj> izvjestaj = Upiti.PrikaziIzvjestaj(cmbGlavniFilter.Text, poduvjet);

            if (izvjestaj.Count == 0) izvjestajBindingSource.DataSource = null;
            else izvjestajBindingSource.DataSource = izvjestaj;
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            switch (cmbGlavniFilter.Text)
            {
                case "Poslodavcu":
                    dgvIzvjestaj.Columns["NazivPoslodavca"].Visible = true;
                    dgvIzvjestaj.Columns["UkupnaCijena"].Visible = true;
                    dgvIzvjestaj.Columns["UkupnoSati"].Visible = false;
                    dgvIzvjestaj.Columns["NazivStudenta"].Visible = false;
                    dgvIzvjestaj.Columns["Mjesec"].Visible = false;
                    break;
                case "Studentu":
                    dgvIzvjestaj.Columns["NazivPoslodavca"].Visible = false;
                    dgvIzvjestaj.Columns["UkupnaCijena"].Visible = true;
                    dgvIzvjestaj.Columns["UkupnoSati"].Visible = true;
                    dgvIzvjestaj.Columns["NazivStudenta"].Visible = true;
                    dgvIzvjestaj.Columns["Mjesec"].Visible = false;
                    break;
                case "Mjesecu":
                    dgvIzvjestaj.Columns["NazivPoslodavca"].Visible = false;
                    dgvIzvjestaj.Columns["UkupnaCijena"].Visible = true;
                    dgvIzvjestaj.Columns["UkupnoSati"].Visible = true;
                    dgvIzvjestaj.Columns["NazivStudenta"].Visible = false;
                    dgvIzvjestaj.Columns["Mjesec"].Visible = true;
                    break;
                default:
                    break;
            }
            if (cmbDodatniFilter.SelectedValue == null) poduvjet = "";
            else poduvjet = "AND " + cmbDodatniFilter.SelectedValue + " = date_part('month', lower(trajanje)) AND " + cmbDodatniFilter.SelectedValue + " = date_part('month', upper(trajanje))";
            
            OsvjeziPrikaz();
        }

        private BindingList<FilterMjeseci> PopuniSporedniFilter()
        {
            BindingList<FilterMjeseci> lista = new BindingList<FilterMjeseci>();

            lista.Add(new FilterMjeseci(null, null));
            lista.Add(new FilterMjeseci("1", "January"));
            lista.Add(new FilterMjeseci("2", "February"));
            lista.Add(new FilterMjeseci("3", "March"));
            lista.Add(new FilterMjeseci("4", "April"));
            lista.Add(new FilterMjeseci("5", "May"));
            lista.Add(new FilterMjeseci("6", "June"));
            lista.Add(new FilterMjeseci("7", "July"));
            lista.Add(new FilterMjeseci("8", "August"));
            lista.Add(new FilterMjeseci("9", "September"));
            lista.Add(new FilterMjeseci("10", "October"));
            lista.Add(new FilterMjeseci("11", "November"));
            lista.Add(new FilterMjeseci("12", "December"));

            return lista;
        }

        private void cmbGlavniFilter_TextChanged(object sender, EventArgs e)
        {
            if (cmbGlavniFilter.Text.Equals("Mjesecu"))
            {
                cmbDodatniFilter.Text = null;
                cmbDodatniFilter.Enabled = false;
            }
            else cmbDodatniFilter.Enabled = true;
        }
    }
}
