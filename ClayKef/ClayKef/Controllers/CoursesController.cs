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
      
        IUICourseRepo CoursesRepo;

        public CoursesController(BLLManager bllManager)
        {
            CoursesRepo = bllManager.uicourseRepo;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<UICourse>>> GetAllCourses(){
            return await CoursesRepo.GetCourses();
        }
  
    }
}
