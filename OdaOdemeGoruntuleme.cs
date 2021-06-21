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
    public partial class OdaOdemeGoruntuleme : Form
    {
        public OdaOdemeGoruntuleme()
        {
            InitializeComponent();
        }

        private void OdaOdemeGoruntuleme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hospitalDataSet3.checkout' table. You can move, or remove it, as needed.
            //this.checkoutTableAdapter.Fill(this.hospitalDataSet3.checkout);
            using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
            {

                string str2 = "SELECT * FROM Tbl_Odeme";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection("Data Source = DESKTOP-QE05UM2\\SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True"))
            {

                string str2 = "SELECT * FROM Tbl_Odeme where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
