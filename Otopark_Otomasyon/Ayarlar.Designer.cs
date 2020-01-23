namespace Otopark_Otomasyon
{
    partial class Ayarlar
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
            this.txtHizmetAdi = new System.Windows.Forms.TextBox();
            this.btnEkleneniKaydet = new System.Windows.Forms.Button();
            this.lblEklemeAdı = new System.Windows.Forms.Label();
            this.txtHizmetUcreti = new System.Windows.Forms.TextBox();
            this.LblEklemeSayi = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDegisiklikYapTablosu = new System.Windows.Forms.DataGridView();
            this.txtAracinUcretFarki = new System.Windows.Forms.TextBox();
            this.txtAracınTipi = new System.Windows.Forms.TextBox();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.btn_DegisikKaydet = new System.Windows.Forms.Button();
            this.txtHizmetinUcreti = new System.Windows.Forms.TextBox();
            this.txtHizmetinAdi = new System.Windows.Forms.TextBox();
            this.lblDegisiklikYapilacakTablo = new System.Windows.Forms.Label();
            this.cmbDegisiklikYapilacakVeriSecimi = new System.Windows.Forms.ComboBox();
            this.txtMusteriTelefonu = new System.Windows.Forms.TextBox();
            this.txtMusteriAdiSoyadi = new System.Windows.Forms.TextBox();
            this.lblDegisenDetay = new System.Windows.Forms.Label();
            this.lblDegisenAd = new System.Windows.Forms.Label();
            this.cmbDegisiklikYapilacakTablo = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEkleme = new System.Windows.Forms.DataGridView();
            this.cmbEklemeYapilacakTablo = new System.Windows.Forms.ComboBox();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTabloVerisiAdi = new System.Windows.Forms.ComboBox();
            this.cmbTabloSecimi = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegisiklikYapTablosu)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkleme)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHizmetAdi
            // 
            this.txtHizmetAdi.Location = new System.Drawing.Point(118, 58);
            this.txtHizmetAdi.Name = "txtHizmetAdi";
            this.txtHizmetAdi.Size = new System.Drawing.Size(202, 20);
            this.txtHizmetAdi.TabIndex = 1;
            // 
            // btnEkleneniKaydet
            // 
            this.btnEkleneniKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleneniKaydet.Location = new System.Drawing.Point(66, 400);
            this.btnEkleneniKaydet.Name = "btnEkleneniKaydet";
            this.btnEkleneniKaydet.Size = new System.Drawing.Size(181, 28);
            this.btnEkleneniKaydet.TabIndex = 3;
            this.btnEkleneniKaydet.Text = "Kaydet";
            this.btnEkleneniKaydet.UseVisualStyleBackColor = true;
            this.btnEkleneniKaydet.Click += new System.EventHandler(this.btnEkleneniKaydet_Click);
            // 
            // lblEklemeAdı
            // 
            this.lblEklemeAdı.AutoSize = true;
            this.lblEklemeAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklemeAdı.Location = new System.Drawing.Point(10, 59);
            this.lblEklemeAdı.Name = "lblEklemeAdı";
            this.lblEklemeAdı.Size = new System.Drawing.Size(84, 15);
            this.lblEklemeAdı.TabIndex = 3;
            this.lblEklemeAdı.Text = "Hizmet Adı :";
            // 
            // txtHizmetUcreti
            // 
            this.txtHizmetUcreti.Location = new System.Drawing.Point(118, 92);
            this.txtHizmetUcreti.Name = "txtHizmetUcreti";
            this.txtHizmetUcreti.Size = new System.Drawing.Size(202, 20);
            this.txtHizmetUcreti.TabIndex = 2;
            // 
            // LblEklemeSayi
            // 
            this.LblEklemeSayi.AutoSize = true;
            this.LblEklemeSayi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LblEklemeSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEklemeSayi.Location = new System.Drawing.Point(10, 93);
            this.LblEklemeSayi.Name = "LblEklemeSayi";
            this.LblEklemeSayi.Size = new System.Drawing.Size(102, 15);
            this.LblEklemeSayi.TabIndex = 3;
            this.LblEklemeSayi.Text = "Hizmet Ücreti :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 462);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDegisiklikYapTablosu);
            this.tabPage2.Controls.Add(this.txtAracinUcretFarki);
            this.tabPage2.Controls.Add(this.txtAracınTipi);
            this.tabPage2.Controls.Add(this.lblMusteriID);
            this.tabPage2.Controls.Add(this.btn_DegisikKaydet);
            this.tabPage2.Controls.Add(this.txtHizmetinUcreti);
            this.tabPage2.Controls.Add(this.txtHizmetinAdi);
            this.tabPage2.Controls.Add(this.lblDegisiklikYapilacakTablo);
            this.tabPage2.Controls.Add(this.cmbDegisiklikYapilacakVeriSecimi);
            this.tabPage2.Controls.Add(this.txtMusteriTelefonu);
            this.tabPage2.Controls.Add(this.txtMusteriAdiSoyadi);
            this.tabPage2.Controls.Add(this.lblDegisenDetay);
            this.tabPage2.Controls.Add(this.lblDegisenAd);
            this.tabPage2.Controls.Add(this.cmbDegisiklikYapilacakTablo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Değişiklik Yap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDegisiklikYapTablosu
            // 
            this.dgvDegisiklikYapTablosu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDegisiklikYapTablosu.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDegisiklikYapTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDegisiklikYapTablosu.Location = new System.Drawing.Point(1, 180);
            this.dgvDegisiklikYapTablosu.Name = "dgvDegisiklikYapTablosu";
            this.dgvDegisiklikYapTablosu.Size = new System.Drawing.Size(326, 201);
            this.dgvDegisiklikYapTablosu.TabIndex = 12;
            // 
            // txtAracinUcretFarki
            // 
            this.txtAracinUcretFarki.Location = new System.Drawing.Point(107, 127);
            this.txtAracinUcretFarki.Name = "txtAracinUcretFarki";
            this.txtAracinUcretFarki.Size = new System.Drawing.Size(211, 20);
            this.txtAracinUcretFarki.TabIndex = 11;
            this.txtAracinUcretFarki.Text = "0";
            // 
            // txtAracınTipi
            // 
            this.txtAracınTipi.Location = new System.Drawing.Point(107, 90);
            this.txtAracınTipi.Name = "txtAracınTipi";
            this.txtAracınTipi.Size = new System.Drawing.Size(211, 20);
            this.txtAracınTipi.TabIndex = 10;
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(8, 192);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(0, 13);
            this.lblMusteriID.TabIndex = 9;
            // 
            // btn_DegisikKaydet
            // 
            this.btn_DegisikKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DegisikKaydet.Location = new System.Drawing.Point(66, 400);
            this.btn_DegisikKaydet.Name = "btn_DegisikKaydet";
            this.btn_DegisikKaydet.Size = new System.Drawing.Size(181, 30);
            this.btn_DegisikKaydet.TabIndex = 8;
            this.btn_DegisikKaydet.Text = "Değişiklikleri Kaydet";
            this.btn_DegisikKaydet.UseVisualStyleBackColor = true;
            this.btn_DegisikKaydet.Click += new System.EventHandler(this.btn_DegisiklikleriKaydet_Click);
            // 
            // txtHizmetinUcreti
            // 
            this.txtHizmetinUcreti.Location = new System.Drawing.Point(107, 127);
            this.txtHizmetinUcreti.Name = "txtHizmetinUcreti";
            this.txtHizmetinUcreti.Size = new System.Drawing.Size(211, 20);
            this.txtHizmetinUcreti.TabIndex = 7;
            this.txtHizmetinUcreti.Text = "0";
            // 
            // txtHizmetinAdi
            // 
            this.txtHizmetinAdi.Location = new System.Drawing.Point(107, 90);
            this.txtHizmetinAdi.Name = "txtHizmetinAdi";
            this.txtHizmetinAdi.Size = new System.Drawing.Size(211, 20);
            this.txtHizmetinAdi.TabIndex = 6;
            // 
            // lblDegisiklikYapilacakTablo
            // 
            this.lblDegisiklikYapilacakTablo.AutoSize = true;
            this.lblDegisiklikYapilacakTablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegisiklikYapilacakTablo.Location = new System.Drawing.Point(8, 54);
            this.lblDegisiklikYapilacakTablo.Name = "lblDegisiklikYapilacakTablo";
            this.lblDegisiklikYapilacakTablo.Size = new System.Drawing.Size(70, 16);
            this.lblDegisiklikYapilacakTablo.TabIndex = 5;
            this.lblDegisiklikYapilacakTablo.Text = "Müşteri : ";
            // 
            // cmbDegisiklikYapilacakVeriSecimi
            // 
            this.cmbDegisiklikYapilacakVeriSecimi.FormattingEnabled = true;
            this.cmbDegisiklikYapilacakVeriSecimi.Location = new System.Drawing.Point(107, 53);
            this.cmbDegisiklikYapilacakVeriSecimi.Name = "cmbDegisiklikYapilacakVeriSecimi";
            this.cmbDegisiklikYapilacakVeriSecimi.Size = new System.Drawing.Size(211, 21);
            this.cmbDegisiklikYapilacakVeriSecimi.TabIndex = 4;
            this.cmbDegisiklikYapilacakVeriSecimi.SelectedIndexChanged += new System.EventHandler(this.cmb_DegisiklikSecim_SelectedIndexChanged);
            // 
            // txtMusteriTelefonu
            // 
            this.txtMusteriTelefonu.Location = new System.Drawing.Point(107, 127);
            this.txtMusteriTelefonu.Name = "txtMusteriTelefonu";
            this.txtMusteriTelefonu.Size = new System.Drawing.Size(211, 20);
            this.txtMusteriTelefonu.TabIndex = 3;
            this.txtMusteriTelefonu.Text = "0";
            // 
            // txtMusteriAdiSoyadi
            // 
            this.txtMusteriAdiSoyadi.Location = new System.Drawing.Point(107, 90);
            this.txtMusteriAdiSoyadi.Name = "txtMusteriAdiSoyadi";
            this.txtMusteriAdiSoyadi.Size = new System.Drawing.Size(211, 20);
            this.txtMusteriAdiSoyadi.TabIndex = 2;
            // 
            // lblDegisenDetay
            // 
            this.lblDegisenDetay.AutoSize = true;
            this.lblDegisenDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegisenDetay.Location = new System.Drawing.Point(8, 126);
            this.lblDegisenDetay.Name = "lblDegisenDetay";
            this.lblDegisenDetay.Size = new System.Drawing.Size(67, 15);
            this.lblDegisenDetay.TabIndex = 1;
            this.lblDegisenDetay.Text = "Telefon : ";
            // 
            // lblDegisenAd
            // 
            this.lblDegisenAd.AutoSize = true;
            this.lblDegisenAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegisenAd.Location = new System.Drawing.Point(8, 91);
            this.lblDegisenAd.Name = "lblDegisenAd";
            this.lblDegisenAd.Size = new System.Drawing.Size(87, 15);
            this.lblDegisenAd.TabIndex = 1;
            this.lblDegisenAd.Text = "Ad - Soyad : ";
            // 
            // cmbDegisiklikYapilacakTablo
            // 
            this.cmbDegisiklikYapilacakTablo.FormattingEnabled = true;
            this.cmbDegisiklikYapilacakTablo.Items.AddRange(new object[] {
            "Müşteri Bilgileri",
            "Hizmet Tipleri",
            "Araç Tipleri"});
            this.cmbDegisiklikYapilacakTablo.Location = new System.Drawing.Point(8, 15);
            this.cmbDegisiklikYapilacakTablo.Name = "cmbDegisiklikYapilacakTablo";
            this.cmbDegisiklikYapilacakTablo.Size = new System.Drawing.Size(310, 21);
            this.cmbDegisiklikYapilacakTablo.TabIndex = 0;
            this.cmbDegisiklikYapilacakTablo.SelectedIndexChanged += new System.EventHandler(this.cmbDegisiklik_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEkleme);
            this.tabPage1.Controls.Add(this.cmbEklemeYapilacakTablo);
            this.tabPage1.Controls.Add(this.btnEkleneniKaydet);
            this.tabPage1.Controls.Add(this.txtMusteriTelefon);
            this.tabPage1.Controls.Add(this.txtHizmetUcreti);
            this.tabPage1.Controls.Add(this.LblEklemeSayi);
            this.tabPage1.Controls.Add(this.txtMusteriAdi);
            this.tabPage1.Controls.Add(this.txtHizmetAdi);
            this.tabPage1.Controls.Add(this.lblEklemeAdı);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(329, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ekleme Yap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEkleme
            // 
            this.dgvEkleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEkleme.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEkleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEkleme.Location = new System.Drawing.Point(0, 180);
            this.dgvEkleme.Name = "dgvEkleme";
            this.dgvEkleme.Size = new System.Drawing.Size(326, 201);
            this.dgvEkleme.TabIndex = 13;
            // 
            // cmbEkleme
            // 
            this.cmbEklemeYapilacakTablo.FormattingEnabled = true;
            this.cmbEklemeYapilacakTablo.Items.AddRange(new object[] {
            "Müşteri",
            "Hizmet"});
            this.cmbEklemeYapilacakTablo.Location = new System.Drawing.Point(13, 19);
            this.cmbEklemeYapilacakTablo.Name = "cmbEkleme";
            this.cmbEklemeYapilacakTablo.Size = new System.Drawing.Size(307, 21);
            this.cmbEklemeYapilacakTablo.TabIndex = 4;
            this.cmbEklemeYapilacakTablo.SelectedIndexChanged += new System.EventHandler(this.cmbEkleme_SelectedIndexChanged);
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(118, 93);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(202, 20);
            this.txtMusteriTelefon.TabIndex = 2;
            // 
            // txtMusteriAdi
            // 
            this.txtMusteriAdi.Location = new System.Drawing.Point(118, 59);
            this.txtMusteriAdi.Name = "txtMusteriAdi";
            this.txtMusteriAdi.Size = new System.Drawing.Size(202, 20);
            this.txtMusteriAdi.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnSil);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cmbTabloVerisiAdi);
            this.tabPage3.Controls.Add(this.cmbTabloSecimi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(329, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sil";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(66, 400);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(181, 28);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bölümü : ";
            // 
            // cmbTabloVerisiAdi
            // 
            this.cmbTabloVerisiAdi.FormattingEnabled = true;
            this.cmbTabloVerisiAdi.Location = new System.Drawing.Point(80, 56);
            this.cmbTabloVerisiAdi.Name = "cmbTabloVerisiAdi";
            this.cmbTabloVerisiAdi.Size = new System.Drawing.Size(236, 21);
            this.cmbTabloVerisiAdi.TabIndex = 1;
            // 
            // cmbTabloSecimi
            // 
            this.cmbTabloSecimi.FormattingEnabled = true;
            this.cmbTabloSecimi.Items.AddRange(new object[] {
            "Müşteri ",
            "Hizmet Tipi "});
            this.cmbTabloSecimi.Location = new System.Drawing.Point(80, 21);
            this.cmbTabloSecimi.Name = "cmbTabloSecimi";
            this.cmbTabloSecimi.Size = new System.Drawing.Size(236, 21);
            this.cmbTabloSecimi.TabIndex = 0;
            this.cmbTabloSecimi.SelectedIndexChanged += new System.EventHandler(this.cmbSilinecekTabloSecimi_SelectedIndexChanged);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegisiklikYapTablosu)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEkleme)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtHizmetAdi;
        private System.Windows.Forms.Button btnEkleneniKaydet;
        private System.Windows.Forms.Label lblEklemeAdı;
        private System.Windows.Forms.TextBox txtHizmetUcreti;
        private System.Windows.Forms.Label LblEklemeSayi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbDegisiklikYapilacakTablo;
        private System.Windows.Forms.TextBox txtMusteriTelefonu;
        private System.Windows.Forms.TextBox txtMusteriAdiSoyadi;
        private System.Windows.Forms.Label lblDegisenDetay;
        private System.Windows.Forms.Label lblDegisenAd;
        private System.Windows.Forms.Label lblDegisiklikYapilacakTablo;
        private System.Windows.Forms.ComboBox cmbDegisiklikYapilacakVeriSecimi;
        private System.Windows.Forms.TextBox txtHizmetinUcreti;
        private System.Windows.Forms.TextBox txtHizmetinAdi;
        private System.Windows.Forms.Button btn_DegisikKaydet;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbTabloSecimi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTabloVerisiAdi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAracinUcretFarki;
        private System.Windows.Forms.TextBox txtAracınTipi;
        private System.Windows.Forms.DataGridView dgvDegisiklikYapTablosu;
        private System.Windows.Forms.ComboBox cmbEklemeYapilacakTablo;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.DataGridView dgvEkleme;
    }
}