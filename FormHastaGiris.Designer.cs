
namespace Proje_Hastane
{
    partial class FormHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.labeltckimlikno = new System.Windows.Forms.Label();
            this.labelsifre = new System.Windows.Forms.Label();
            this.maskedTc = new System.Windows.Forms.MaskedTextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.linkuyeol = new System.Windows.Forms.LinkLabel();
            this.buttonsistemegirisyap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(350, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labeltckimlikno
            // 
            this.labeltckimlikno.AutoSize = true;
            this.labeltckimlikno.BackColor = System.Drawing.Color.Transparent;
            this.labeltckimlikno.Location = new System.Drawing.Point(177, 335);
            this.labeltckimlikno.Name = "labeltckimlikno";
            this.labeltckimlikno.Size = new System.Drawing.Size(159, 27);
            this.labeltckimlikno.TabIndex = 1;
            this.labeltckimlikno.Text = "TC Kimlik No:";
            // 
            // labelsifre
            // 
            this.labelsifre.AutoSize = true;
            this.labelsifre.BackColor = System.Drawing.Color.Transparent;
            this.labelsifre.Location = new System.Drawing.Point(264, 394);
            this.labelsifre.Name = "labelsifre";
            this.labelsifre.Size = new System.Drawing.Size(72, 27);
            this.labelsifre.TabIndex = 2;
            this.labelsifre.Text = "Şifre: ";
            // 
            // maskedTc
            // 
            this.maskedTc.Location = new System.Drawing.Point(388, 328);
            this.maskedTc.Mask = "00000000000";
            this.maskedTc.Name = "maskedTc";
            this.maskedTc.Size = new System.Drawing.Size(211, 34);
            this.maskedTc.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(388, 384);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(211, 34);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.UseSystemPasswordChar = true;
            // 
            // linkuyeol
            // 
            this.linkuyeol.AutoSize = true;
            this.linkuyeol.BackColor = System.Drawing.Color.Transparent;
            this.linkuyeol.Font = new System.Drawing.Font("Georgia", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkuyeol.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.linkuyeol.Location = new System.Drawing.Point(388, 529);
            this.linkuyeol.Name = "linkuyeol";
            this.linkuyeol.Size = new System.Drawing.Size(223, 27);
            this.linkuyeol.TabIndex = 5;
            this.linkuyeol.TabStop = true;
            this.linkuyeol.Text = "Yeni Kayıt Oluştur";
            this.linkuyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkuyeol_LinkClicked);
            // 
            // buttonsistemegirisyap
            // 
            this.buttonsistemegirisyap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.buttonsistemegirisyap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonsistemegirisyap.Location = new System.Drawing.Point(388, 456);
            this.buttonsistemegirisyap.Name = "buttonsistemegirisyap";
            this.buttonsistemegirisyap.Size = new System.Drawing.Size(211, 46);
            this.buttonsistemegirisyap.TabIndex = 6;
            this.buttonsistemegirisyap.Text = "Sisteme Giriş Yap";
            this.buttonsistemegirisyap.UseVisualStyleBackColor = false;
            this.buttonsistemegirisyap.Click += new System.EventHandler(this.buttonsistemegirisyap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormHastaGiris
            // 
            this.AcceptButton = this.buttonsistemegirisyap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(957, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonsistemegirisyap);
            this.Controls.Add(this.linkuyeol);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.maskedTc);
            this.Controls.Add(this.labelsifre);
            this.Controls.Add(this.labeltckimlikno);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHastaGiris";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FormHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltckimlikno;
        private System.Windows.Forms.Label labelsifre;
        private System.Windows.Forms.MaskedTextBox maskedTc;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.LinkLabel linkuyeol;
        private System.Windows.Forms.Button buttonsistemegirisyap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}