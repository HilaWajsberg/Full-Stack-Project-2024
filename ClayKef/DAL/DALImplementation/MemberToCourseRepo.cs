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
        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Get(int id)
        {
            throw new NotImplementedException();
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

        public List<MemberToCourse> GetByMember(int id)
        {

            /*            List<int> result = new List<int>();
                        foreach(MemberToCourse cm in _context.MemberToCourses)
                        {

                        }*/
            /*           List <MemberToCourse> membersCode = _context.MemberToCourses.Where(mc => mc.CourseCode == id).ToList();*/
            return _context.MemberToCourses.Where(mc => mc.MemberCode == id).ToList();
            /*            List<Member> members = new List<Member>();
                        foreach (MemberToCourse member in membersCode)*/
            {

            }
        }

        public List<int> GetAll(BaseQueryParams queryParams)
        {
            throw new NotImplementedException();
        }

        public int Post(int entity)
        {
            throw new NotImplementedException();
        }

        public int Put(int entity)
        {
            throw new NotImplementedException();
        }
    }
}
