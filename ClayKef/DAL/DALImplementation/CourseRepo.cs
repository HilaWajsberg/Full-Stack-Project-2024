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
        ClayKefContext _context;

        public CourseRepo(ClayKefContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAll()
        {
            return await _context.Courses.ToListAsync();
        }
    }
}
