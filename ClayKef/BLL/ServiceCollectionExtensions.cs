using BLL.BLLApi;
using BLL.BLLImplementation;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{


    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection collection)
        {
            collection.AddSingleton<IUICourseService, UICourseService>();
           
           /* collection.AddAutoMapper(typeof(PassengerProfile), typeof(FlightProfile),
                typeof(PersonalDetailsProfile), typeof(PassengerWithFlightProfile));*/

            //collection.AddRepositories(config);
            collection.AddRepositories();
            return collection;
        }
    }



}
