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
    public partial class BezalkoholnaPica : Form
    {
        Pocetna pocetna;
        public BezalkoholnaPica(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna= poc;  
        }

        private void cola_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Coca-Cola", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void fanta_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Fanta", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sprite_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sprite", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sokJab_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sok od jabuke", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void colaZ_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Coca-Cola Zero", "1", "2.10" };

            pocetna.AddRowToDataGridView(row);
        }

        private void FantaZ_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Fanta Zero", "1", "2.10" };

            pocetna.AddRowToDataGridView(row);
        }

        private void spriteZ_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sprite Zero", "1", "2.10" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sokNar_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sok od naranče", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void limunada_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Limunada", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void ledeniCaj_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Ledeni čaj", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cedevita_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Cedevita", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void sensation_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Sensation", "1", "1.70" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mVoda25_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mineralna 0.25L", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void mVoda1_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mineralna 1L", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void jana33_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Jana 0.33L", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void jana75_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Jana 0.75L", "1", "3.00" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
