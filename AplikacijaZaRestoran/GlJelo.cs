using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaZaRestoran
{
    public partial class GlJelo : Form
    {

        Pocetna pocetna;
        public GlJelo(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Ražnjići", "1", "8.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void tunaUmak_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Njoki Alfredo", "1", "8.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cevULep_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Čevapi u lepinji", "1", "8.0" };

            pocetna.AddRowToDataGridView(row);
        }

        private void kruh_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Kruh", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void pecKrumpiri_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pečeni krumpir", "1", "3.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void pomfri_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pomfri", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void PohSir_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pohani sir", "1", "7.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void beckiOdrezak_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bečki odrezak", "1", "8.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void zarLignje_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Lignje na žaru", "1", "10.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void przLignje_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pržene lignje", "1", "10.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void crRižoto_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Crni rižoto", "1", "12.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void gulas_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Gulaš", "1", "10.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bolonjez_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Špagete bolonjez", "1", "8.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mesPlata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mesna plata", "1", "20.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mjMeso_Click(object sender, EventArgs e)
        {
            object[] row = new object[] {"Miješano meso", "1", "8.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void kruhBezGl_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Kruh bez glutena", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
