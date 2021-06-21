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
    public partial class FormEczadepogiris : Form
    {
        public FormEczadepogiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Sepet", baglanti);
            adtr.Fill(daset, "Tbl_Sepet");
            dataGridView1.DataSource = daset.Tables["Tbl_Sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormEczaneHastaEkle ekle = new FormEczaneHastaEkle();
            _ = ekle.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            FormEczaHastaListeleme listele = new FormEczaHastaListeleme();
            _ = listele.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Formurunekle eklee = new Formurunekle();
            _ = eklee.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormUrunListeleme listele = new FormUrunListeleme();
            _ = listele.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            FormKategori kategori = new FormKategori();
            _ = kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMarka marka = new FormMarka();
            _ = marka.ShowDialog();
        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyat) from Tbl_Sepet",baglanti);
                LblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FormEczadepogiris_Load(object sender, EventArgs e)
        {
            sepetlistele();

        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Sepet",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtbarkodno.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Sepet(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txthastatc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txthastaadsoyadd.Text);
                komut.Parameters.AddWithValue("@telefon", maskestelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtbarkodno.Text);
                komut.Parameters.AddWithValue("@urunadi", txturunadi.Text);
                komut.Parameters.AddWithValue("@miktar", int.Parse(txturunmiktar.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatısfiyat.Text));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(txttoplamfiayt.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else 
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update Tbl_Sepet set miktar=miktar+'"+int.Parse(txturunmiktar.Text)+ "'where barkodno='" + txtbarkodno.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update Tbl_Sepet set toplamfiyat=miktar*satisfiyati where barkodno='"+txtbarkodno.Text+"'", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
            }
           
            txturunmiktar.Text = "1";
            daset.Tables["Tbl_Sepet"].Clear();
            sepetlistele();
            hesapla(); 
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txturunmiktar)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txthastatc_TextChanged(object sender, EventArgs e)
        {
            if (txthastatc.Text == "")
            {
                txthastaadsoyadd.Text = "";
                maskestelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_EczaHasta where HastaTc like '"+txthastatc.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txthastaadsoyadd.Text = read["Hastaadsoyad"].ToString();
                maskestelefon.Text = read["HastaTelefon"].ToString();

            }
            baglanti.Close();
        }

        private void txtbarkodno_TextChanged(object sender, EventArgs e)
        {
            Temizle();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Urun where barkodno like '" + txtbarkodno.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txturunadi.Text = read["urunadi"].ToString();
                txtsatısfiyat.Text = read["satisfiyati"].ToString();

            }
            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtbarkodno.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txturunmiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        private void txturunmiktar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiayt.Text = (double.Parse(txturunmiktar.Text) * double.Parse(txtsatısfiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtsatısfiyat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txttoplamfiayt.Text = (double.Parse(txturunmiktar.Text) * double.Parse(txtsatısfiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnsepetcikar_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
       
            MessageBox.Show("Ürün sepetten çıkarıldı");
            daset.Tables["Tbl_Sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnsatisiptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Satış iptal edildi.");
            daset.Tables["Tbl_Sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSatisListele listelee = new FormSatisListele();
            _ = listelee.ShowDialog();
        }

        private void btnsatısyap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Satis(tc,adsoyad,telefon,barkodno,urunadi,miktar,satisfiyati,toplamfiyat,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktar,@satisfiyati,@toplamfiyat,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txthastatc.Text);
                komut.Parameters.AddWithValue("@adsoyad", txthastaadsoyadd.Text);
                komut.Parameters.AddWithValue("@telefon", maskestelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktar", int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyat", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyat"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update Tbl_Urun set miktar=miktar-'" + int.Parse(dataGridView1.Rows[i].Cells["miktar"].Value.ToString()) + "' where barkodno= '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut2.ExecuteNonQuery();
                baglanti.Close();
               
             
            }

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from Tbl_Sepet ", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış başarılıyla gerçekleşti. Satış listesini kontrol ediniz.");
            daset.Tables["Tbl_Sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 listelee = new Form1();
            _ = listelee.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
