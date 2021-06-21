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
    public partial class FormDuyurular : Form
    {
        public FormDuyurular()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FormDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Duyurular set DuyuruNo = @d1, Duyuru = @d2 where  DuyuruNo = @d1", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyuruno.Text);
            komut.Parameters.AddWithValue("@d2", rchduyuruolustur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyurunuz Başarıyla Guncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnduyuruekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (DuyuruNo, Duyuru) values (@d1,@d2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyuruno.Text);
            komut.Parameters.AddWithValue("@d2", rchduyuruolustur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyurunuz Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Duyurular where DuyuruNo=@p1, Duyuru=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", duyuruno.Text);
            komut.ExecuteNonQuery();
            komut.Parameters.AddWithValue("@d2", rchduyuruolustur.Text);
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            duyuruno.Text = dataGridView1.CurrentRow.Cells["DuyuruNo"].Value.ToString();
            rchduyuruolustur.Text = dataGridView1.CurrentRow.Cells["Duyuru"].Value.ToString();
        }
    }
    }

