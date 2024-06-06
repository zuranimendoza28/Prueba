using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Courses;

namespace Prueba.Controllers.Courses
{
    public class CourseController : ControllerBase
    {
        private readonly ICoursesRepository _CoursesRepository;
        public CourseController(ICoursesRepository CoursesRepository)
        {
            _CoursesRepository = CoursesRepository;
        }
        [HttpGet, Route("api/courses")]
        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _CoursesRepository.GetAll();
        }
        [HttpGet, Route("api/courses/{Id}")]
        public async Task<Course> Get(int Id)
        {
        return await _CoursesRepository.GetById(Id);
        } 

        //
        [HttpGet, Route("api/teachers/id/courses")]
        public async Task<IEnumerable<Course>> CoursesTeachers(int teacherId)
        {
            return await _CoursesRepository.CoursesTeachers(teacherId);
        }
    }
}