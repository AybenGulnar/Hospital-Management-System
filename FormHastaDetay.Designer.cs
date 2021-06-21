
namespace Proje_Hastane
{
    partial class FormHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaDetay));
            this.gbhastadetay = new System.Windows.Forms.GroupBox();
            this.lbadsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sikayet = new System.Windows.Forms.Label();
            this.CmbDoktor = new System.Windows.Forms.ComboBox();
            this.lnkbilgidüzenle = new System.Windows.Forms.LinkLabel();
            this.btnrandvual = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rctxtdoktor = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbrans = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HastaDetay = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.gbhastadetay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HastaDetay)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbhastadetay
            // 
            this.gbhastadetay.Controls.Add(this.lbadsoyad);
            this.gbhastadetay.Controls.Add(this.label3);
            this.gbhastadetay.Controls.Add(this.lbltc);
            this.gbhastadetay.Controls.Add(this.label1);
            this.gbhastadetay.Location = new System.Drawing.Point(35, 13);
            this.gbhastadetay.Name = "gbhastadetay";
            this.gbhastadetay.Size = new System.Drawing.Size(550, 167);
            this.gbhastadetay.TabIndex = 0;
            this.gbhastadetay.TabStop = false;
            this.gbhastadetay.Text = "Kişi Bilgi";
            // 
            // lbadsoyad
            // 
            this.lbadsoyad.AutoSize = true;
            this.lbadsoyad.Location = new System.Drawing.Point(182, 116);
            this.lbadsoyad.Name = "lbadsoyad";
            this.lbadsoyad.Size = new System.Drawing.Size(108, 27);
            this.lbadsoyad.TabIndex = 2;
            this.lbadsoyad.Text = "Null Null";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ad Soyad:";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltc.Location = new System.Drawing.Point(182, 51);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(166, 27);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KimlikNo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sikayet);
            this.groupBox1.Controls.Add(this.CmbDoktor);
            this.groupBox1.Controls.Add(this.lnkbilgidüzenle);
            this.groupBox1.Controls.Add(this.btnrandvual);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rctxtdoktor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbrans);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 543);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevu Paneli";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(204, 42);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 34);
            this.txtid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "İd";
            // 
            // sikayet
            // 
            this.sikayet.AutoSize = true;
            this.sikayet.Location = new System.Drawing.Point(14, 269);
            this.sikayet.Name = "sikayet";
            this.sikayet.Size = new System.Drawing.Size(170, 27);
            this.sikayet.TabIndex = 6;
            this.sikayet.Text = "Şikayet Giriniz:";
            // 
            // CmbDoktor
            // 
            this.CmbDoktor.FormattingEnabled = true;
            this.CmbDoktor.Location = new System.Drawing.Point(205, 182);
            this.CmbDoktor.Name = "CmbDoktor";
            this.CmbDoktor.Size = new System.Drawing.Size(220, 35);
            this.CmbDoktor.TabIndex = 5;
            this.CmbDoktor.SelectedIndexChanged += new System.EventHandler(this.CmbDoktor_SelectedIndexChanged);
            // 
            // lnkbilgidüzenle
            // 
            this.lnkbilgidüzenle.ActiveLinkColor = System.Drawing.Color.YellowGreen;
            this.lnkbilgidüzenle.AutoSize = true;
            this.lnkbilgidüzenle.LinkColor = System.Drawing.Color.Red;
            this.lnkbilgidüzenle.Location = new System.Drawing.Point(77, 444);
            this.lnkbilgidüzenle.Name = "lnkbilgidüzenle";
            this.lnkbilgidüzenle.Size = new System.Drawing.Size(204, 27);
            this.lnkbilgidüzenle.TabIndex = 1;
            this.lnkbilgidüzenle.TabStop = true;
            this.lnkbilgidüzenle.Text = "Bilgilerini Düzenle";
            this.lnkbilgidüzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbilgidüzenle_LinkClicked);
            // 
            // btnrandvual
            // 
            this.btnrandvual.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnrandvual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrandvual.Location = new System.Drawing.Point(313, 437);
            this.btnrandvual.Name = "btnrandvual";
            this.btnrandvual.Size = new System.Drawing.Size(240, 41);
            this.btnrandvual.TabIndex = 4;
            this.btnrandvual.Text = "Randevu Onayla";
            this.btnrandvual.UseVisualStyleBackColor = false;
            this.btnrandvual.Click += new System.EventHandler(this.btnrandvual_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "Doktor:";
            // 
            // rctxtdoktor
            // 
            this.rctxtdoktor.Location = new System.Drawing.Point(204, 266);
            this.rctxtdoktor.Name = "rctxtdoktor";
            this.rctxtdoktor.Size = new System.Drawing.Size(349, 165);
            this.rctxtdoktor.TabIndex = 1;
            this.rctxtdoktor.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // cmbrans
            // 
            this.cmbrans.FormattingEnabled = true;
            this.cmbrans.Location = new System.Drawing.Point(204, 112);
            this.cmbrans.Name = "cmbrans";
            this.cmbrans.Size = new System.Drawing.Size(220, 35);
            this.cmbrans.TabIndex = 0;
            this.cmbrans.SelectedIndexChanged += new System.EventHandler(this.cmbrans_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HastaDetay);
            this.groupBox2.Location = new System.Drawing.Point(622, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 331);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Geçmişi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // HastaDetay
            // 
            this.HastaDetay.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.HastaDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HastaDetay.Location = new System.Drawing.Point(3, 30);
            this.HastaDetay.Name = "HastaDetay";
            this.HastaDetay.RowHeadersWidth = 51;
            this.HastaDetay.RowTemplate.Height = 29;
            this.HastaDetay.Size = new System.Drawing.Size(741, 298);
            this.HastaDetay.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(625, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(744, 327);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aktif Randevu";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(738, 294);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Location = new System.Drawing.Point(314, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(239, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "Nöbetçi Eczane Ara";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1381, 742);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbhastadetay);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHastaDetay";
            this.Text = "Hasta Bilgileri";
            this.Load += new System.EventHandler(this.FormHastaDetay_Load);
            this.gbhastadetay.ResumeLayout(false);
            this.gbhastadetay.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HastaDetay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbhastadetay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbrans;
        private System.Windows.Forms.RichTextBox rctxtdoktor;
        private System.Windows.Forms.Button btnrandvual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView HastaDetay;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkbilgidüzenle;
        private System.Windows.Forms.Label sikayet;
        private System.Windows.Forms.ComboBox CmbDoktor;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}