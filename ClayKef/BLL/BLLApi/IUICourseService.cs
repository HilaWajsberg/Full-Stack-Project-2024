﻿using BLL.BLLModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi
{
    public interface IUICourseService
    {
        /*Task<*/List<UICourse>/*>*/ GetCourses();
        //string GetCourses();
    }
}
