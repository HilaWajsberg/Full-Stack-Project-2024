using BLL.BLLModels;
using Common;
using DAL.DALApi;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation
{
    public class UIDuratioService
    {
        IDurationRepo durationRepo;

        public UIDuratioService(IDurationRepo durationRepo)
        {
            this.durationRepo = durationRepo;
        }
        public List<UIDuration> GetAllDurations(BaseQueryParams queryParams)
        {
            var durationParams = queryParams as LevelParams;
            List<Duration> durationTask = durationRepo.GetAll(queryParams);
            var DurationList = new List<UIDuration>();
            foreach (var duration in durationTask)
            {
                UIDuration newDuration = new UIDuration();
                newDuration.Code = duration.Code;
                newDuration.Type = duration.Type;
                DurationList.Add(newDuration);
            }
            var queryable = DurationList.AsQueryable();
            if (durationParams.code > 0)
            {
                queryable = queryable.Where(c => c.Code == durationParams.code);
            }
            if (durationParams.type != null)
            {
                queryable = queryable.Where(c => c.Type == durationParams.type);
            }
            return queryable.ToList();
        }
    }
}
