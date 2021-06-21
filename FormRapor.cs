using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;



namespace Proje_Hastane
{
    public partial class FormRapor : Form
    {
        public FormRapor()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
            file.Title = "PDF DOSYASI OLUŞTURMA";
            if (file.ShowDialog()==DialogResult.OK)
            {
                FileStream dosya = File.Open(file.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf,dosya);
                //nesne oluşturma
                pdf.Open();
                pdf.AddAuthor("Doktor");
                pdf.AddCreator("Doktor");
                pdf.AddTitle("PDF DOSYASI İŞLEMLERİ");
                pdf.AddSubject("Rapor");
                pdf.AddKeywords("Hastane");
                pdf.AddCreationDate();
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "CP1254",true);
                iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.NORMAL);
                Paragraph paragraph = new Paragraph(richTextBox1.Text,font);
                pdf.Add(paragraph);
                pdf.Close();
                MessageBox.Show("Pdf Oluşturuldu.");
            }
        }
    }
}
