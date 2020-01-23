using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyon
{
    public partial class AnaSayfa : Form
    {

        public AnaSayfa()
        {

            InitializeComponent();
        }

        private void btn_Odeme_Click(object sender, EventArgs e)
        {
            OdemeForm odeme = new OdemeForm();
            odeme.StartPosition = FormStartPosition.Manual;
            odeme.Left = 100;
            odeme.Top = 100;
            var res = odeme.ShowDialog();
            this.Show();
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.StartPosition = FormStartPosition.Manual;
            ayarlar.Left = 100;
            ayarlar.Top = 100;
            var res = ayarlar.ShowDialog();
            this.Show();
        }

        private void btn_Rapor_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.StartPosition = FormStartPosition.Manual;
            rapor.Left = 100;
            rapor.Top = 100;
            var res = rapor.ShowDialog();
            this.Show();
        }
    }
}
