using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class CourseLevel
{
    public int Code { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
}
