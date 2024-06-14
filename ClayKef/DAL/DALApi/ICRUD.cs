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
        Task<T> Get(int id);
        T Post(T entity);
        Task<T> Delete(int id);
        T Put(T entity);  
        
    }
}
