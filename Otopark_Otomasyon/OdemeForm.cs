using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;

using System.ComponentModel;
using System.Collections.Generic;
using Otopark_Otomasyon.BLL;

namespace Otopark_Otomasyon
{
    public partial class OdemeForm : Form
    {
        #region Variables Declaration
        private Database db;

        ArabaModelRepository arabaModelRepository = new ArabaModelRepository();
        HizmetTipRepository hizmetTipRepository = new HizmetTipRepository();
        ArabaTipRepository arabaTipRepository = new ArabaTipRepository();
        MusteriRepository musteriBilgisiRepository = new MusteriRepository();
        HizmetRepository yapilanHizmetlerRepository = new HizmetRepository();
        ArabaRepository arabaBilgisiRepository = new ArabaRepository();

        List<Araba> arabaBilgileri;

        private String fileName;
        public int i = 0;
        private OdemeForm odeme;

        #endregion

        public OdemeForm()
        {
            db = new Database();
            InitializeComponent();
            arabaBilgileri = arabaBilgisiRepository.Select();
        }
        public OdemeForm(OdemeForm odeme)
        {
            this.odeme = odeme;
        }

        #region Control Operations 
        private void PlakaCheck(object sender, EventArgs e)
        {
            for (int i = 0; i < arabaBilgileri.Count; i++)
            {
                if (arabaBilgileri[i].Plaka == txt_Plaka.Text)
                {
                    cmbMusteriBilgileri.SelectedValue = arabaBilgileri[i].InsanId;
                    break;
                }

                else if (i == arabaBilgileri.Count - 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Plaka bilgileri herhangi bir müşteri ile eşleşmedi. Yeni müşteri kaydetmek ister misiniz?", "Dikkat!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MusteriEkleListele f3 = new MusteriEkleListele();
                        var res = f3.ShowDialog();
                        refreshpage();
                        int last = cmbMusteriBilgileri.Items.Count - 1;
                        cmbMusteriBilgileri.SelectedIndex = last;
                    }

                    else if (dialogResult == DialogResult.No)
                    {
                        cmbMusteriBilgileri.SelectedIndex = 0;
                    }
                }
            }
        }
        private void cmbItip_SelectedIndexChanged(object sender, EventArgs e)
        {
            int s1 = cmbIslemTipleri.SelectedIndex;
            int s2 = cmbAracTipleri.SelectedIndex;
            var result = UcretHesapla(s1, s2).ToString();
            lblTutarBilgisi.Text = result;
        }
        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            string suAnkiPlaka = txt_Plaka.Text.ToUpper();

