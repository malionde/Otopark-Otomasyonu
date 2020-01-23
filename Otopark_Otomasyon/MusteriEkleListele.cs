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
    public partial class MusteriEkleListele : Form
    {
        MusteriRepository musteriBilgileriRepository = new MusteriRepository();

        public MusteriEkleListele()
        {
            InitializeComponent();
        }

        private void btnMusteriyiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri entity = new Musteri
                {
                    isim = txtAdiSoyadi.Text,
                    telefon = Convert.ToDecimal(txtTelefon.Text)
                };
                bool result = musteriBilgileriRepository.Insert(entity);
                if (result)
                {
                    MessageBox.Show("Ekleme Başarılı!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Başarısız!");
                throw ex;
            }
        }

        private void MüşteriEkleListele_Load(object sender, EventArgs e)
        {
            List<Musteri> must = musteriBilgileriRepository.Select();
            dgvMusteriler.DataSource = must;
            this.dgvMusteriler.Columns["id"].Visible = false;

        }
    }
}
