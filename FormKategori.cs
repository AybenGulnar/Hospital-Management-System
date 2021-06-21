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
    public partial class FormKategori : Form
    {
        public FormKategori()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

        bool durum;
        //aynı kaydı engeller.
        private void kategoriengelle()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBox1.Text == read["kategori"].ToString() ||textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void FormKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kategoriengelle();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Kategori(kategori) values('" + textBox1.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            
                MessageBox.Show("Kategori eklendi");
            }
            else
            {
                MessageBox.Show("UYARI! BU KATEGORİ MEVCUT!");
            }
            textBox1.Text = "";
        }
    }
}
