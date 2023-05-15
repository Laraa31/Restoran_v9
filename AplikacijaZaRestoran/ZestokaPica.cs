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
    public partial class ZestokaPica : Form
    {
        Pocetna pocetna;
        public ZestokaPica(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna=  poc;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Travarica", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void lozovaca_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Biska", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void aperol_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Aperol", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void visnjLiker_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Liker od višnje", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cokLiker_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Čokoladni liker", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void tequila_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Travarica", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bRum_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bijeli rum", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void rum_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Rum", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void limunLiker_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Liker od limuna", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void amaro_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Amaro", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void grappa_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Grappa", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sljivovica_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Šljivovica", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void viski_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Viski", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void gin_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Gin", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void pelinkovac_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Pelinkovac", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void votka_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Votka", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
