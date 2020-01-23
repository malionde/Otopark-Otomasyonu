using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
   public class ArabaRepository : IRepository<Araba>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Araba Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Araba entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "INSERT INTO araba (insanId,plaka) values (@insanId,@plaka)",

            };

            command.Parameters.AddWithValue("@insanId", entity.InsanId);
            command.Parameters.AddWithValue("@plaka", entity.Plaka);

            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }

        public List<Araba> Select()
        {
            List<Araba> list = new List<Araba>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM araba",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var row = dt.Rows[i];
                int insanId = -1;
                if (row["insanId"] != DBNull.Value)
                    insanId = Convert.ToInt32(dt.Rows[i]["insanId"]);

                list.Add(
                   new Araba
                   {
                       insanId = Convert.ToInt32(dt.Rows[i]["id"]),
                       InsanId = insanId,
                       //Model = dt.Rows[i]["model"].ToString(),
                       //Tip = dt.Rows[i]["tip"].ToString(),
                       Plaka = dt.Rows[i]["plaka"].ToString(),

                   }
               );

            }

            return list;
        }

        public bool Update(Araba entity)
        {
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "UPDATE araba SET model = @model, tip =@tip, plaka =@plaka, insanId=@insanId WHERE id=@id ",

            };

            command.Parameters.AddWithValue("@id", entity.insanId);
            command.Parameters.AddWithValue("@insanId", entity.insanId);
            command.Parameters.AddWithValue("@plaka", entity.Plaka);


            int result = Utilty.RunExecuteNonQuery(command);
            return result > 0;
        }
    }
}
