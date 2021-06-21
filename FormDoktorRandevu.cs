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
    public partial class FormDoktorRandevu : Form
    {
        public FormDoktorRandevu()
        {
            InitializeComponent();
        }
        SqlCommand komut;
        private void FormDoktorRandevu_Load(object sender, EventArgs e)
        {
            randevugetir();
            getir();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

        private void randevugetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Randevular", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["Randevuid"].ToString());
            }
            baglanti.Close();
        }
        private void getir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Hastalar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox2.Items.Add(read["HastaTC"].ToString());
            }
            baglanti.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //7-15
         

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorrandevu (HastaTC,Randevuid, Doktorteshis,Doktorrecete, Tahlil) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d3", richTextBox1.Text);
            komut.Parameters.AddWithValue("@d4", richTextBox2.Text);
            komut.Parameters.AddWithValue("@d2", comboBox1.Text);
            komut.Parameters.AddWithValue("@d1", comboBox2.Text);
            komut.Parameters.AddWithValue("@d5", richTextBox3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();


            MessageBox.Show("Kaydetme başarıyla gerçekleşti!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
