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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public void MusterileriYukle()
        {

            
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Musteri";
            komut.Connection = baglan;
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = komut;
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSet;
                dataGridViewMusteri.DataSource = bindingSource;
                dataAdapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        
        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            try
            {
                /*MÜŞTERİ ADINI EKLERKEN SORUN YARATIYOR MUST DECLARE THE SCALAR HATASI AVERİYO
                 * ÖYLE Bİ SORUN OLMAMASINA RAĞMEN*/

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Musteri(MusteriAd, MusteriSoyad, MusteriTC, MusteriFirma, MusteriVergiNo) values (@MusteriAd, @MusteriSoyad, @MusteriTC, @MusteriFirma, @MusteriVergiNo)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@MusteriAd", txtMusAdEkle.Text);
                komut.Parameters.AddWithValue("@MusteriSoyad", txtMusSoyadEkle.Text);
                komut.Parameters.AddWithValue("@MusteriTC", txtMusTcEkle.Text);
                komut.Parameters.AddWithValue("@MusteriFirma", txtMusFirmaEkle.Text);
                komut.Parameters.AddWithValue("@MusteriVergiNo", txtMusVergiNoEkle.Text);

                baglan.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Musteri Eklendi.");
                baglan.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            MusterileriYukle();
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
        }

        private void btnMusSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM Musteri WHERE MusteriID=@MusteriID";
                komut.Parameters.AddWithValue("@MusteriID", dataGridViewMusteri.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silme işlemi başarılı", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Open();
                MusterileriYukle();

            }
        }
    }
}
