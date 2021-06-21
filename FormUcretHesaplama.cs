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
    public partial class FormUcretHesaplama : Form
    {
        DataSet daset = new DataSet();
        public FormUcretHesaplama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormUcretHesaplama_Load(object sender, EventArgs e)
        {
            hastatcgetir();
            tahlil();
            muayene();
            satislistele();


        }

    

        private void hastatcgetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Tbl_Hastalar", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                Hastaadsoyadcmbx.Items.Add(read["HastaTC"].ToString());
            }
            baglanti.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Doktoradsoyadcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Hastaadsoyadcmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
       
        
       
        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        private void tahlil()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Tahliller", baglanti);
            adtr.Fill(daset, "Tbl_Tahliller");
            dataGridView1.DataSource = daset.Tables["Tbl_Tahliller"];
            baglanti.Close();
        }
        private void muayene()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_MuayeneUcret", baglanti);
            adtr.Fill(daset, "Tbl_MuayeneUcret");
            dataGridView2.DataSource = daset.Tables["Tbl_MuayeneUcret"];
            baglanti.Close();
        }
        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Ucret", baglanti);
            adtr.Fill(daset, "Tbl_Ucret");
            dataGridView3.DataSource = daset.Tables["Tbl_Ucret"];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Ucret(HastaTC,Toplamucret,tarih) values(@HastaTC,@Toplamucret,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@HastaTC", Hastaadsoyadcmbx.Text);
            komut.Parameters.AddWithValue("@Toplamucret", textBox1.Text);
            komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
           
            baglanti.Close();
            satislistele();
          
        }
    

        private void label4_Click_2(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          
                int s1, s2,s3;
                s1 = Convert.ToInt32(textBox2.Text);
                s2 = Convert.ToInt32(textBox3.Text);
                s3 = Convert.ToInt32(textBox4.Text);
                int toplam = s1 + s2 + s3;
                textBox1.Text = toplam + "TL";
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox3.Text = dataGridView2.CurrentRow.Cells["DoktorUcret"].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.CurrentRow.Cells["TahlilUcret"].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRandevuDetayy fr = new FormRandevuDetayy();
            fr.Show();

        }
    }
}
        

