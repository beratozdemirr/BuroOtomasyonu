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
    public partial class FormOdemeler : Form
    {
        public FormOdemeler()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        public void OdemeleriYukle()
        {

           
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select * from Odemeler";
            komut.Connection = baglan;
            try
            {

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = komut;
                DataTable dataSet = new DataTable();
                dataAdapter.Fill(dataSet);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataSet;
                dataGridViewOdemeler.DataSource = bindingSource;
                dataAdapter.Update(dataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

      
        private void FormOdemeler_Load(object sender, EventArgs e)
        {
            OdemeleriYukle();
        }

        private void btnOdeEkle_Click(object sender, EventArgs e)
        {
            try
            {
                /*AYNI KARAKTER STRİNG HATASI*/

                SqlCommand komut = new SqlCommand();
                komut.CommandText = "insert into Odemeler(OdemeYeri, OdemeTutari, OdemeSonTar) values (@OdemeYeri, @OdemeTutari, @OdemeSonTar)";
                komut.Connection = baglan;
                komut.Parameters.AddWithValue("@OdemeYeri", txtOdemeYeriEkle.Text);
                komut.Parameters.AddWithValue("@OdemeTutari", txtOdemeTutariEkle.Text);
                komut.Parameters.AddWithValue("@OdemeSonTar", dateTimeOdeme.Value);
               
                baglan.Open();
                komut.ExecuteNonQuery();
                MessageBox.Show("Odeme Eklendi.");
                baglan.Close();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            OdemeleriYukle();

        }

        private void btnOdeSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();

            if (MessageBox.Show("Seçili öğeyi silmek istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM Odemeler WHERE OdemeID=@OdemeID";
                komut.Parameters.AddWithValue("@OdemeID", dataGridViewOdemeler.CurrentRow.Cells[0].Value.ToString());
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silme işlemi başarılı", "silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglan.Open();
                OdemeleriYukle();

            }
        }
    }
}

