using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;

namespace BLL.BLLImplementation
{
    public class UICourseService : IUICourseService
    {
        ICourseRepo courseRepo;
        public UICourseService(ICourseRepo course)
        {
            this.courseRepo = course;
        }
       public List<UICourse>GetCourses(/*BaseQueryParams queryParams*/)
        {
            List<Course> courseTask = courseRepo.GetAll(/*queryParams*/) ;
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
            return  CourseList;
        }

        public List<UICourse> GetFilteredCourses(BaseQueryParams queryParams)
        {
            List<Course> courseTask = courseRepo.Get(queryParams);
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
            return CourseList;
        }
    }
    }

