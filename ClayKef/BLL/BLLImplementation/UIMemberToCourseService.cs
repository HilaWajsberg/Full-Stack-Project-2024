using BLL.BLLApi;
using BLL.BLLModels;
using Common;
using DAL.DALApi;
using DAL.DALImplementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLImplementation
{
    public class UIMemberToCourseService : IUIMemberToCourseService
    {
        IMembersToCoursesRepo memberCourseRepo;
        IUIMemberService member;
        //IUICourseService courseService;
        public UIMemberToCourseService(IMembersToCoursesRepo memberCourseRepo, IUIMemberService member/*, IUICourseService courseServic*/)
        {
            this.memberCourseRepo = memberCourseRepo;
            this.member = member;
            //this.courseService = courseService;
        }
        public async Task<List<UIMember>> GetMembersByCourse(int id)
        {
            List<MemberToCourse> courseMemberTask = memberCourseRepo.GetByCourse(id);
            var membersList = new List<UIMember>();
            foreach (MemberToCourse mc in courseMemberTask)
            {
                membersList.Add(member.GetMemberById(mc.MemberCode).Result);
            }
            return membersList;
        }
/*        public async Task<List<UICourse>> GetCourseByMember(int id)
        {
            List<MemberToCourse> courseMemberTask = memberCourseRepo.GetByMember(id);
            var coursesList = new List<UICourse>();
            foreach (MemberToCourse mc in courseMemberTask)
            {
                coursesList.Add(courseService.GetCourseById(mc.CourseCode).Result);
            }
            return coursesList;
        }*/

        public Task<UIMember> RemoveMembersCourse(int id)
        {
            throw new NotImplementedException();
        }
    }
}

