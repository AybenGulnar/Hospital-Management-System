
namespace Proje_Hastane
{
    partial class FormNobetciEczane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNobetciEczane));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblil = new System.Windows.Forms.Label();
            this.labelilce = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBoxilce = new System.Windows.Forms.ComboBox();
            this.comboboxiller = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(196, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "NÖBETÇİ ECZANE ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblil
            // 
            this.lblil.AutoSize = true;
            this.lblil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblil.Location = new System.Drawing.Point(196, 117);
            this.lblil.Name = "lblil";
            this.lblil.Size = new System.Drawing.Size(113, 27);
            this.lblil.TabIndex = 2;
            this.lblil.Text = "İl Seçiniz:";
            // 
            // labelilce
            // 
            this.labelilce.AutoSize = true;
            this.labelilce.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.labelilce.Location = new System.Drawing.Point(511, 117);
            this.labelilce.Name = "labelilce";
            this.labelilce.Size = new System.Drawing.Size(134, 27);
            this.labelilce.TabIndex = 3;
            this.labelilce.Text = "İlçe Seçiniz:";
            this.labelilce.Click += new System.EventHandler(this.label3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 178);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(945, 355);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // comboBoxilce
            // 
            this.comboBoxilce.FormattingEnabled = true;
            this.comboBoxilce.Location = new System.Drawing.Point(651, 112);
            this.comboBoxilce.Name = "comboBoxilce";
            this.comboBoxilce.Size = new System.Drawing.Size(173, 35);
            this.comboBoxilce.TabIndex = 5;
            this.comboBoxilce.SelectedIndexChanged += new System.EventHandler(this.comboBoxilce_SelectedIndexChanged);
            // 
            // comboboxiller
            // 
            this.comboboxiller.FormattingEnabled = true;
            this.comboboxiller.Location = new System.Drawing.Point(315, 114);
            this.comboboxiller.Name = "comboboxiller";
            this.comboboxiller.Size = new System.Drawing.Size(173, 35);
            this.comboboxiller.TabIndex = 6;
            this.comboboxiller.SelectedIndexChanged += new System.EventHandler(this.comboboxiller_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Eczane Adı";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Telefon";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adress";
            this.columnHeader3.Width = 600;
            // 
            // FormNobetciEczane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(986, 560);
            this.Controls.Add(this.comboboxiller);
            this.Controls.Add(this.comboBoxilce);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelilce);
            this.Controls.Add(this.lblil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNobetciEczane";
            this.Text = "FormNobetciEczane";
            this.Load += new System.EventHandler(this.FormNobetciEczane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblil;
        private System.Windows.Forms.Label labelilce;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBoxilce;
        private System.Windows.Forms.ComboBox comboboxiller;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}