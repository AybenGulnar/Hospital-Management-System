using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class OdaMain : Form
    {
        public OdaMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OdaHastaKayit kayit = new OdaHastaKayit();
            kayit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdaOdeme odeme = new OdaOdeme();
            odeme.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdaHastaDetay odaHastaDetay = new OdaHastaDetay();
            odaHastaDetay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdaBilgisi odaBilgisi = new OdaBilgisi();
            odaBilgisi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdaOdemeGoruntuleme odaOdemeGoruntuleme = new OdaOdemeGoruntuleme();
            odaOdemeGoruntuleme.Show();
        }
    }
}
