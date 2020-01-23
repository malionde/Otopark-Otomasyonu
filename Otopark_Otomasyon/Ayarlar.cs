using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otopark_Otomasyon.BLL;

namespace Otopark_Otomasyon
{
    public partial class Ayarlar : Form
    {
        HizmetTipRepository hizmetTipRepository = new HizmetTipRepository();
        MusteriRepository musteriBilgileriRepository = new MusteriRepository();
        ArabaTipRepository aracTipRepository = new ArabaTipRepository();

        public Ayarlar()
        {
            InitializeComponent();
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            List<Musteri> musteriBilgileri = musteriBilgileriRepository.Select();

            dgvDegisiklikYapTablosu.DataSource = musteriBilgileri;
            this.dgvDegisiklikYapTablosu.Columns["id"].Visible = false;

            cmbEklemeYapilacakTablo.SelectedIndex = 0;
            cmbDegisiklikYapilacakTablo.SelectedIndex = 0;
            cmbTabloSecimi.SelectedIndex = 0;
        }

        #region Change Operations 
        private void cmbDegisiklik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDegisiklikYapilacakTablo.Text == "Müşteri Bilgileri")
            {
                lblDegisiklikYapilacakTablo.Text = "Müşteri :";
                lblDegisenAd.Text = "Ad - Soyad :";
                lblDegisenDetay.Text = "Telefon :";
                txtMusteriTelefonu.Visible = true;
                txtMusteriAdiSoyadi.Visible = true;
                txtHizmetinAdi.Visible = false;
                txtHizmetinUcreti.Visible = false;
                txtAracınTipi.Visible = false;
                txtAracinUcretFarki.Visible = false;

                List<Musteri> must = musteriBilgileriRepository.Select();
                cmbDegisiklikYapilacakVeriSecimi.DataSource = must;
                cmbDegisiklikYapilacakVeriSecimi.DisplayMember = "isim";
                cmbDegisiklikYapilacakVeriSecimi.ValueMember = "Id";

                //Data Grid View Doldur.

                dgvDegisiklikYapTablosu.DataSource = must;
                this.dgvDegisiklikYapTablosu.Columns["id"].Visible = false;

            }
            else if (cmbDegisiklikYapilacakTablo.Text == "Hizmet Tipleri")
            {
                lblDegisiklikYapilacakTablo.Text = "Hizmet :";
                lblDegisenAd.Text = "Hizmet Adı :";
                lblDegisenDetay.Text = "Ücreti : ";
                txtMusteriTelefonu.Visible = false;
                txtMusteriAdiSoyadi.Visible = false;
                txtHizmetinAdi.Visible = true;
                txtHizmetinUcreti.Visible = true;
                txtAracınTipi.Visible = false;
                txtAracinUcretFarki.Visible = false;



                List<HizmetTip> htip = hizmetTipRepository.Select();
                cmbDegisiklikYapilacakVeriSecimi.DataSource = htip;
                cmbDegisiklikYapilacakVeriSecimi.DisplayMember = "hizmetAdi";
                cmbDegisiklikYapilacakVeriSecimi.ValueMember = "Id";

                //Data Grid View Doldur.
                dgvDegisiklikYapTablosu.DataSource = htip;
                this.dgvDegisiklikYapTablosu.Columns["id"].Visible = false;
            }
            else if (cmbDegisiklikYapilacakTablo.Text == "Araç Tipleri")
            {
                lblDegisiklikYapilacakTablo.Text = "Araç :";
                lblDegisenAd.Text = "Araç Adı :";
                lblDegisenDetay.Text = "Ücret Farkı : ";
                txtMusteriTelefonu.Visible = false;
                txtMusteriAdiSoyadi.Visible = false;
                txtHizmetinAdi.Visible = false;
                txtHizmetinUcreti.Visible = false;
                txtAracınTipi.Visible = true;
                txtAracinUcretFarki.Visible = true;

                List<ArabaTip> atip = aracTipRepository.Select();
                cmbDegisiklikYapilacakVeriSecimi.DataSource = atip;
                cmbDegisiklikYapilacakVeriSecimi.DisplayMember = "Ad";
                cmbDegisiklikYapilacakVeriSecimi.ValueMember = "Id";

                //Data Grid View Doldur.
                dgvDegisiklikYapTablosu.DataSource = atip;
                this.dgvDegisiklikYapTablosu.Columns["id"].Visible = false;
            }
        }
        private void cmb_DegisiklikSecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMusteriAdiSoyadi.Text = cmbDegisiklikYapilacakVeriSecimi.Text;

            //txtTelefon.Text = (cmbDegisiklikSecim.SelectedValue as Musteri).telefon.ToString();
            //txtDegisUcret.Text = (cmbDegisiklikSecim.SelectedValue as Hizmet).Ucret.ToString();

            txtHizmetinAdi.Text = cmbDegisiklikYapilacakVeriSecimi.Text;
            txtAracınTipi.Text = cmbDegisiklikYapilacakVeriSecimi.Text;

        }
        private void btn_DegisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDegisiklikYapilacakTablo.SelectedIndex == 0)
            {
                Musteri entity = new Musteri
                {
                    Id = Convert.ToInt32(cmbDegisiklikYapilacakVeriSecimi.SelectedValue),
                    isim = txtMusteriAdiSoyadi.Text,
                    telefon = Convert.ToDecimal(txtMusteriTelefonu.Text)
                };

                bool result = musteriBilgileriRepository.Update(entity);
                if (result)
                {
                    MessageBox.Show("Değişiklik Başarılı!");
                }

                List<Musteri> musteri = musteriBilgileriRepository.Select();
                cmbTabloVerisiAdi.DataSource = musteri;
                cmbTabloVerisiAdi.DisplayMember = "isim";
                cmbTabloVerisiAdi.ValueMember = "Id";

            }
            else if (cmbDegisiklikYapilacakTablo.SelectedIndex == 1)
            {
                HizmetTip entity = new HizmetTip
                {
                    Id = Convert.ToInt32(cmbDegisiklikYapilacakVeriSecimi.SelectedValue),
                    hizmetAdi = txtHizmetAdi.Text,
                    Ucret = Convert.ToDecimal(txtHizmetUcreti.Text)
                };
                bool result = hizmetTipRepository.Update(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                }
                List<HizmetTip> hizmetBilgileri = hizmetTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = hizmetBilgileri;
                cmbTabloVerisiAdi.DisplayMember = "Ad";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }
            else if (cmbDegisiklikYapilacakTablo.SelectedIndex == 2)
            {
                ArabaTip entity = new ArabaTip
                {
                    Id = Convert.ToInt32(cmbDegisiklikYapilacakVeriSecimi.SelectedValue),
                    Ad = txtAracınTipi.Text,
                    ucretFarki = Convert.ToInt16(txtAracinUcretFarki.Text)
                };
                bool result = aracTipRepository.Update(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                }
                List<ArabaTip> aracTip = aracTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = aracTip;
                cmbTabloVerisiAdi.DisplayMember = "Ad";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }


        }
        #endregion

        #region Add Operations 

        private void cmbEkleme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEklemeYapilacakTablo.Text == "Müşteri")
            {
                lblEklemeAdı.Text = "Müşteri Adı :";
                LblEklemeSayi.Text = "Telefon :";
                txtMusteriAdi.Visible = true;
                txtMusteriTelefon.Visible = true;
                txtHizmetAdi.Visible = false;
                txtHizmetUcreti.Visible = false;

                //Data Grid View Doldur.
                List<Musteri> must = musteriBilgileriRepository.Select();
                dgvEkleme.DataSource = must;
                this.dgvEkleme.Columns["id"].Visible = false;

            }
            else if (cmbEklemeYapilacakTablo.Text == "Hizmet")
            {
                lblEklemeAdı.Text = "Hizmet Adı :";
                LblEklemeSayi.Text = "Ücreti : ";
                txtMusteriAdi.Visible = false;
                txtMusteriTelefon.Visible = false;
                txtHizmetAdi.Visible = true;
                txtHizmetUcreti.Visible = true;

                //Data Grid View Doldur.
                List<HizmetTip> htip = hizmetTipRepository.Select();
                dgvEkleme.DataSource = htip;
                this.dgvEkleme.Columns["id"].Visible = false;
            }
        }
        private void btnEkleneniKaydet_Click(object sender, EventArgs e)
        {
            if (cmbEklemeYapilacakTablo.Text == "Müşteri")
            {
                Musteri entity = new Musteri
                {
                    isim = txtMusteriAdi.Text,
                    telefon = Convert.ToDecimal(txtMusteriTelefon.Text)
                };

                bool result = musteriBilgileriRepository.Insert(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                }
                List<Musteri> musteriBilgileri = musteriBilgileriRepository.Select();
                cmbTabloVerisiAdi.DataSource = musteriBilgileri;
                cmbTabloVerisiAdi.DisplayMember = "isim";
                cmbTabloVerisiAdi.ValueMember = "Id";

            }
            else if (cmbEklemeYapilacakTablo.Text == "Hizmet")
            {

                HizmetTip entity = new HizmetTip
                {
                    hizmetAdi = txtHizmetAdi.Text,
                    Ucret = Convert.ToDecimal(txtHizmetUcreti.Text)
                };

                bool result = hizmetTipRepository.Insert(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                }
                List<HizmetTip> hizmetBilgileri = hizmetTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = hizmetBilgileri;
                cmbTabloVerisiAdi.DisplayMember = "hizmetAdi";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }

        }
        #endregion

        #region Delete Operations  
        private void cmbSilinecekTabloSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTabloSecimi.SelectedIndex == 0)
            {
                List<Musteri> musteriBilgileri = musteriBilgileriRepository.Select();
                cmbTabloVerisiAdi.DataSource = musteriBilgileri;
                cmbTabloVerisiAdi.DisplayMember = "isim";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }
            else if (cmbTabloSecimi.SelectedIndex == 1)
            {
                List<HizmetTip> hizmetBilgileri = hizmetTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = hizmetBilgileri;
                cmbTabloVerisiAdi.DisplayMember = "hizmetAdi";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }
            else if (cmbTabloSecimi.SelectedIndex == 2)
            {
                List<ArabaTip> aracTip = aracTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = aracTip;
                cmbTabloVerisiAdi.DisplayMember = "Ad";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            bool result = false;

            if (cmbTabloSecimi.SelectedIndex == 0)
            {
                int selectedMusteriId = Convert.ToInt32(cmbTabloVerisiAdi.SelectedValue);
                result = musteriBilgileriRepository.Delete(selectedMusteriId);

                List<Musteri> musteri = musteriBilgileriRepository.Select();
                cmbTabloVerisiAdi.DataSource = musteri;
                cmbTabloVerisiAdi.DisplayMember = "isim";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }
            else if (cmbTabloSecimi.SelectedIndex == 1)
            {
                int selectedHizmetId = Convert.ToInt32(cmbTabloVerisiAdi.SelectedValue);
                result = hizmetTipRepository.Delete(selectedHizmetId);

                List<HizmetTip> hizmet = hizmetTipRepository.Select();
                cmbTabloVerisiAdi.DataSource = hizmet;
                cmbTabloVerisiAdi.DisplayMember = "Ad";
                cmbTabloVerisiAdi.ValueMember = "Id";
            }

            if (result)
            {
                MessageBox.Show("Silme Başarılı!");
            }

        }
        #endregion

    }
}