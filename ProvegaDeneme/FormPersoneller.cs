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
    public partial class FormPersoneller : Form
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public void PersonelleriYukle()
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Personel";
            komut.Connection = baglan;
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = komut;
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSet;
                dataGridViewPersonel.DataSource = bindingSource;
                dataAdapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

      

        private void btnPerSil_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand();

            if (MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM Personel WHERE PersonelID=@PersonelID";
                komut.Parameters.AddWithValue("@PersonelID", dataGridViewPersonel.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silme işlemi başarılı", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Open();
                PersonelleriYukle();
                
            }
        }

        private void FormPersoneller_Load(object sender, EventArgs e)
        {
            PersonelleriYukle();
        }

        private void btnPerEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Personel(PersonelAdi, PersonelSoyadi, PersonelTC, PersonelSicilNo, PersonelAlan, PersonelMaas) values (@PersonelAdi, @PersonelSoyadi, @PersonelTC, @PersonelSicilNo, @PersonelAlan, @PersonelMaas)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@PersonelAdi", txtPerAdEkle.Text);
                komut.Parameters.AddWithValue("@PersonelSoyadi", txtPerSoyadEkle.Text);
                komut.Parameters.AddWithValue("@PersonelTC", txtPerTcEkle.Text);
                komut.Parameters.AddWithValue("@PersonelSicilNo", txtPerSicilNoekle.Text);
                komut.Parameters.AddWithValue("@PersonelAlan", txtPerAlanEkle.Text);
                komut.Parameters.AddWithValue("@PersonelMaas", txtPerMaasEkle.Text);
                baglan.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Personel Eklendi.");
                baglan.Close();
                



               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            PersonelleriYukle();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
