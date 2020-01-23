using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Otopark_Otomasyon.BLL
{
    public class AdminRepository : IRepository<Admin>
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Admin Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Admin entity)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Select()
        {
            List<Admin> list = new List<Admin>();
            SQLiteCommand command = new SQLiteCommand
            {
                CommandText = "SELECT * FROM admin",

            };
            DataTable dt = Utilty.RunDataReader(command);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(
                   new Admin
                   {
                       Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                       Email = dt.Rows[i]["Email"].ToString(),
                       Password = dt.Rows[i]["Password"].ToString()

                   }
               );

            }

            return list;
        }

        public bool Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
