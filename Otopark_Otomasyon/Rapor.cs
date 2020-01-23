using Otopark_Otomasyon.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SQLite;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace Otopark_Otomasyon
{
    public partial class Rapor : Form
    {
        #region Variables Declaration
        ArabaModelRepository arabaModelRepository = new ArabaModelRepository();
        ArabaTipRepository arabaTipRepository = new ArabaTipRepository();
        HizmetTipRepository hizmetTipRepository = new HizmetTipRepository();
        MusteriRepository musteriBilgileriRepository = new MusteriRepository();
        HizmetRepository hizmetBilgileriRepository = new HizmetRepository();
        ArabaRepository arabaBilgileriRepository = new ArabaRepository();
        #endregion
        public Rapor()
        {
            InitializeComponent();
        }
        private void Rapor_Load(object sender, EventArgs e)
        {
            //DataGrid Doldur.
            List<Hizmet> hizmetBilgisi = hizmetBilgileriRepository.Select();

            dgvRapor.DataSource = hizmetBilgisi;

            btnSorgulaWithDate_Click(null, null);

        }
        private void selectDataFromDb()
        {

        }

        #region Date condition
        private void dtpDateBegin_ValueChanged(object sender, EventArgs e)
        {
            var chosenDate = dtpDateBegin.Value;

            if (chosenDate.Year == DateTime.Now.Year && chosenDate.Month > DateTime.Now.Month)
            {
                MessageBox.Show("Başlangıç tarihi bu günden ilerideki bir tarih olamaz!");
                dtpDateBegin.Value = DateTime.Now;
            }
            else if (chosenDate.Year == DateTime.Now.Year && chosenDate.Month == DateTime.Now.Month && chosenDate.Day > DateTime.Now.Day)
            {
                MessageBox.Show("Başlangıç tarihi bu günden ilerideki bir tarih olamaz!");
                dtpDateBegin.Value = DateTime.Now;

            }
            else if (chosenDate.Year > DateTime.Now.Year)
            {
                MessageBox.Show("Başlangıç tarihi bu günden ilerideki bir tarih olamaz!");
                dtpDateBegin.Value = DateTime.Now;

            }
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            var chosenDate = dtpDateEnd.Value;

            if (chosenDate.Year == dtpDateBegin.Value.Year && chosenDate.Month < dtpDateBegin.Value.Month)
            {
                MessageBox.Show("Başlangıç tarihi bu günden ilerideki bir tarih olamaz!");
                dtpDateEnd.Value = DateTime.Now;
            }

            else if (chosenDate.Year < dtpDateBegin.Value.Year)
            {
                MessageBox.Show("Başlangıç tarihi bu günden ilerideki bir tarih olamaz!");
                dtpDateEnd.Value = DateTime.Now;

            }
        }


        #endregion

        #region Box Operations 

        private void cbMusteriAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbMusteriAdi.Checked)
            { dgvRapor.Columns["musteriAdi"].Visible = false; }
            else
                dgvRapor.Columns["musteriAdi"].Visible = true;

        }

        private void cbArabaModeli_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbArabaModeli.Checked)
            { dgvRapor.Columns["arabaAdi"].Visible = false; }
            else
                dgvRapor.Columns["arabaAdi"].Visible = true;
        }

        private void cbHizmetAdi_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbHizmetAdi.Checked)
            { dgvRapor.Columns["HizmetAdi"].Visible = false; }
            else
                dgvRapor.Columns["HizmetAdi"].Visible = true;
        }

        private void cbOdemeTipi_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbOdemeTipi.Checked)
            { dgvRapor.Columns["OdemeTipi"].Visible = false; }
            else
                dgvRapor.Columns["OdemeTipi"].Visible = true;
        }

        private void cbUcret_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbUcret.Checked)
            { dgvRapor.Columns["Ucret"].Visible = false; }
            else
                dgvRapor.Columns["Ucret"].Visible = true;
        }

        private void cbTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbTarih.Checked)
            { dgvRapor.Columns["Tarih"].Visible = false; }
            else
                dgvRapor.Columns["Tarih"].Visible = true;
        }

        #endregion

        #region Add To Excell Operations 
        private void copyAlltoClipboard()
        {
            dgvRapor.SelectAll();
            DataObject dataObj = dgvRapor.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
        private void btnDataCiktisiAl_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
        #endregion

        private void btnSorgulaWithDate_Click(object sender, EventArgs e)
        {
            DateTime datenBegin = dtpDateBegin.Value;
            DateTime dateEnd = dtpDateEnd.Value;
            dateEnd = dateEnd.AddDays(1);

            //Where tarih sorgusu yarat
            string query = $@"SELECT
                                       h.*,
                                       ht.hizmetadi as hizmetAdi,
                                       i.isim as musteriAdi,
                                       am.ad as arabaAdi
                                       
                               FROM hizmetler h
                               Inner Join arac_modelleri am on am.id = h.arabaId
                               Inner Join hizmet_tipi ht on ht.id = h.hizmetTipiId
                               Inner Join insan i on i.id = h.musteriId
                               WHERE tarih >= '{datenBegin.ToString("yyyy-MM-dd")}' AND tarih <= '{dateEnd.ToString("yyyy-MM-dd")}'";

            dgvRapor.DataSource = null;

            var cmd = new SQLiteCommand(query);
            var dt = Utilty.RunDataReader(cmd);

            dgvRapor.DataSource = dt;

            //ID'leri Gizle
            this.dgvRapor.Columns["id"].Visible = false;
            this.dgvRapor.Columns["ArabaId"].Visible = false;
            this.dgvRapor.Columns["MusteriId"].Visible = false;
            this.dgvRapor.Columns["HizmetTipiId"].Visible = false;

            //Kazanç Hesapla
            List<Hizmet> hizmetBilgileri = hizmetBilgileriRepository.Select();
            cmbToplamUcret.DataSource = dt;
            cmbToplamUcret.DisplayMember = "ucret";

            decimal toplamUcret = 0;
            for (int i = 0; i < cmbToplamUcret.Items.Count; i++)
            {
                cmbToplamUcret.SelectedIndex = i;
                toplamUcret += Convert.ToDecimal(((DataRowView)cmbToplamUcret.SelectedValue)["ucret"]);
            }

            lblToplamUcret.Text = toplamUcret.ToString() + " TL";
        }
    }
}
