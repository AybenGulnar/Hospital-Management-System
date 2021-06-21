using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FormYonlendirme : Form
    {
        public FormYonlendirme()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FormYonlendirme_Load(object sender, EventArgs e)
        {
            Doktorgetir();
            Yenidoktorgetir();
            rendevuid();
        }
        private void Doktorgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Doktorlar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbydoktor.Items.Add(read["DoktorTC"].ToString());
                
            }
            baglanti.Close();
        }
        private void rendevuid()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Randevular", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbyrandevu.Items.Add(read["Randevuid"].ToString());
          
            }
            baglanti.Close();
        }


        private void Yenidoktorgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Branslar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbyyenidoktor.Items.Add(read["BransAd"].ToString());
            }
            baglanti.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnyonlendir_Click(object sender, EventArgs e)
        {
            
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Yonlendirme(doktortc,randevuid,YonlendirilenBrans,tarih) values(@doktortc,@randevuid,@YonlendirilenBrans,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@doktortc", cmbydoktor.Text);
                komut.Parameters.AddWithValue("@randevuid", cmbyrandevu.Text);
                komut.Parameters.AddWithValue("@YonlendirilenBrans", cmbyyenidoktor.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Hasta Yönlendirme Başarılı ");

        }
    }
}
