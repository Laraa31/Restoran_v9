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
    public partial class AlkoholnaPica : Form
    {
        Pocetna pocetna;

        public AlkoholnaPica(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
        }

        private void zuja33_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Ožujsko 0.33L", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void gemist_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Gemišt", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void zuja5_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Ožujsko 0.5L", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void lasko33_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Laško 0.33L", "1", "2.10" };

            pocetna.AddRowToDataGridView(row);
        }

        private void lasko5_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Laško 0.5L", "1", "2.60" };

            pocetna.AddRowToDataGridView(row);
        }

        private void staropramen33_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Staropramen 0.33L", "1", "2.10" };

            pocetna.AddRowToDataGridView(row);
        }

        private void staropramen5_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Staropramen 0.5L", "1", "2.60" };

            pocetna.AddRowToDataGridView(row);
        }

        private void stella_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Stella", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void beks_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Beks", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bambus_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bambus", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void radler_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Radler", "1", "2.70" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cVino_01_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Crno vino 0.1L", "1", "1.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bVino_01_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bijelo vino 0.1", "1", "1.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bVino1_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bijelo vino 1L", "1", "10.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cVino1_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Crno vino 1L", "1", "10.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bezPivo_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bezalkoholno pivo", "1", "2.70" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
