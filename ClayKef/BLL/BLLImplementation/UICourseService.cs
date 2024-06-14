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
        IUIMemberToCourseService memberToCourseService;
        public UICourseService(ICourseRepo course, IUIMemberToCourseService memberToCourseService)
        {
            courseRepo = course;
            this.memberToCourseService = memberToCourseService;
        }

        public async Task<UICourse> GetCourseById(int id)
        {
                Task<Course> course = courseRepo.Get(id);
                UICourse newCourse = new();
                newCourse.Name = course.Result.Name;
                newCourse.Ageing = course.Result.AgeCodeNavigation.Name;
                newCourse.Level = course.Result.CourseLevelCodeNavigation.Type;
                newCourse.Price = course.Result.PricingCodeNavigation.Price;
                newCourse.Day = course.Result.TimingCodeNavigation.Day;
                newCourse.Hour = (float)course.Result.TimingCodeNavigation.Hour;
                newCourse.NumOfMembers = course.Result.NumOfMembers;
                return newCourse;  
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
                if (1 == 5)
                {
                    newCourse.Members = null;
                }
                else
                {
                    newCourse.Members = memberToCourseService.GetMembersByCourse(course.Code).Result;

                }
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
           /* if (1 == 1)
            {

            }
            else { }*/
            return  queryable.ToList();
        }

        public async Task<UICourse> RemoveCourse(int id)
        {
            Task<Course> course = courseRepo.Delete(id);
            UICourse newCourse = new UICourse();
            newCourse.Code = course.Result.Code;
            newCourse.Name = course.Result.Name;
            newCourse.Ageing = course.Result.AgeCodeNavigation.Name;
            newCourse.Level = course.Result.CourseLevelCodeNavigation.Type;
            newCourse.Price = course.Result.PricingCodeNavigation.Price;
            newCourse.Day = course.Result.TimingCodeNavigation.Day;
            newCourse.Hour = (float)course.Result.TimingCodeNavigation.Hour;
            newCourse.NumOfMembers = course.Result.NumOfMembers;
           /* foreach(MemberToCourse memberTo in course.Result.MemberToCourseCodeNavigation.MemberCode)
            {
                
            }*/

            return newCourse;
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

