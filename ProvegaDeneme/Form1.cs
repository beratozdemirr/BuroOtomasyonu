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
    public partial class FormGiris : Form
    {

        FormAnaEkran frm = new FormAnaEkran();

        public FormGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
          
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT* FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND KullaniciSifre = @KullaniciSifre";
            komut.Parameters.AddWithValue("@KullaniciAdi", txtKullanici.Text);
            komut.Parameters.AddWithValue("@KullaniciSifre", txtSifre.Text);
            
            komut.Connection = baglan;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);

            if (dt.Rows.Count !=0)
            {
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("kullanici adı yada sifre hatalı.");
            }
        }
    }
}
