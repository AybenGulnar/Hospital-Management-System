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
    public partial class FormUrunListeleme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Kategori", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxkategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        public FormUrunListeleme()
        {
            InitializeComponent();
        }

        private void FormUrunListeleme_Load(object sender, EventArgs e)
        {
            Urunlistele();
            kategorigetir();
        }

        private void Urunlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Urun", baglanti);
            adtr.Fill(daset, "Tbl_Urun");
            dataGridView1.DataSource = daset.Tables["Tbl_Urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodtxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunaditxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            miktartxt.Text = dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            urunalistxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            urunsatisfiyatxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();



        }

        private void btngüncelleurun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Urun set urunadi=@urunadi, miktar=@miktar, alisfiyati=@alisfiyati, satisfiyati=@satisfiyati where barkodno=@barkodno",baglanti);
            komut.Parameters.AddWithValue("@barkodno",barkodtxt.Text);
            komut.Parameters.AddWithValue("@urunadi", urunaditxt.Text);
            komut.Parameters.AddWithValue("@miktar", int.Parse(miktartxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati", double.Parse(urunalistxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(urunsatisfiyatxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_Urun"].Clear();
            Urunlistele();
            MessageBox.Show("Güncelleme başarılı :)");
            foreach ( Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnkategoriguncelle_Click(object sender, EventArgs e)
        {
            if (barkodtxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Urun set kategori=@kategori, marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodtxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboBoxkategori.Text);
                komut.Parameters.AddWithValue("@marka", comboBoxmarka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme başarılı");
                daset.Tables["Tbl_Urun"].Clear();
                Urunlistele();
              
            }
            else
            {
                MessageBox.Show("Barkod No yazılı değil!!");
            }

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }

        }

        private void comboBoxkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxmarka.Items.Clear();
            comboBoxmarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Markalar where kategori='" + comboBoxkategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBoxmarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnsilurun_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_Urun"].Clear();
            Urunlistele();
            _ = MessageBox.Show("Kayıt silindi.");
        }

        private void txtbarkodnoarama_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Urun where barkodno like '%" + txtbarkodnoarama.Text + "'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
