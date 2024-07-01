using Common;
using DAL.DALApi;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALImplementation
{
    public class MemberToCourseRepo : IMembersToCoursesRepo
    {
        DBContext _context;
        public MemberToCourseRepo(DBContext context)
        {
            _context = context;
        }

        public List<MemberToCourse> GetByCourse(int id)
        {
            
/*            List<int> result = new List<int>();
            foreach(MemberToCourse cm in _context.MemberToCourses)
            {

            }*/
/*           List <MemberToCourse> membersCode = _context.MemberToCourses.Where(mc => mc.CourseCode == id).ToList();*/
            return _context.MemberToCourses.Where(mc => mc.CourseCode == id).ToList();
            /*            List<Member> members = new List<Member>();
                        foreach (MemberToCourse member in membersCode)*/
            {
               
            }
        }

/*        public List<MemberToCourse> GetByMember(int id)
        {

            *//*            List<int> result = new List<int>();
                        foreach(MemberToCourse cm in _context.MemberToCourses)
                        {

                        }*/
            /*           List <MemberToCourse> membersCode = _context.MemberToCourses.Where(mc => mc.CourseCode == id).ToList();*//*
            return _context.MemberToCourses.Where(mc => mc.MemberCode == id).ToList();
            *//*            List<Member> members = new List<Member>();
                        foreach (MemberToCourse member in membersCode)*//*
            {

            }
        }*/


        public List<MemberToCourse> GetByMember(int id)
        {
            throw new NotImplementedException();
        }

        public List<MemberToCourse> DeleteByCourse(int code)
        {
            List< MemberToCourse> lst = _context.MemberToCourses.Where(mc =>mc.CourseCode == code).ToList(); 
            foreach( MemberToCourse mc in lst)
            {
                _context.Remove(mc);
            }
            _context.SaveChanges();
            return lst;
        }
    }
}
