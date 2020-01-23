using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public class HizmetRepository : IRepository<Hizmet>
    {
        public bool Delete(int id)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "DELETE FROM hizmetler WHERE id=@id",
            };
            command.Parameters.AddWithValue("@id", id);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public Hizmet Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Hizmet entity)
        {

            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "INSERT INTO hizmetler (ArabaId,HizmetTipiId,MusteriId,Tarih,OdemeTipi,Ucret) values (@ArabaId,@HizmetTipiId,@MusteriId,@Tarih,@OdemeTipi,@Ucret)",

            };

            command.Parameters.AddWithValue("@ArabaId", entity.ArabaId);
            command.Parameters.AddWithValue("@HizmetTipiId", entity.HizmetTipiId);
            command.Parameters.AddWithValue("@MusteriId", entity.MusteriId);

            command.Parameters.AddWithValue("@Tarih", entity.Tarih);
            command.Parameters.AddWithValue("@OdemeTipi", entity.OdemeTipi);
            command.Parameters.AddWithValue("@Ucret", entity.Ucret);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public List<Hizmet> Select()
        {
            List<Hizmet> list = new List<Hizmet>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = @"SELECT 
                                       h.*, 
                                       am.ad as arabaAdi,
                                       ht.hizmetadi as hizmetAdi,
                                       i.isim as musteriAdi
                               FROM hizmetler h
                               Left Join arac_modelleri am on am.id = h.arabaId
                               Left Join hizmet_tipi ht on ht.id = h.hizmetTipiId
                               Left Join insan i on i.id = h.musteriId",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new Hizmet
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["id"]),
                       ArabaId = Convert.ToInt32(dt.Rows[i]["arabaId"]),
                       HizmetTipiId = Convert.ToInt32(dt.Rows[i]["hizmetTipiId"]),
                       MusteriId = Convert.ToInt32(dt.Rows[i]["musteriId"]),
                       OdemeTipi = dt.Rows[i]["odemeTipi"].ToString(),
                       Ucret = Convert.ToInt32(dt.Rows[i]["ucret"]),
                       Tarih = Convert.ToDateTime(dt.Rows[i]["tarih"]),
                       Isim = dt.Rows[i]["musteriAdi"].ToString(),
                       Ad = dt.Rows[i]["arabaAdi"].ToString(),
                       HizmetAdi = dt.Rows[i]["hizmetAdi"].ToString(),

                   }
               );
            }
            return list;
        }

        public bool Update(Hizmet entity)
        {
            throw new NotImplementedException();
        }
    }
}