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
    public partial class Salata : Form
    {
        Pocetna pocetna;
        public Salata(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
        }


       

        private void limun_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Limun", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        

        private void grckaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Grčka salata", "1", "3.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sopskaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Šopska salata", "1", "3.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void meksickaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Meksička salata", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cezarSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Cezar salata", "1", "4.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void francuskaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Francuska salata", "1", "3.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mijesanaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Miješana salata", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void kupusSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Kupus salata", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void zelenaSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Zelena salata", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
