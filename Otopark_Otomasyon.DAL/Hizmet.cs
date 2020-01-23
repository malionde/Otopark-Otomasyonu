using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public class Hizmet
    {
        public int Id { get; set; }
        public int ArabaId { get; set; }
        public int HizmetTipiId { get; set; }
        public int MusteriId { get; set; }
        public string Isim { get; set; }
        public string Ad { get; set; }
        public string HizmetAdi { get; set; }
        public Decimal Ucret { get; set; }
        public string OdemeTipi { get; set; }
        public DateTime Tarih { get; set; }




    }
}
