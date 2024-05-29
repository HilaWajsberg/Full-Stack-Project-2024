using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALApi
{
    public interface ICRUD<T>
    {
        List<T> GetAll(BaseQueryParams queryParams);
        List<T> Get(BaseQueryParams queryParams);
        T Post(T entity);
        T Delete(int id);
        T Put(T entity);  
        
    }
}
