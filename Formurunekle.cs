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
    public partial class Formurunekle : Form
    {
        public Formurunekle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        bool durum;
        //aynı kaydı engeller.
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkod.Text == read["Barkodno"].ToString() ||txtbarkod.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Urun set miktar=miktar+'"+int.Parse(miktartxt.Text)+"' where barkodno= '"+barkodtxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
              
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı.");
        }

        private void Formurunekle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarkaa.Items.Clear();
            combomarkaa.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Markalar where kategori='" + comboBox1.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarkaa.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void Combomarkaa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonyeniekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("insert into Tbl_Urun(barkodno,kategori,marka,urunadi,miktar,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktar,@alisfiyati,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("barkodno", txtbarkod.Text);
                komut.Parameters.AddWithValue("kategori", comboBox1.Text);
                komut.Parameters.AddWithValue("marka", combomarkaa.Text);
                komut.Parameters.AddWithValue("urunadi", txturunadii.Text);
                komut.Parameters.AddWithValue("miktar", int.Parse(txtMiktar.Text));
                komut.Parameters.AddWithValue("alisfiyati", double.Parse(Txtalisfiyat.Text));
                komut.Parameters.AddWithValue("satisfiyati", double.Parse(txtsatisfiyat.Text));
                komut.Parameters.AddWithValue("tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("UYARI! Bu barkod no mevcut");
            }
            MessageBox.Show("Ürün eklendi");
            combomarkaa.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodtxt.Text == "")

            {
                lblMiktari.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Urun where barkodno like '" + barkodtxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["kategori"].ToString();
                markatxt.Text = read["marka"].ToString();
                urunaditxt.Text = read["urunadi"].ToString();
                lblMiktari.Text = read["miktar"].ToString();
                urunalistxt.Text = read["alisfiyati"].ToString();
                urunsatisfiyatxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();

        }
    }
}
