using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FormEczaneHastaEkle : Form
    {
        public FormEczaneHastaEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");


        private void FormEczaneHastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnhastaekleekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_EczaHasta(Hastaadsoyad, HastaTc, HastaTelefon) values(@adsoyad, @tc, @telefon) ", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txthastaekleadsoyad.Text);
            komut.Parameters.AddWithValue("@tc", mskedhastaekletc.Text);
            komut.Parameters.AddWithValue("@telefon", mskedhastaekletel.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri kaydı oluşturuldu.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = ""; 
                }
            }


        }
    }
}
