namespace Otopark_Otomasyon
{
    partial class OdemeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.cmbAracTipleri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOdemeTurleri = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIslemTipleri = new System.Windows.Forms.ComboBox();
            this.lblTutarBilgisi = new System.Windows.Forms.Label();
            this.btnOdemeyiTamamla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbArabaModelleri = new System.Windows.Forms.ComboBox();
            this.cmbMusteriBilgileri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka :";
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Plaka.Location = new System.Drawing.Point(126, 24);
            this.txt_Plaka.Multiline = true;
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(215, 30);
            this.txt_Plaka.TabIndex = 0;
            this.txt_Plaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            this.txt_Plaka.Leave += new System.EventHandler(this.PlakaCheck);
            // 
            // cmbAracTipleri
            // 
            this.cmbAracTipleri.FormattingEnabled = true;
            this.cmbAracTipleri.Items.AddRange(new object[] {
            "Otomobil",
            "Arazi, SUV & Pick-up",
            "Motosiklet",
            "Minivan & Panelvan ",
            "Karavan",
            "Kamyon",
            "Kamyonet",
            "Tır"});
            this.cmbAracTipleri.Location = new System.Drawing.Point(126, 139);
            this.cmbAracTipleri.Name = "cmbAracTipleri";
            this.cmbAracTipleri.Size = new System.Drawing.Size(215, 21);
            this.cmbAracTipleri.TabIndex = 2;
            this.cmbAracTipleri.SelectedIndexChanged += new System.EventHandler(this.cmbItip_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Tipi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ödeme :";
            // 
            // cmbOdemeTurleri
            // 
            this.cmbOdemeTurleri.FormattingEnabled = true;
            this.cmbOdemeTurleri.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.cmbOdemeTurleri.Location = new System.Drawing.Point(126, 298);
            this.cmbOdemeTurleri.Name = "cmbOdemeTurleri";
            this.cmbOdemeTurleri.Size = new System.Drawing.Size(215, 21);
            this.cmbOdemeTurleri.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "İşlem Tipi:";
            // 
            // cmbIslemTipleri
            // 
            this.cmbIslemTipleri.FormattingEnabled = true;
            this.cmbIslemTipleri.Items.AddRange(new object[] {
            "Dış Yıkama",
            "İç Yıkama",
            "Motor temizliği",
            "Döşeme Temizliği",
            "Tavan Temizliği",
            "Pasta - Cila"});
            this.cmbIslemTipleri.Location = new System.Drawing.Point(126, 245);
            this.cmbIslemTipleri.Name = "cmbIslemTipleri";
            this.cmbIslemTipleri.Size = new System.Drawing.Size(215, 21);
            this.cmbIslemTipleri.TabIndex = 4;
            this.cmbIslemTipleri.SelectedIndexChanged += new System.EventHandler(this.cmbItip_SelectedIndexChanged);
            // 
            // lblTutarBilgisi
            // 
            this.lblTutarBilgisi.AutoSize = true;
            this.lblTutarBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutarBilgisi.Location = new System.Drawing.Point(125, 347);
            this.lblTutarBilgisi.Name = "lblTutarBilgisi";
            this.lblTutarBilgisi.Size = new System.Drawing.Size(83, 31);
            this.lblTutarBilgisi.TabIndex = 4;
            this.lblTutarBilgisi.Text = "Tutar";
            // 
            // btnOdemeyiTamamla
            // 
            this.btnOdemeyiTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeyiTamamla.Location = new System.Drawing.Point(88, 403);
            this.btnOdemeyiTamamla.Name = "btnOdemeyiTamamla";
            this.btnOdemeyiTamamla.Size = new System.Drawing.Size(156, 39);
            this.btnOdemeyiTamamla.TabIndex = 6;
            this.btnOdemeyiTamamla.Text = "Ödemeyi Tamamla";
            this.btnOdemeyiTamamla.UseVisualStyleBackColor = true;
            this.btnOdemeyiTamamla.Click += new System.EventHandler(this.btnOdemeyiTamamla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Araç Modeli :";
            // 
            // cmbArabaModelleri
            // 
            this.cmbArabaModelleri.FormattingEnabled = true;
            this.cmbArabaModelleri.Location = new System.Drawing.Point(126, 192);
            this.cmbArabaModelleri.Name = "cmbArabaModelleri";
            this.cmbArabaModelleri.Size = new System.Drawing.Size(215, 21);
            this.cmbArabaModelleri.TabIndex = 3;
            // 
            // cmbMusteriBilgileri
            // 
            this.cmbMusteriBilgileri.FormattingEnabled = true;
            this.cmbMusteriBilgileri.Items.AddRange(new object[] {
            "Otomobil",
            "Arazi, SUV & Pick-up",
            "Motosiklet",
            "Minivan & Panelvan ",
            "Karavan",
            "Kamyon",
            "Kamyonet",
            "Tır"});
            this.cmbMusteriBilgileri.Location = new System.Drawing.Point(126, 86);
            this.cmbMusteriBilgileri.Name = "cmbMusteriBilgileri";
            this.cmbMusteriBilgileri.Size = new System.Drawing.Size(215, 21);
            this.cmbMusteriBilgileri.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Müşteri : ";
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 461);
            this.Controls.Add(this.cmbMusteriBilgileri);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOdemeyiTamamla);
            this.Controls.Add(this.lblTutarBilgisi);
            this.Controls.Add(this.cmbOdemeTurleri);
            this.Controls.Add(this.cmbIslemTipleri);
            this.Controls.Add(this.cmbArabaModelleri);
            this.Controls.Add(this.cmbAracTipleri);
            this.Controls.Add(this.txt_Plaka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OdemeForm";
            this.Text = "Atak Oto Yıkama";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTutarBilgisi;
        private System.Windows.Forms.Button btnOdemeyiTamamla;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_Plaka;
        public System.Windows.Forms.ComboBox cmbAracTipleri;
        public System.Windows.Forms.ComboBox cmbOdemeTurleri;
        public System.Windows.Forms.ComboBox cmbIslemTipleri;
        public System.Windows.Forms.ComboBox cmbArabaModelleri;
        public System.Windows.Forms.ComboBox cmbMusteriBilgileri;
        private System.Windows.Forms.Label label5;
    }
}