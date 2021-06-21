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
    public partial class Form_YonlendirmeListeleme : Form
    {
        public Form_YonlendirmeListeleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Form_YonlendirmeListeleme_Load(object sender, EventArgs e)
        {
            yonlendirmelistele();
        }
        private void yonlendirmelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Tbl_Yonlendirme", baglanti);
            adtr.Fill(daset, "Tbl_Yonlendirme");
            dataGridView1.DataSource = daset.Tables["Tbl_Yonlendirme"];
            baglanti.Close();
        }

    }
}
