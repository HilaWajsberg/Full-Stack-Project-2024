using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface ICRUD<T>
    {
        //Task<List<T>> GetAll();
        string GetAll();
    }
}
