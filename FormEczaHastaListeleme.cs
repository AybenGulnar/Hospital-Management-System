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
    public partial class FormEczaHastaListeleme : Form
    {
        public FormEczaHastaListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();

        private void FormEczaHastaListeleme_Load(object sender, EventArgs e)
        {
            Kayit_Goster();
        }

        private void Kayit_Goster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_EczaHasta", baglanti);
            adtr.Fill(daset, "Tbl_EczaHasta");
            dataGridView1.DataSource = daset.Tables["Tbl_EczaHasta"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mskedhastaekletc.Text = dataGridView1.CurrentRow.Cells["HastaTc"].Value.ToString();
            txthastaekleadsoyad.Text = dataGridView1.CurrentRow.Cells["Hastaadsoyad"].Value.ToString();
            mskedhastaekletel.Text = dataGridView1.CurrentRow.Cells["HastaTelefon"].Value.ToString();
        }

        private void btnhastaguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Tbl_EczaHasta set Hastaadsoyad=@adsoyad, HastaTc=@tc, HastaTelefon=@telefon where HastaTc=@tc", baglanti);
            komut.Parameters.AddWithValue("@adsoyad", txthastaekleadsoyad.Text);
            komut.Parameters.AddWithValue("@tc", mskedhastaekletc.Text);
            komut.Parameters.AddWithValue("@telefon", mskedhastaekletel.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_EczaHasta"].Clear();
            Kayit_Goster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_EczaHasta where HastaTc='"+dataGridView1.CurrentRow.Cells["HastaTc"].Value.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["Tbl_EczaHasta"].Clear();
            Kayit_Goster();
            _ = MessageBox.Show("Kayıt silindi.");
        }

        private void textBoxtcara_TextChanged(object sender, EventArgs e)
        {

            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_EczaHasta where HastaTc like '%"+textBoxtcara.Text+"'",baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }
    }
}
