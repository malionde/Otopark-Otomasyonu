using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public class ArabaModelRepository : IRepository<ArabaModel>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ArabaModel Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(ArabaModel entity)
        {
            throw new NotImplementedException();
        }

        public List<ArabaModel> Select()
        {
            List<ArabaModel> list = new List<ArabaModel>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM arac_modelleri",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new ArabaModel
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["id"]),
                       Ad = dt.Rows[i]["ad"].ToString()
                   }
               );

            } 
               
            return list;
        }

        public bool Update(ArabaModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
