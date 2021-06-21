
namespace Proje_Hastane
{
    partial class FormEczaneHastaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEczaneHastaEkle));
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txthastaekleadsoyad = new System.Windows.Forms.TextBox();
            this.mskedhastaekletc = new System.Windows.Forms.MaskedTextBox();
            this.mskedhastaekletel = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhastaekleekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(204, 206);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(181, 27);
            this.label.TabIndex = 0;
            this.label.Text = "Hasta Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "HastaTC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta Telefon:";
            // 
            // txthastaekleadsoyad
            // 
            this.txthastaekleadsoyad.Location = new System.Drawing.Point(424, 199);
            this.txthastaekleadsoyad.Name = "txthastaekleadsoyad";
            this.txthastaekleadsoyad.Size = new System.Drawing.Size(220, 34);
            this.txthastaekleadsoyad.TabIndex = 3;
            // 
            // mskedhastaekletc
            // 
            this.mskedhastaekletc.Location = new System.Drawing.Point(424, 252);
            this.mskedhastaekletc.Mask = "00000000000";
            this.mskedhastaekletc.Name = "mskedhastaekletc";
            this.mskedhastaekletc.Size = new System.Drawing.Size(220, 34);
            this.mskedhastaekletc.TabIndex = 4;
            this.mskedhastaekletc.ValidatingType = typeof(int);
            // 
            // mskedhastaekletel
            // 
            this.mskedhastaekletel.Location = new System.Drawing.Point(424, 313);
            this.mskedhastaekletel.Mask = "(999) 000-0000";
            this.mskedhastaekletel.Name = "mskedhastaekletel";
            this.mskedhastaekletel.Size = new System.Drawing.Size(220, 34);
            this.mskedhastaekletel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(354, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnhastaekleekle
            // 
            this.btnhastaekleekle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnhastaekleekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhastaekleekle.Location = new System.Drawing.Point(424, 384);
            this.btnhastaekleekle.Name = "btnhastaekleekle";
            this.btnhastaekleekle.Size = new System.Drawing.Size(220, 41);
            this.btnhastaekleekle.TabIndex = 7;
            this.btnhastaekleekle.Text = "Ekle";
            this.btnhastaekleekle.UseVisualStyleBackColor = false;
            this.btnhastaekleekle.Click += new System.EventHandler(this.btnhastaekleekle_Click);
            // 
            // FormEczaneHastaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(882, 565);
            this.Controls.Add(this.btnhastaekleekle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mskedhastaekletel);
            this.Controls.Add(this.mskedhastaekletc);
            this.Controls.Add(this.txthastaekleadsoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEczaneHastaEkle";
            this.Text = "FormEczaneHastaEkle";
            this.Load += new System.EventHandler(this.FormEczaneHastaEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthastaekleadsoyad;
        private System.Windows.Forms.MaskedTextBox mskedhastaekletc;
        private System.Windows.Forms.MaskedTextBox mskedhastaekletel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnhastaekleekle;
    }
}