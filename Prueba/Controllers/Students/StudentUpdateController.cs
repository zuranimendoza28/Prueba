using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Students;

namespace Prueba.Controllers.Students
{
    public class StudentUpdateController : ControllerBase
    {
        private readonly IStudentsRepository _StudentsRepository;
        public StudentUpdateController(IStudentsRepository StudentsRepository)
        {
            _StudentsRepository = StudentsRepository;
        } 
        [HttpPut]
        [Route("api/students/{id}")]
        public IActionResult Update([FromBody] Student students){
        
        _StudentsRepository.Update(students);
            return Ok( students);
      }
    }
}