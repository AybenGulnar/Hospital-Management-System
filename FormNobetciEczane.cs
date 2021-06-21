using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using System.Data.SqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Globalization;
using System.Linq;


namespace Proje_Hastane
{

   
    public partial class FormNobetciEczane : Form
    {
        public IWebDriver driver;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public FormNobetciEczane()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--window-position=-32000,-32000");
            driver = new ChromeDriver(service,options);
           

        }
        



        private void FormNobetciEczane_Load(object sender, EventArgs e)
        {
            illerTablosu();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void illerTablosu()
        {
          
            con = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM iller";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboboxiller.Items.Add(dr["sehir"]);
            }
            con.Close();
        }

        private void comboboxiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-QE05UM2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM ilceler where sehir='" + (comboboxiller.SelectedIndex + 1).ToString() + "'";
            dr = cmd.ExecuteReader();
            comboBoxilce.Items.Clear();

            while (dr.Read())
            {
                comboBoxilce.Items.Add(dr["ilce"]);
            }
            con.Close();
        }

        private void comboBoxilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String url = "https://ecza.io/" + comboboxiller.SelectedItem + "-" + comboBoxilce.SelectedItem + "-nobetci-eczane";
            url = url.ToLower(new CultureInfo("en-US", false));
            driver.Navigate().GoToUrl(url);
            

            
           
            int nobetciSayisi = Convert.ToInt32(driver.FindElement(By.XPath("/html/body/main/div[2]/div/div[2]/div/h3/span")).Text.Replace("Eczane", "").Trim());
            if (nobetciSayisi > 0)
            {
                for (int i = 1; i <= 6; i++)
                {

                    try
                    {
                        string ecz1 = driver.FindElement(By.XPath("/ html / body / main / div[2] / div / div[3] / div[" + i + "] / div[2] / span / a")).Text.Trim().ToString();
                        string ecz1Tel = driver.FindElement(By.XPath(" / html / body / main / div[2] / div / div[3] / div[" + i + "] / div[2] / span / mark / a")).Text.Trim().ToString();
                        string ecz1Adress = driver.FindElement(By.XPath("/ html / body / main / div[2] / div / div[3] / div[" + i + "] / div[3] / span")).Text.Trim().ToString();
                        
                        ListViewItem item = new ListViewItem(ecz1);
                        item.SubItems.Add(ecz1Tel);
                        item.SubItems.Add(ecz1Adress);
                        listView1.Items.Add(item);
                    }
                    catch (NoSuchElementException)
                    {
                        break;
                    }


                }
                driver.Close();
            }
            else
            {
                ListViewItem item = new ListViewItem("SEÇİLEN BÖLGEDE ECZANE BULUNAMADI");
                listView1.Items.Add(item);
            }
            


           
        }
    }
}
