using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public class ArabaTipRepository : IRepository<ArabaTip>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ArabaTip Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ArabaTip entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "INSERT INTO arac_tipi (ad) values (@ad)",

            };

            command.Parameters.AddWithValue("@ad", entity.Ad);
            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public List<ArabaTip> Select()
        {
            List<ArabaTip> list = new List<ArabaTip>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM arac_tipi",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new ArabaTip
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["id"]),
                       Ad = dt.Rows[i]["ad"].ToString(),
                       ucretFarki = Convert.ToInt32(dt.Rows[i]["ucretFarki"])
                   }
               );

            }

            return list;
        }

        public bool Update(ArabaTip entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "UPDATE arac_tipi SET ucretFarki = @ucretFarki, Ad =@Ad WHERE id=@id ",

            };

            command.Parameters.AddWithValue("@id", entity.Id);
            command.Parameters.AddWithValue("@Ad", entity.Ad);
            command.Parameters.AddWithValue("@ucretFarki", entity.ucretFarki);

            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }
    }
}
