using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public class HizmetTipRepository : IRepository<HizmetTip>
    {
        public bool Delete(int id)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "DELETE FROM hizmet_tipi WHERE id=@id",
            };
            command.Parameters.AddWithValue("@id", id);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public HizmetTip Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(HizmetTip entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "INSERT INTO hizmet_tipi (hizmetAdi,ucret) values (@hizmetAdi,@ucret)",

            };

            command.Parameters.AddWithValue("@hizmetAdi", entity.hizmetAdi);
            command.Parameters.AddWithValue("@ucret", entity.Ucret);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public List<HizmetTip> Select()
        {
            List<HizmetTip> list = new List<HizmetTip>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM hizmet_tipi",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new HizmetTip
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["id"]),
                       hizmetAdi = dt.Rows[i]["hizmetAdi"].ToString(),
                       Ucret = Convert.ToInt32(dt.Rows[i]["ucret"])
                   }
               );

            }

            return list;
        }

        public bool Update(HizmetTip entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "UPDATE hizmet_tipi SET Ucret = @Ucret, hizmetAdi =@hizmetAdi WHERE id=@id ",

            };

            command.Parameters.AddWithValue("@id", entity.Id);
            command.Parameters.AddWithValue("@hizmetAdi", entity.hizmetAdi);
            command.Parameters.AddWithValue("@Ucret", entity.Ucret);

            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }
    }
}



