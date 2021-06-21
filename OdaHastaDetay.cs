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
    public partial class OdaHastaDetay : Form
    {
        public OdaHastaDetay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");

            con.Open();
            if (textBox1.Text != "")
            {
                try
                {
                    string getCust = "select isim,cinsiyet,yas,tarih,numara,adres,hastalik,statu,odatip,binano,odano,fiyat from Tbl_OdaHasta where id=" + Convert.ToInt32(textBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        textBox2.Text = dr.GetValue(0).ToString();
                        if (dr[1].ToString() == "Erkek")
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                        textBox3.Text = dr.GetValue(2).ToString();
                        textBox4.Text = dr.GetValue(3).ToString();
                        textBox5.Text = dr.GetValue(4).ToString();
                        textBox6.Text = dr.GetValue(5).ToString();
                        textBox7.Text = dr.GetValue(6).ToString();
                        textBox8.Text = dr.GetValue(7).ToString();
                        textBox10.Text = dr.GetValue(8).ToString();
                        textBox9.Text = dr.GetValue(9).ToString();
                        textBox11.Text = dr.GetValue(10).ToString();
                        textBox12.Text = dr.GetValue(11).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Sorry, This ID, " + textBox1.Text + " Staff is not Available.   ");
                        textBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();
            }
        }

        private void OdaHastaDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet1.patient' table. You can move, or remove it, as needed.
           // this.patientTableAdapter.Fill(this.hospitalDataSet1.patient);
            using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
            {

                string str2 = "SELECT * FROM Tbl_OdaHasta";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");
            con.Open();
            string gen = string.Empty;
            if (radioButton1.Checked)
            {
                gen = "Erkek";
            }
            else
            {
                gen = "Kadın";
            }
            try
            {
                string str = " Update Tbl_OdaHasta set isim='" + textBox2.Text + "',cinsiyet='" + gen + "',yas='" + textBox3.Text + "',tarih='" + textBox4.Text + "',numara='" + textBox5.Text + "',adres='" + textBox6.Text + "',hastalik='" + textBox7.Text + "',statu='" + textBox8.Text + "',odatip='" + textBox10.Text + "',binano='" + textBox9.Text + "',odano='" + textBox11.Text + "',fiyat='" + textBox12.Text + "' where id='" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                string str1 = "select max(id) from Tbl_OdaHasta;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("" + textBox2.Text + "'nın bilgileri güncellendi ", "Important Message");
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
                    {

                        string str2 = "SELECT * FROM Tbl_OdaHasta";
                        SqlCommand cmd2 = new SqlCommand(str2, con1);
                        SqlDataAdapter da = new SqlDataAdapter(cmd2);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = new BindingSource(dt, null);
                    }
                }
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");
            con.Open();
            try
            {

                string str = "DELETE FROM Tbl_OdaHasta WHERE id = '" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(" Hasta Silindi");
                using (con)
                {

                    string str2 = "SELECT * FROM Tbl_OdaHasta";
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Hasta Id giriniz..");
            }
        }
    }
}
