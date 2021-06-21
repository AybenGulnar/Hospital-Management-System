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
    public partial class FormRandevuDetayy : Form
    {
        public FormRandevuDetayy()
        {
            InitializeComponent();
        }

        private void FormRandevuDetayy_Load(object sender, EventArgs e)
        {
            listele();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void listele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Doktorrandevu", baglanti);
            adtr.Fill(daset, "Tbl_Doktorrandevu");
            dataGridView1.DataSource = daset.Tables["Tbl_Doktorrandevu"];
            baglanti.Close();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
