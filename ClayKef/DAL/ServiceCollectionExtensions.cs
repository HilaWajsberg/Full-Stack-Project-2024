using DAL.DALApi;
using DAL.DALImplementation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection collection)
        {
            //collection.AddSingleton<IDataContext, DataContext>();
            collection.AddSingleton<ICourseRepo, CourseRepo>();
            

        }
    }
}
