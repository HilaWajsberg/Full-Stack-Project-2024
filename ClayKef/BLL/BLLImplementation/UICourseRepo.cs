using BLL.BLLApi;
using BLL.BLLModels;
using DAL;
using DAL.DALImplementation;
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
        CourseRepo courseRepo;
        public UICourseRepo(DalManger dalManger)
        {
            this.courseRepo = dalManger.Courses;
           
        }
        public List<Task<UICourse>> GetCourses()
        {
            Task<List<Course>> courseTask = courseRepo.GetAll();
            List<UICourse> CourseList = new List<UICourse>();
            foreach (Course course in courseTask.Result)
            {
                UICourse newCourse = new();
                newCourse.Name = course.Name;
                newCourse.Ageing = course.AgeCodeNavigation.Name;
                newCourse.Level = course.CourseLevelCodeNavigation.Type;
                newCourse.Price = course.PricingCodeNavigation.Price;   
                newCourse.Day = course.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.NumOfMembers;
            }
            throw new Exception();
        }
    }
}
