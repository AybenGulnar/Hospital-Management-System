
namespace Proje_Hastane
{
    partial class FormUrunListeleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunListeleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblMiktari = new System.Windows.Forms.Label();
            this.btngüncelleurun = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.urunsatisfiyatxt = new System.Windows.Forms.TextBox();
            this.urunalistxt = new System.Windows.Forms.TextBox();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.urunaditxt = new System.Windows.Forms.TextBox();
            this.markatxt = new System.Windows.Forms.TextBox();
            this.kategoritxt = new System.Windows.Forms.TextBox();
            this.barkodtxt = new System.Windows.Forms.TextBox();
            this.btnsilurun = new System.Windows.Forms.Button();
            this.txtbarkodnoarama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxmarka = new System.Windows.Forms.ComboBox();
            this.comboBoxkategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkategoriguncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(501, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(698, 586);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // lblMiktari
            // 
            this.lblMiktari.AutoSize = true;
            this.lblMiktari.Location = new System.Drawing.Point(88, 468);
            this.lblMiktari.Name = "lblMiktari";
            this.lblMiktari.Size = new System.Drawing.Size(0, 27);
            this.lblMiktari.TabIndex = 38;
            // 
            // btngüncelleurun
            // 
            this.btngüncelleurun.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btngüncelleurun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngüncelleurun.Location = new System.Drawing.Point(222, 419);
            this.btngüncelleurun.Name = "btngüncelleurun";
            this.btngüncelleurun.Size = new System.Drawing.Size(124, 40);
            this.btngüncelleurun.TabIndex = 37;
            this.btngüncelleurun.Text = "Güncelle";
            this.btngüncelleurun.UseVisualStyleBackColor = false;
            this.btngüncelleurun.Click += new System.EventHandler(this.btngüncelleurun_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 27);
            this.label8.TabIndex = 36;
            this.label8.Text = "Satış Fiyatı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 27);
            this.label9.TabIndex = 35;
            this.label9.Text = "Alış Fiyatı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(150, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 27);
            this.label10.TabIndex = 34;
            this.label10.Text = "Miktarı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 27);
            this.label11.TabIndex = 33;
            this.label11.Text = "ÜrünAdı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 27);
            this.label12.TabIndex = 32;
            this.label12.Text = "Alt Kategori:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(139, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 27);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kategori:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(123, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 27);
            this.label14.TabIndex = 30;
            this.label14.Text = "BarkodNo:";
            // 
            // urunsatisfiyatxt
            // 
            this.urunsatisfiyatxt.Location = new System.Drawing.Point(261, 347);
            this.urunsatisfiyatxt.Name = "urunsatisfiyatxt";
            this.urunsatisfiyatxt.Size = new System.Drawing.Size(217, 34);
            this.urunsatisfiyatxt.TabIndex = 29;
            // 
            // urunalistxt
            // 
            this.urunalistxt.Location = new System.Drawing.Point(261, 307);
            this.urunalistxt.Name = "urunalistxt";
            this.urunalistxt.Size = new System.Drawing.Size(217, 34);
            this.urunalistxt.TabIndex = 28;
            // 
            // miktartxt
            // 
            this.miktartxt.Location = new System.Drawing.Point(261, 263);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(217, 34);
            this.miktartxt.TabIndex = 27;
            // 
            // urunaditxt
            // 
            this.urunaditxt.Location = new System.Drawing.Point(261, 219);
            this.urunaditxt.Name = "urunaditxt";
            this.urunaditxt.Size = new System.Drawing.Size(217, 34);
            this.urunaditxt.TabIndex = 26;
            // 
            // markatxt
            // 
            this.markatxt.Location = new System.Drawing.Point(261, 179);
            this.markatxt.Name = "markatxt";
            this.markatxt.ReadOnly = true;
            this.markatxt.Size = new System.Drawing.Size(217, 34);
            this.markatxt.TabIndex = 25;
            // 
            // kategoritxt
            // 
            this.kategoritxt.Location = new System.Drawing.Point(261, 139);
            this.kategoritxt.Name = "kategoritxt";
            this.kategoritxt.ReadOnly = true;
            this.kategoritxt.Size = new System.Drawing.Size(217, 34);
            this.kategoritxt.TabIndex = 24;
            // 
            // barkodtxt
            // 
            this.barkodtxt.Location = new System.Drawing.Point(261, 99);
            this.barkodtxt.Name = "barkodtxt";
            this.barkodtxt.Size = new System.Drawing.Size(217, 34);
            this.barkodtxt.TabIndex = 23;
            // 
            // btnsilurun
            // 
            this.btnsilurun.BackColor = System.Drawing.Color.Red;
            this.btnsilurun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsilurun.Location = new System.Drawing.Point(352, 419);
            this.btnsilurun.Name = "btnsilurun";
            this.btnsilurun.Size = new System.Drawing.Size(124, 40);
            this.btnsilurun.TabIndex = 39;
            this.btnsilurun.Text = "Sil";
            this.btnsilurun.UseVisualStyleBackColor = false;
            this.btnsilurun.Click += new System.EventHandler(this.btnsilurun_Click);
            // 
            // txtbarkodnoarama
            // 
            this.txtbarkodnoarama.Location = new System.Drawing.Point(261, 50);
            this.txtbarkodnoarama.Name = "txtbarkodnoarama";
            this.txtbarkodnoarama.Size = new System.Drawing.Size(215, 34);
            this.txtbarkodnoarama.TabIndex = 40;
            this.txtbarkodnoarama.TextChanged += new System.EventHandler(this.txtbarkodnoarama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 41;
            this.label1.Text = "Barkod No ile Arama:";
            // 
            // comboBoxmarka
            // 
            this.comboBoxmarka.FormattingEnabled = true;
            this.comboBoxmarka.Location = new System.Drawing.Point(250, 543);
            this.comboBoxmarka.Name = "comboBoxmarka";
            this.comboBoxmarka.Size = new System.Drawing.Size(217, 35);
            this.comboBoxmarka.TabIndex = 42;
            // 
            // comboBoxkategori
            // 
            this.comboBoxkategori.FormattingEnabled = true;
            this.comboBoxkategori.Location = new System.Drawing.Point(250, 502);
            this.comboBoxkategori.Name = "comboBoxkategori";
            this.comboBoxkategori.Size = new System.Drawing.Size(217, 35);
            this.comboBoxkategori.TabIndex = 43;
            this.comboBoxkategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxkategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 27);
            this.label2.TabIndex = 44;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 27);
            this.label3.TabIndex = 45;
            this.label3.Text = "Alt Kategori:";
            // 
            // btnkategoriguncelle
            // 
            this.btnkategoriguncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnkategoriguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnkategoriguncelle.Location = new System.Drawing.Point(343, 584);
            this.btnkategoriguncelle.Name = "btnkategoriguncelle";
            this.btnkategoriguncelle.Size = new System.Drawing.Size(124, 40);
            this.btnkategoriguncelle.TabIndex = 46;
            this.btnkategoriguncelle.Text = "Güncelle";
            this.btnkategoriguncelle.UseVisualStyleBackColor = false;
            this.btnkategoriguncelle.Click += new System.EventHandler(this.btnkategoriguncelle_Click);
            // 
            // FormUrunListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1245, 668);
            this.Controls.Add(this.btnkategoriguncelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxkategori);
            this.Controls.Add(this.comboBoxmarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbarkodnoarama);
            this.Controls.Add(this.btnsilurun);
            this.Controls.Add(this.lblMiktari);
            this.Controls.Add(this.btngüncelleurun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.urunsatisfiyatxt);
            this.Controls.Add(this.urunalistxt);
            this.Controls.Add(this.miktartxt);
            this.Controls.Add(this.urunaditxt);
            this.Controls.Add(this.markatxt);
            this.Controls.Add(this.kategoritxt);
            this.Controls.Add(this.barkodtxt);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrunListeleme";
            this.Text = "Urun Listeleme";
            this.Load += new System.EventHandler(this.FormUrunListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMiktari;
        private System.Windows.Forms.Button btngüncelleurun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox urunsatisfiyatxt;
        private System.Windows.Forms.TextBox urunalistxt;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.TextBox urunaditxt;
        private System.Windows.Forms.TextBox markatxt;
        private System.Windows.Forms.TextBox kategoritxt;
        private System.Windows.Forms.TextBox barkodtxt;
        private System.Windows.Forms.Button btnsilurun;
        private System.Windows.Forms.TextBox txtbarkodnoarama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxmarka;
        private System.Windows.Forms.ComboBox comboBoxkategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkategoriguncelle;
    }
}