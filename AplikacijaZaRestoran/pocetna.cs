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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
            

        }

        public void AddRowToDataGridView(object[] rowData)
        {
            narudzba.Rows.Add(rowData);
        }

        private void kave_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Kava kava =new Kava(this) { TopLevel = false, TopMost = true };
            kava.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(kava);
            kava.Show();

        }

        private void juha_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Juha juha = new Juha(this) { TopLevel = false, TopMost = true };
            juha.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(juha);
            juha.Show();

        }

        private void bezAlkPica_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            BezalkoholnaPica bezalkoholnaPica =new BezalkoholnaPica(this) { TopLevel = false,TopMost = true };
            bezalkoholnaPica.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(bezalkoholnaPica);
            bezalkoholnaPica.Show();
        }

        private void predjelo_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            ZestokaPica zestokaPica = new ZestokaPica(this) { TopLevel = false, TopMost = true };
            zestokaPica.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(zestokaPica);
            zestokaPica.Show();
        }

        private void alkPica_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            AlkoholnaPica alkoholnaPica = new AlkoholnaPica(this) { TopLevel = false,TopMost = true};
            alkoholnaPica.FormBorderStyle= FormBorderStyle.None;
            panel.Controls.Add(alkoholnaPica);
            alkoholnaPica.Show();
        }

        private void glJelo_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            GlJelo glJelo = new GlJelo(this) { TopLevel = false,TopMost=true};
            glJelo.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(glJelo);
            glJelo.Show();
        }

        private void desert_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Desert desert = new Desert(this) { TopLevel = false, TopMost = true };
            desert.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(desert);
            desert.Show();
        }

        private void salate_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Salata salata = new Salata(this) { TopLevel = false, TopMost = true };
            salata.FormBorderStyle = FormBorderStyle.None;
            panel.Controls.Add(salata);
            salata.Show();
        }

       

        private void stolovi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void izbrisiRac_Click(object sender, EventArgs e)
        {
            narudzba.Rows.Clear();
        }

        private void narudzba_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == narudzba.Columns["izbrisi"].Index &&
       e.RowIndex >= 0)
            {
                narudzba.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