            if (suAnkiPlaka.Length <= 7)
            {
                for (int i = 0; i < arabaBilgileri.Count; i++)
                {
                    if (arabaBilgileri[i].Plaka.StartsWith(suAnkiPlaka))
                    {
                        cmbMusteriBilgileri.SelectedValue = arabaBilgileri[i].InsanId;
                        break;
                    }
                }
            }
            else
            {
                // If does not exist, do you wanna add ? 
            }
        }
        private void refreshpage()
        {
            //ArabaModel
            List<ArabaModel> arabaModelIsımleri = arabaModelRepository.Select();
            cmbArabaModelleri.DataSource = arabaModelIsımleri;
            cmbArabaModelleri.DisplayMember = "Ad";
            cmbArabaModelleri.ValueMember = "Id";

            //ArabaTip
            List<ArabaTip> aTip = arabaTipRepository.Select();
            cmbAracTipleri.DataSource = aTip;
            cmbAracTipleri.DisplayMember = "Ad";
            cmbAracTipleri.ValueMember = "Id";

            //HizmetTip
            List<HizmetTip> htip = hizmetTipRepository.Select();
            cmbIslemTipleri.DataSource = htip;
            cmbIslemTipleri.DisplayMember = "Ad";
            cmbIslemTipleri.ValueMember = "Id";

            //Müşteri
            List<Musteri> must = musteriBilgisiRepository.Select();
            cmbMusteriBilgileri.DataSource = must;
            cmbMusteriBilgileri.DisplayMember = "isim";
            cmbMusteriBilgileri.ValueMember = "Id";

            //ÖdemeTip
            cmbOdemeTurleri.SelectedIndex = 0;
        }
        private void OdemeForm_Load(object sender, EventArgs e)
        {
            //ArabaModel
            List<ArabaModel> aModel = arabaModelRepository.Select();
            cmbArabaModelleri.DataSource = aModel;
            cmbArabaModelleri.DisplayMember = "Ad";
            cmbArabaModelleri.ValueMember = "Id";

            //ArabaTip
            List<ArabaTip> aTip = arabaTipRepository.Select();
            cmbAracTipleri.DataSource = aTip;
            cmbAracTipleri.DisplayMember = "Ad";
            cmbAracTipleri.ValueMember = "Id";

            //HizmetTip
            List<HizmetTip> htip = hizmetTipRepository.Select();
            cmbIslemTipleri.DataSource = htip;
            cmbIslemTipleri.DisplayMember = "hizmetAdi";
            cmbIslemTipleri.ValueMember = "Id";

            //Müşteri
            List<Musteri> must = musteriBilgisiRepository.Select();
            cmbMusteriBilgileri.DataSource = must;
            cmbMusteriBilgileri.DisplayMember = "isim";
            cmbMusteriBilgileri.ValueMember = "Id";

            //ÖdemeTip
            cmbOdemeTurleri.SelectedIndex = 0;
        }
        #endregion

        #region Calculate Operations 
        private decimal UcretHesapla(int islemtipi, int aracTipi)
        {
            List<ArabaTip> arabalar = arabaTipRepository.Select();
            List<HizmetTip> hizmet = hizmetTipRepository.Select();
            decimal result = 0;
            decimal aucret = 0;
            decimal iucret = 0;
            // aractipiId ve islemTipiId 'ye göre ücret hesaplaması yap

            for (int i = 0; i < arabalar.Count; i++)
            {
                if (arabalar[i].Id == aracTipi + 1)
                {
                    aucret = arabalar[i].ucretFarki;
                }
            }

            for (int i = 0; i < hizmet.Count; i++)
            {
                if (hizmet[i].Id == islemtipi + 1)
                {
                    iucret = hizmet[i].Ucret;
                }
            }

            return result = aucret + iucret;
        }
        #endregion

        #region DataBase Operations 
        public void SetDB()
        {
            //Bağlantıyı sağla
            string Otopark = "myDB.sqlite";
            SQLiteConnection.CreateFile(Otopark);
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + Otopark + ";Version=3;");
            conn.Open();

            // Tabloları oluştur.
            string sql = "create table araba (id INTEGER PRIMARY KEY, insanId int, model varchar(50), tip varchar(50), plaka varchar(10))";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "create table insan (id INTEGER PRIMARY KEY, isim varchar(50), telefon int)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "create table hizmet_tipi (id INTEGER PRIMARY KEY, ad varchar(50), telefon int)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "create table hizmetler (id INTEGER PRIMARY KEY,arabaId int, hizmetTipiId int, tarih datetime, odemeTipi varchar(20), ucret int)";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            sql = "create table parameters (id INTEGER PRIMARY KEY, [group] varchar(20),name varchar(20),value varchar(20))";
            command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();

            conn.Close();
        }
        private void setarabalar(object sender, EventArgs e)
        {
            try
            {
                Araba entity = new Araba
                {
                    Plaka = txt_Plaka.Text,
                    InsanId = (int)cmbMusteriBilgileri.SelectedValue,
                };

                bool result = arabaBilgisiRepository.Insert(entity);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnOdemeyiTamamla_Click(object sender, EventArgs e)
        {
            setarabalar(null, null);
            int musteriId = (int)cmbMusteriBilgileri.SelectedValue;
            int aracTipiId = (int)cmbAracTipleri.SelectedValue;

            try
            {
                Hizmet entity = new Hizmet
                {
                    ArabaId = (int)cmbArabaModelleri.SelectedValue,
                    Tarih = DateTime.Now,
                    OdemeTipi = cmbOdemeTurleri.SelectedItem.ToString(),
                    HizmetTipiId = (int)cmbIslemTipleri.SelectedValue,
                    MusteriId = (int)cmbMusteriBilgileri.SelectedValue,
                    Ucret = UcretHesapla(cmbIslemTipleri.SelectedIndex, cmbAracTipleri.SelectedIndex)
                };

                bool result = yapilanHizmetlerRepository.Insert(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Başarısız!");
                throw ex;
            }
        }

        #endregion
    }
}
