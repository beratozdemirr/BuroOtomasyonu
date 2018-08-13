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
    public partial class FormGorevler : Form
    {
        public FormGorevler()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public void GorevleriYukle() {

           
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Gorevler";
            komut.Connection = baglan;
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = komut;
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);
                
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSet;
                dataGridViewGorevler.DataSource = bindingSource;
                dataAdapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void FormGorevler_Load(object sender, EventArgs e)
        {
            GorevleriYukle();
        }

        private void btnGorEkle_Click(object sender, EventArgs e)
        {

            try
            {
                /* conversion vs vs KARAKTER  STRINGDE HATA VAR DİYO */
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Gorevler(GorevKisi, GorevKonu, GorevSonTar) values (@GorevKisi, @GorevKonu, @GorevSonTar)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@GorevKisi", txtGorKisiEkle.Text);
                komut.Parameters.AddWithValue("@GorevKonu", txtGorKonuEkle.Text);
                komut.Parameters.AddWithValue("@GorevSonTar", dateTimeGorev.Value);
                
                baglan.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Gorev Eklendi.");
                baglan.Close();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            GorevleriYukle();
        }

        private void btnGorSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM Gorevler WHERE GorevID=@GorevID";
                komut.Parameters.AddWithValue("@GorevID", dataGridViewGorevler.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silme işlemi başarılı", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Open();
                GorevleriYukle();

            }
        }
    }
}
