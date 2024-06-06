using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Students;

namespace Prueba.Controllers.Students
{
    public class StudentCreateController : ControllerBase
    {
        private readonly IStudentsRepository _StudentsRepository;
        public StudentCreateController(IStudentsRepository StudentsRepository)
        {
            _StudentsRepository = StudentsRepository;
        }
        [HttpPost,Route("api/students")]
        public ActionResult Add([FromBody] Student student){
        _StudentsRepository.Add(student);
            
            return Ok(student);
        }
    }
}