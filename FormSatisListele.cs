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
    public partial class FormSatisListele : Form
    {
        public FormSatisListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void FormSatisListele_Load(object sender, EventArgs e)
        {
            satislistele();
        }

        private void satislistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Satis", baglanti);
            adtr.Fill(daset, "Tbl_Satis");
            dataGridView1.DataSource = daset.Tables["Tbl_Satis"];
            baglanti.Close();
        }
    }
}
