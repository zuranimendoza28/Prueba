using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Teachers;

namespace Prueba.Controllers.Teachers
{
    public class TeacherCreateController : ControllerBase
    {
        private readonly ITeachersRepository _TeachersRepository;
        public TeacherCreateController(ITeachersRepository TeachersRepository)
        {
            _TeachersRepository = TeachersRepository;
        }

        [HttpPost,Route("api/teachers")]
        public ActionResult Add([FromBody] Teacher teacher){
        _TeachersRepository.Add(teacher);
            
            return Ok(teacher);
        }
    }
}