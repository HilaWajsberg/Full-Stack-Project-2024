using BLL.BLLApi;
using BLL.BLLModels;
using DAL;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;

namespace BLL.BLLImplementation
{
    public class UICourseRepo : IUICourseRepo
    {
        ICourseRepo courseRepo;
        public UICourseRepo(ICourseRepo c)
        {
            this.courseRepo = c;
        }
        public async Task<List<UICourse>> GetCourses()
        {
            Task<List<Course>> courseTask = courseRepo.GetAll();
            /*   List < UICourse>CourseList = new List<UICourse>();*/
            var CourseList = new List<UICourse>();
            /*var CourseList = await courseTask; */
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
                CourseList/*.Result*/.Add(newCourse);
            }
            /*CourseList = GetListAsync(CourseList).Result;*/
            return /*await*/ CourseList;
        }
    }
}
