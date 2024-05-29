using Common;
using DAL.DALApi;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class CourseRepo : ICourseRepo
    {
        DBContext _context;

        public CourseRepo(DBContext context)
        {
            _context = context;
        }

        public Course Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> Get(BaseQueryParams queryParams)
        {
            var courseParams = queryParams as CoursesParams;
            if (courseParams == null)
            {
                throw new Exception($"Invalid query params, expected UniversityQueryParams and got {queryParams.GetType()}");
            }
            /*var queryable = Context.Universities.AsQueryable();*/
            var queryable = _context.Courses.AsQueryable();
        /*    if ( courseParams.CourseCode > 0)
            {
                queryable = queryable.Where(c => c.Code == courseParams.CourseCode);
            }
            if (courseParams.Name != null)
            {
                queryable = queryable.Where(c => c.Name == courseParams.Name);
            }
            if (courseParams.AgeCode > 0)
            {
                queryable = queryable.Where(c => c.AgeCode == courseParams.AgeCode);
            }
            if (courseParams.LevelCode > 0)
            {
                queryable = queryable.Where(c => c.CourseLevelCode == courseParams.LevelCode);
            }
            if (courseParams.TimeingCode > 0)
            {
                queryable = queryable.Where(c => c.TimingCode == courseParams.TimeingCode);
            }*/
            return queryable.Include(c => c.AgeCodeNavigation).Include(c => c.CourseLevelCodeNavigation).Include(c => c.PricingCodeNavigation).Include(c => c.TimingCodeNavigation).ToList();
            /*PagedList<University>
            .ToPagedListAsync(queryable.OrderBy(u => u.UniversityName),
            universityParams.PageNumber,
            universityParams.PageSize);*/
            /*  throw new NotImplementedException();*/
        }

        public List<Course> GetAll(BaseQueryParams queryParams)
        {
            return _context.Courses.Include(c => c.AgeCodeNavigation).Include(c => c.CourseLevelCodeNavigation).Include(c => c.PricingCodeNavigation).Include(c => c.TimingCodeNavigation).ToList(); 
            
        }

        public Course Post(Course entity)
        {
            throw new NotImplementedException();
        }

        public Course Put(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
