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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void btnPoslodavci_Click(object sender, EventArgs e)
        {
            FrmPoslodavci forma = new FrmPoslodavci();
            forma.ShowDialog();
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            FrmStudenti forma = new FrmStudenti();
            forma.ShowDialog();
        }

        private void btnPoslovi_Click(object sender, EventArgs e)
        {
            FrmPoslovi forma = new FrmPoslovi();
            forma.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            FrmUgovori forma = new FrmUgovori();
            forma.ShowDialog();
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            FrmIzvjestaj forma = new FrmIzvjestaj();
            forma.ShowDialog();
        }
    }
}
