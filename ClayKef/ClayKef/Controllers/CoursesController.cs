using BLL;
using BLL.BLLApi;
using BLL.BLLModels;
using DAL.DALApi;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClayKef.Controlleers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
      
        IUICourseService coursesService;

        public CoursesController(IUICourseService coursesService)
        {
            this.coursesService = coursesService;
        }
        
        [HttpGet]
        /* public async Task<ActionResult<List<UICourse>>> GetAllCourses(){
             return await coursesService.GetCourses();
         }*/

        public string GetAllCourses()
        {
            return coursesService.GetCourses();
        }

    }
}
