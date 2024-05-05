﻿using BLL.BLLApi;
using BLL.BLLModels;
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
       public /*Task<*/List<UICourse>/*>*/ GetCourses()
        {
            List<Course> courseTask = courseRepo.GetAll()/*.Result*/ ;
            //*   List < UICourse>CourseList = new List<UICourse>();*//*
            var CourseList = new List<UICourse>();
            //*var CourseList = await courseTask; *//*
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
            //*CourseList = GetListAsync(CourseList).Result;*//*
            return  CourseList;
        }


        //public string GetCourses()
        //{
        //    return courseRepo.GetAll();
        //}
    }
}