namespace Otopark_Otomasyon
{
    partial class Rapor
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
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.dtpDateBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMusteriAdi = new System.Windows.Forms.CheckBox();
            this.cbArabaModeli = new System.Windows.Forms.CheckBox();
            this.cbHizmetAdi = new System.Windows.Forms.CheckBox();
            this.cbOdemeTipi = new System.Windows.Forms.CheckBox();
            this.cbUcret = new System.Windows.Forms.CheckBox();
            this.cbTarih = new System.Windows.Forms.CheckBox();
            this.btnSorgulaTarihli = new System.Windows.Forms.Button();
            this.btnDataCiktisiAl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.cmbToplamUcret = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapor
            // 
            this.dgvRapor.AllowUserToOrderColumns = true;
            this.dgvRapor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRapor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRapor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRapor.Location = new System.Drawing.Point(0, 214);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvRapor.Size = new System.Drawing.Size(508, 297);
            this.dgvRapor.TabIndex = 9;
            // 
            // dtpDateBegin
            // 
            this.dtpDateBegin.Location = new System.Drawing.Point(23, 45);
            this.dtpDateBegin.Name = "dtpDateBegin";
            this.dtpDateBegin.Size = new System.Drawing.Size(174, 20);
            this.dtpDateBegin.TabIndex = 0;
            this.dtpDateBegin.Value = new System.DateTime(2018, 7, 6, 0, 0, 0, 0);
            this.dtpDateBegin.ValueChanged += new System.EventHandler(this.dtpDateBegin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tarih aralığını belirleyiniz.";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Location = new System.Drawing.Point(23, 72);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(174, 20);
            this.dtpDateEnd.TabIndex = 1;
            this.dtpDateEnd.Value = new System.DateTime(2018, 7, 6, 17, 1, 43, 0);
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Raporlanmasını istediğiniz değerleri seçiniz.";
            // 
            // cbMusteriAdi
            // 
            this.cbMusteriAdi.AutoSize = true;
            this.cbMusteriAdi.Checked = true;
            this.cbMusteriAdi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMusteriAdi.Location = new System.Drawing.Point(23, 167);
            this.cbMusteriAdi.Name = "cbMusteriAdi";
            this.cbMusteriAdi.Size = new System.Drawing.Size(78, 17);
            this.cbMusteriAdi.TabIndex = 3;
            this.cbMusteriAdi.Text = "Müşteri Adı";
            this.cbMusteriAdi.UseVisualStyleBackColor = true;
            this.cbMusteriAdi.CheckedChanged += new System.EventHandler(this.cbMusteriAdi_CheckedChanged);
            // 
            // cbArabaModeli
            // 
            this.cbArabaModeli.AutoSize = true;
            this.cbArabaModeli.Checked = true;
            this.cbArabaModeli.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbArabaModeli.Location = new System.Drawing.Point(23, 190);
            this.cbArabaModeli.Name = "cbArabaModeli";
            this.cbArabaModeli.Size = new System.Drawing.Size(88, 17);
            this.cbArabaModeli.TabIndex = 6;
            this.cbArabaModeli.Text = "Araba Modeli";
            this.cbArabaModeli.UseVisualStyleBackColor = true;
            this.cbArabaModeli.CheckedChanged += new System.EventHandler(this.cbArabaModeli_CheckedChanged);
            // 
            // cbHizmetAdi
            // 
            this.cbHizmetAdi.AutoSize = true;
            this.cbHizmetAdi.Checked = true;
            this.cbHizmetAdi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHizmetAdi.Location = new System.Drawing.Point(213, 167);
            this.cbHizmetAdi.Name = "cbHizmetAdi";
            this.cbHizmetAdi.Size = new System.Drawing.Size(76, 17);
            this.cbHizmetAdi.TabIndex = 4;
            this.cbHizmetAdi.Text = "Hizmet Adı";
            this.cbHizmetAdi.UseVisualStyleBackColor = true;
            this.cbHizmetAdi.CheckedChanged += new System.EventHandler(this.cbHizmetAdi_CheckedChanged);
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.AutoSize = true;
            this.cbOdemeTipi.Checked = true;
            this.cbOdemeTipi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOdemeTipi.Location = new System.Drawing.Point(401, 167);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(80, 17);
            this.cbOdemeTipi.TabIndex = 5;
            this.cbOdemeTipi.Text = "Ödeme Tipi";
            this.cbOdemeTipi.UseVisualStyleBackColor = true;
            this.cbOdemeTipi.CheckedChanged += new System.EventHandler(this.cbOdemeTipi_CheckedChanged);
            // 
            // cbUcret
            // 
            this.cbUcret.AutoSize = true;
            this.cbUcret.Checked = true;
            this.cbUcret.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUcret.Location = new System.Drawing.Point(403, 190);
            this.cbUcret.Name = "cbUcret";
            this.cbUcret.Size = new System.Drawing.Size(52, 17);
            this.cbUcret.TabIndex = 8;
            this.cbUcret.Text = "Ücret";
            this.cbUcret.UseVisualStyleBackColor = true;
            this.cbUcret.CheckedChanged += new System.EventHandler(this.cbUcret_CheckedChanged);
            // 
            // cbTarih
            // 
            this.cbTarih.AutoSize = true;
            this.cbTarih.Checked = true;
            this.cbTarih.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTarih.Location = new System.Drawing.Point(213, 190);
            this.cbTarih.Name = "cbTarih";
            this.cbTarih.Size = new System.Drawing.Size(50, 17);
            this.cbTarih.TabIndex = 7;
            this.cbTarih.Text = "Tarih";
            this.cbTarih.UseVisualStyleBackColor = true;
            this.cbTarih.CheckedChanged += new System.EventHandler(this.cbTarih_CheckedChanged);
            // 
            // btnSorgulaTarihli
            // 
            this.btnSorgulaTarihli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgulaTarihli.Location = new System.Drawing.Point(23, 98);
            this.btnSorgulaTarihli.Name = "btnSorgulaTarihli";
            this.btnSorgulaTarihli.Size = new System.Drawing.Size(174, 22);
            this.btnSorgulaTarihli.TabIndex = 2;
            this.btnSorgulaTarihli.Text = "Sorgula";
            this.btnSorgulaTarihli.UseVisualStyleBackColor = true;
            this.btnSorgulaTarihli.Click += new System.EventHandler(this.btnSorgulaWithDate_Click);
            // 
            // btnDataCiktisiAl
            // 
            this.btnDataCiktisiAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDataCiktisiAl.Location = new System.Drawing.Point(274, 98);
            this.btnDataCiktisiAl.Name = "btnDataCiktisiAl";
            this.btnDataCiktisiAl.Size = new System.Drawing.Size(174, 22);
            this.btnDataCiktisiAl.TabIndex = 10;
            this.btnDataCiktisiAl.Text = "Cikti Al";
            this.btnDataCiktisiAl.UseVisualStyleBackColor = true;
            this.btnDataCiktisiAl.Click += new System.EventHandler(this.btnDataCiktisiAl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(265, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarihler arasındaki kazanç";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.Location = new System.Drawing.Point(330, 51);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(51, 24);
            this.lblToplamUcret.TabIndex = 11;
            this.lblToplamUcret.Text = "0 TL";
            // 
            // cmbToplamUcret
            // 
            this.cmbToplamUcret.FormattingEnabled = true;
            this.cmbToplamUcret.Location = new System.Drawing.Point(393, 56);
            this.cmbToplamUcret.Name = "cmbToplamUcret";
            this.cmbToplamUcret.Size = new System.Drawing.Size(10, 21);
            this.cmbToplamUcret.TabIndex = 12;
            this.cmbToplamUcret.Visible = false;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 511);
            this.Controls.Add(this.cmbToplamUcret);
            this.Controls.Add(this.lblToplamUcret);
            this.Controls.Add(this.btnDataCiktisiAl);
            this.Controls.Add(this.btnSorgulaTarihli);
            this.Controls.Add(this.cbTarih);
            this.Controls.Add(this.cbUcret);
            this.Controls.Add(this.cbOdemeTipi);
            this.Controls.Add(this.cbHizmetAdi);
            this.Controls.Add(this.cbArabaModeli);
            this.Controls.Add(this.cbMusteriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateBegin);
            this.Controls.Add(this.dgvRapor);
            this.Name = "Rapor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpDateBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbMusteriAdi;
        private System.Windows.Forms.CheckBox cbArabaModeli;
        private System.Windows.Forms.CheckBox cbHizmetAdi;
        private System.Windows.Forms.CheckBox cbOdemeTipi;
        private System.Windows.Forms.CheckBox cbUcret;
        private System.Windows.Forms.CheckBox cbTarih;
        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Button btnSorgulaTarihli;
        private System.Windows.Forms.Button btnDataCiktisiAl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.ComboBox cmbToplamUcret;
    }
}