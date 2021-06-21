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
    public partial class OdaBilgisi : Form
    {
        public OdaBilgisi()
        {
            InitializeComponent();
        }

        private void OdaBilgisi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet2.room' table. You can move, or remove it, as needed.
           // this.roomTableAdapter.Fill(this.hospitalDataSet2.room);
            using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
            {

                string str2 = "SELECT * FROM Tbl_Oda";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");
            con.Open();

            try
            {
                string str = "INSERT INTO Tbl_Oda(binano,odatip,odano,yatakno,fiyat,oda_status) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                string str1 = "select max(Id) from Tbl_Oda;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Oda bilgisi kaydedildi..");
                    textBox2.Text = "";
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
                    {

                        string str2 = "SELECT * FROM Tbl_Oda";
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells["oda_status"].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells["binano"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["odatip"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["odano"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["yatakno"].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells["fiyat"].Value.ToString();
        }
    }
}
