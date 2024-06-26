﻿using BLL.BLLModels;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLLApi
{
    public interface IUICourseService
    {
        //List<UICourse> GetCourses(BaseQueryParams queryParams);
        List<UICourse> GetFilteredCourses(BaseQueryParams queryParams);
        Task<UICourse> GetCourseById(int id);
        Task<UICourse> RemoveCourse(int id);
    }
}
