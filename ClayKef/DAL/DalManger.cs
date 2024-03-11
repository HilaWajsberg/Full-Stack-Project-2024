using DAL.DALImplementation;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DalManger
    {
        public CourseRepo Courses { get; set; }
        public DalManger() {
            ClayKefContext database = new ClayKefContext();
            Courses =new CourseRepo(database);
        }
    }
}
