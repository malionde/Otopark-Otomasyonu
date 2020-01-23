using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Otomasyon.BLL
{
    public interface IRepository<T>
    {

        List<T> Select();
        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(int id);
        T Find(int id);
    }
}
