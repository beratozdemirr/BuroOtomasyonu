using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProvegaDeneme
{
    public partial class FormToplatilar : Form
    {
        public FormToplatilar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public void ToplantilariYukle()
        {

            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Toplanti";
            komut.Connection = baglan;
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = komut;
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSet;
                dataGridViewToplantilar.DataSource = bindingSource;
                dataAdapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FormToplatilar_Load(object sender, EventArgs e)
        {
            ToplantilariYukle();

        }

        private void btnTopEkle_Click(object sender, EventArgs e)
        {
            try
            {
                /*MÜŞTERİLERDE Kİ HATA İLE AYNI HATAYI VERİYOR.*/

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Toplanti(ToplantıKisi, ToplantiYeri, ToplantiZamani) values (@ToplantıKisi, @ToplantiYeri, @ToplantiZamani)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@ToplantıKisi", txtTopYapilacakKisiEkle.Text);
                komut.Parameters.AddWithValue("@ToplantiYeri", txtTopYeriEkle.Text);
                komut.Parameters.AddWithValue("@ToplantiZamani",dateTimeTopZamani.Value);
                
                baglan.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Toplanti Eklendi.");
                baglan.Close();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            ToplantilariYukle();
        }

        private void btnTopSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM Toplanti WHERE ToplantiID=@ToplantiID";
                komut.Parameters.AddWithValue("@ToplantiID", dataGridViewToplantilar.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silme işlemi başarılı", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Open();
                ToplantilariYukle();

            }
        }
    }
}
