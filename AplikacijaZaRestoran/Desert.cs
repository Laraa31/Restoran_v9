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
    public partial class Desert : Form
    {
        Pocetna pocetna;
        public Desert(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sladoled", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cheesecake_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Cheesecake", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void tiramisu_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Tiramisu", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sacher_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sacher torta", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void čokTorta_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Čokoladna torta", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void vocTorta_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Voćna torta", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void krempite_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Krempita", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mousse_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mousse", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void pitaJab_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pita od jabuke", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void madarica_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mađarica", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void strudlaJab_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Štrudla od jabuke", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sufle_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sufle", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void baklava_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Baklava", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Palačinke", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void vafli_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Vafli", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void voćSalata_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Voćna salata", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
