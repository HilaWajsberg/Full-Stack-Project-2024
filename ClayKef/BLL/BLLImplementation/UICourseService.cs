using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BLL.BLLImplementation
{
    public class UICourseService : IUICourseService
    {
        ICourseRepo courseRepo;
        public UICourseService(ICourseRepo course)
        {
            this.courseRepo = course;
        }
       public List<UICourse> GetFilteredCourses(BaseQueryParams queryParams)
        {
            var courseParams = queryParams as CoursesParams;
            List<Course> courseTask = courseRepo.GetAll(queryParams) ;
            var CourseList = new List<UICourse>();
            foreach (Course course in courseTask)
            {
                UICourse newCourse = new();
                newCourse.Name = course.Name;
                newCourse.Ageing = course.AgeCodeNavigation.Name;
                newCourse.Level = course.CourseLevelCodeNavigation.Type;
                newCourse.Price = course.PricingCodeNavigation.Price;   
                newCourse.Day = course.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.NumOfMembers;
                CourseList.Add(newCourse);
            }
            var queryable = CourseList.AsQueryable();
            if (courseParams.Price > 0)
            {
                queryable = queryable.Where(c => c.Price >= courseParams.Price);
            }
            if (courseParams.Name != null)
            {
                queryable = queryable.Where(c => c.Name == courseParams.Name);
            }
            if (courseParams.Age != null)
            {
                queryable = queryable.Where(c => c.Ageing == courseParams.Age);
            }
            if (courseParams.Level != null)
            {
                queryable = queryable.Where(c => c.Level == courseParams.Level);
            }
            if (courseParams.Day > 0)
            {
                queryable = queryable.Where(c => c.Day == courseParams.Day);
            }
            if (courseParams.Hour > 0)
            {
                queryable = queryable.Where(c => c.Hour == courseParams.Hour);
            }

            return  queryable.ToList();
        }

/*        public List<UICourse> GetFilteredCourses(BaseQueryParams queryParams)
        {
            List<Course> courseTask = courseRepo.Get(queryParams);
            var CourseList = new List<UICourse>();
            foreach (Course course in courseTask)
            {
                UICourse newCourse = new();
                newCourse.Name = course.Name;
                newCourse.Ageing = course.AgeCodeNavigation.Name;
                newCourse.Level = course.CourseLevelCodeNavigation.Type;
                newCourse.Price = cour se.PricingCodeNavigation.Price;
                newCourse.Day = course.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.NumOfMembers;
                CourseList.Add(newCourse);
            }
            return CourseList;
        }*/
    }
}

