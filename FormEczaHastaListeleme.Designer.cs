
namespace Proje_Hastane
{
    partial class FormEczaHastaListeleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEczaHastaListeleme));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnhastaguncelle = new System.Windows.Forms.Button();
            this.mskedhastaekletel = new System.Windows.Forms.MaskedTextBox();
            this.mskedhastaekletc = new System.Windows.Forms.MaskedTextBox();
            this.txthastaekleadsoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxtcara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(493, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(512, 618);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnhastaguncelle
            // 
            this.btnhastaguncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastaguncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhastaguncelle.Location = new System.Drawing.Point(242, 437);
            this.btnhastaguncelle.Name = "btnhastaguncelle";
            this.btnhastaguncelle.Size = new System.Drawing.Size(220, 41);
            this.btnhastaguncelle.TabIndex = 14;
            this.btnhastaguncelle.Text = "Güncelle";
            this.btnhastaguncelle.UseVisualStyleBackColor = false;
            this.btnhastaguncelle.Click += new System.EventHandler(this.btnhastaguncelle_Click);
            // 
            // mskedhastaekletel
            // 
            this.mskedhastaekletel.Location = new System.Drawing.Point(242, 366);
            this.mskedhastaekletel.Mask = "(999) 000-0000";
            this.mskedhastaekletel.Name = "mskedhastaekletel";
            this.mskedhastaekletel.Size = new System.Drawing.Size(220, 34);
            this.mskedhastaekletel.TabIndex = 13;
            // 
            // mskedhastaekletc
            // 
            this.mskedhastaekletc.Location = new System.Drawing.Point(242, 305);
            this.mskedhastaekletc.Mask = "00000000000";
            this.mskedhastaekletc.Name = "mskedhastaekletc";
            this.mskedhastaekletc.Size = new System.Drawing.Size(220, 34);
            this.mskedhastaekletc.TabIndex = 12;
            this.mskedhastaekletc.ValidatingType = typeof(int);
            // 
            // txthastaekleadsoyad
            // 
            this.txthastaekleadsoyad.Location = new System.Drawing.Point(242, 252);
            this.txthastaekleadsoyad.Name = "txthastaekleadsoyad";
            this.txthastaekleadsoyad.Size = new System.Drawing.Size(220, 34);
            this.txthastaekleadsoyad.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "HastaTC:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 259);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(181, 27);
            this.label.TabIndex = 8;
            this.label.Text = "Hasta Ad Soyad:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // buttonsil
            // 
            this.buttonsil.BackColor = System.Drawing.Color.Red;
            this.buttonsil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsil.Location = new System.Drawing.Point(242, 499);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(220, 40);
            this.buttonsil.TabIndex = 16;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = false;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "TC ile Arayınız:";
            // 
            // textBoxtcara
            // 
            this.textBoxtcara.Location = new System.Drawing.Point(242, 596);
            this.textBoxtcara.Name = "textBoxtcara";
            this.textBoxtcara.Size = new System.Drawing.Size(220, 34);
            this.textBoxtcara.TabIndex = 18;
            this.textBoxtcara.TextChanged += new System.EventHandler(this.textBoxtcara_TextChanged);
            // 
            // FormEczaHastaListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1014, 675);
            this.Controls.Add(this.textBoxtcara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonsil);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnhastaguncelle);
            this.Controls.Add(this.mskedhastaekletel);
            this.Controls.Add(this.mskedhastaekletc);
            this.Controls.Add(this.txthastaekleadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEczaHastaListeleme";
            this.Text = "FormEczaHastaListeleme";
            this.Load += new System.EventHandler(this.FormEczaHastaListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhastaguncelle;
        private System.Windows.Forms.MaskedTextBox mskedhastaekletel;
        private System.Windows.Forms.MaskedTextBox mskedhastaekletc;
        private System.Windows.Forms.TextBox txthastaekleadsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxtcara;
    }
}