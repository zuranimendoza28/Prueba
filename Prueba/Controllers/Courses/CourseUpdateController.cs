using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Courses;

namespace Prueba.Controllers.Courses
{
    public class CourseUpdateController : ControllerBase
    {
        private readonly ICoursesRepository _CoursesRepository;
        public CourseUpdateController(ICoursesRepository CoursesRepository)
        {
            _CoursesRepository = CoursesRepository;
        }
        [HttpPut]
        [Route("api/Courses/{id}")]
        public IActionResult Update([FromBody] Course courses){
        
        _CoursesRepository.Update(courses);
            return Ok( courses);
      }
    }
}