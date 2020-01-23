using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


namespace Otopark_Otomasyon.BLL
{
    public class MusteriRepository : IRepository<Musteri>
    {
        public bool Delete(int id)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "DELETE FROM insan WHERE id=@id",
            };
            command.Parameters.AddWithValue("@id", id);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }



        public Musteri Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Musteri entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "INSERT INTO insan (isim,telefon) values (@isim,@telefon)",

            };

            command.Parameters.AddWithValue("@isim", entity.isim);
            command.Parameters.AddWithValue("@telefon", entity.telefon);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public List<Musteri> Select()
        {
            List<Musteri> list = new List<Musteri>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM insan ",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new Musteri
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["id"]),
                       isim = dt.Rows[i]["isim"].ToString(),
                       telefon = Convert.ToInt32(dt.Rows[i]["telefon"])
                   }
               );

            }

            return list;
        }

        public bool Update(Musteri entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "UPDATE insan SET telefon = @telefon, isim =@isim WHERE id=@id ",
                
            };

            command.Parameters.AddWithValue("@id", entity.Id);
            command.Parameters.AddWithValue("@telefon", entity.telefon);
            command.Parameters.AddWithValue("@isim", entity.isim);

            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }
    }
}



