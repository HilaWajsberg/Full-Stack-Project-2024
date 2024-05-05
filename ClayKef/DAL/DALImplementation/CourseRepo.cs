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

        public /*Task<*/List<Course>/*> */ GetAll()
        {
            return _context.Courses.Include(c => c.AgeCodeNavigation).Include(c => c.CourseLevelCodeNavigation).Include(c => c.PricingCodeNavigation).Include(c => c.TimingCodeNavigation).ToList(); 
            //return "I am in get all";
        }


    }
}
