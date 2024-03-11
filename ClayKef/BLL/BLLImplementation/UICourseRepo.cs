using BLL.BLLApi;
using BLL.BLLModels;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation
{
    public class UICourseRepo : IUICourseRepo
    {
        DalManger dalMandger;
        public UICourseRepo()
        {
            dalMandger = new DalManger();
        }
        public List<Task<UICourse>> GetCourses()
        {
            Task<List<Course>> courseTask = dalMandger.Courses.GetAll();
            List<UICourse> CourseList = new List<UICourse>();
            foreach (Course course in courseTask.Result)
            {

            }
            throw new Exception();
        }
    }
}
