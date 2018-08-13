using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvegaDeneme
{
    public partial class FormAnaEkran : Form
    {
        FormPersoneller frmPersonel = new FormPersoneller();
        FormMusteriler frmMusteri = new FormMusteriler();
        FormToplatilar frmToplanti = new FormToplatilar();
        FormGorevler frmGorev = new FormGorevler();
        FormOdemeler frmOdeme = new FormOdemeler();


        public FormAnaEkran()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmGorev.Show();
             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmPersonel_Click(object sender, EventArgs e)
        {
            frmPersonel.Show();
          


        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            frmMusteri.Show();
            

        }

        private void btnToplanti_Click(object sender, EventArgs e)
        {
            frmToplanti.Show();

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            frmOdeme.Show();

        }
    }
}
