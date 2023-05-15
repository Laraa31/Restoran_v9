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
    public partial class Kava : Form
    {
        Pocetna pocetna;
        public Kava(Pocetna poc)
        {
            InitializeComponent();
            this.pocetna = poc;
        }

        

        private void vMacchiato_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Veliki macchiato", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void Kava_Load(object sender, EventArgs e)
        {

        }

        private void mMacchiato_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Mali macchiato", "1", "1.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cafelatte_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Caffe Latte", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bezKofeina_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bezkofeina", "1", "0.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void Americano_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Americano", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void bijelaKava_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Bijela kava", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void cappuccino_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Cappuccino", "1", "2.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void espresso_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Espresso", "1", "1.00" };

            pocetna.AddRowToDataGridView(row);
        }

        private void latteMacchiato_Click(object sender, EventArgs e)
        {
            object[] row = new object[] { "Latte Macchiato", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }

        private void ness_Click(object sender, EventArgs e)
        {
            
            object[] row = new object[] { "Nescafé", "1", "2.50" };

            pocetna.AddRowToDataGridView(row);
        }
    }
}
