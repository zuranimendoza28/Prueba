using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Courses;

namespace Prueba.Controllers.Courses
{
    public class CourseCreateController : ControllerBase
    {
        private readonly ICoursesRepository _CoursesRepository;
        public CourseCreateController(ICoursesRepository CoursesRepository)
        {
            _CoursesRepository = CoursesRepository;
        }
        [HttpPost,Route("api/courses")]
        public ActionResult Add([FromBody] Course course){
        _CoursesRepository.Add(course);
            
            return Ok(course);
        }
    }
}