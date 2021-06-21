
namespace Proje_Hastane
{
    partial class FormYonlendirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonlendirme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbydoktor = new System.Windows.Forms.ComboBox();
            this.cmbyrandevu = new System.Windows.Forms.ComboBox();
            this.cmbyyenidoktor = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnyonlendir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC\'nizi Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Randevuid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yönlendirilecek Branş:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbydoktor
            // 
            this.cmbydoktor.FormattingEnabled = true;
            this.cmbydoktor.Location = new System.Drawing.Point(507, 249);
            this.cmbydoktor.Name = "cmbydoktor";
            this.cmbydoktor.Size = new System.Drawing.Size(216, 35);
            this.cmbydoktor.TabIndex = 3;
            // 
            // cmbyrandevu
            // 
            this.cmbyrandevu.FormattingEnabled = true;
            this.cmbyrandevu.Location = new System.Drawing.Point(507, 299);
            this.cmbyrandevu.Name = "cmbyrandevu";
            this.cmbyrandevu.Size = new System.Drawing.Size(216, 35);
            this.cmbyrandevu.TabIndex = 4;
            // 
            // cmbyyenidoktor
            // 
            this.cmbyyenidoktor.FormattingEnabled = true;
            this.cmbyyenidoktor.Location = new System.Drawing.Point(507, 355);
            this.cmbyyenidoktor.Name = "cmbyyenidoktor";
            this.cmbyyenidoktor.Size = new System.Drawing.Size(216, 35);
            this.cmbyyenidoktor.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnyonlendir
            // 
            this.btnyonlendir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnyonlendir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnyonlendir.Location = new System.Drawing.Point(507, 423);
            this.btnyonlendir.Name = "btnyonlendir";
            this.btnyonlendir.Size = new System.Drawing.Size(217, 51);
            this.btnyonlendir.TabIndex = 8;
            this.btnyonlendir.Text = "Yönlendir";
            this.btnyonlendir.UseVisualStyleBackColor = false;
            this.btnyonlendir.Click += new System.EventHandler(this.btnyonlendir_Click);
            // 
            // FormYonlendirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(981, 633);
            this.Controls.Add(this.btnyonlendir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbyyenidoktor);
            this.Controls.Add(this.cmbyrandevu);
            this.Controls.Add(this.cmbydoktor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYonlendirme";
            this.Text = "FormYonlendirme";
            this.Load += new System.EventHandler(this.FormYonlendirme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbydoktor;
        private System.Windows.Forms.ComboBox cmbyrandevu;
        private System.Windows.Forms.ComboBox cmbyyenidoktor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnyonlendir;
    }
}