using System;

namespace Otopark_Otomasyon
{
    partial class AnaSayfa
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
            this.btn_Odeme = new System.Windows.Forms.Button();
            this.btn_Musteri = new System.Windows.Forms.Button();
            this.btn_Rapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Odeme
            // 
            this.btn_Odeme.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Odeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme.Location = new System.Drawing.Point(68, 44);
            this.btn_Odeme.Name = "btn_Odeme";
            this.btn_Odeme.Size = new System.Drawing.Size(180, 99);
            this.btn_Odeme.TabIndex = 0;
            this.btn_Odeme.Text = "ÖDEME";
            this.btn_Odeme.UseVisualStyleBackColor = false;
            this.btn_Odeme.Click += new System.EventHandler(this.btn_Odeme_Click);
            // 
            // btn_Musteri
            // 
            this.btn_Musteri.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Musteri.Location = new System.Drawing.Point(68, 330);
            this.btn_Musteri.Name = "btn_Musteri";
            this.btn_Musteri.Size = new System.Drawing.Size(180, 99);
            this.btn_Musteri.TabIndex = 1;
            this.btn_Musteri.Text = "AYARLAR";
            this.btn_Musteri.UseVisualStyleBackColor = false;
            this.btn_Musteri.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_Rapor
            // 
            this.btn_Rapor.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Rapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Rapor.Location = new System.Drawing.Point(68, 187);
            this.btn_Rapor.Name = "btn_Rapor";
            this.btn_Rapor.Size = new System.Drawing.Size(180, 99);
            this.btn_Rapor.TabIndex = 2;
            this.btn_Rapor.Text = "RAPOR";
            this.btn_Rapor.UseVisualStyleBackColor = false;
            this.btn_Rapor.Click += new System.EventHandler(this.btn_Rapor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.btn_Rapor);
            this.Controls.Add(this.btn_Musteri);
            this.Controls.Add(this.btn_Odeme);
            this.Name = "Form1";
            this.Text = "Atak Oto Yıkama";
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Button btn_Odeme;
        private System.Windows.Forms.Button btn_Musteri;
        private System.Windows.Forms.Button btn_Rapor;
    }
}

