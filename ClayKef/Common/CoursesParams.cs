using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CoursesParams: BaseQueryParams
    {
        public int CourseCode { get; set; }
        public string? Name { get; set; }
        public int AgeCode { get; set; }
        public int LevelCode { get; set; }
        public int TimeingCode { get; set; }
    }
}
