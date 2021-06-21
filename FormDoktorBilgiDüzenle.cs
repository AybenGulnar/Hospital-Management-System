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
    public partial class FormDoktorBilgiDüzenle : Form
    {
        public FormDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string TCNO;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txthastaad.Text);
            komut.Parameters.AddWithValue("@p2", txthastasoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi");
        }

        private void FormDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txthastaad.Text = dr[1].ToString();
                txthastasoyad.Text = dr[2].ToString();
                cmbbranş.Text = dr[3].ToString();
                txtsifre.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
