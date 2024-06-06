using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Teachers;

namespace Prueba.Controllers.Teachers
{
    public class TeacherUpdateController : ControllerBase
    {
        private readonly ITeachersRepository _TeachersRepository;
        public TeacherUpdateController(ITeachersRepository TeachersRepository)
        {
            _TeachersRepository = TeachersRepository;
        }

        [HttpPut]
        [Route("api/Teachers/{id}")]
        public IActionResult Update([FromBody] Teacher teachers){
        
        _TeachersRepository.Update(teachers);
            return Ok( teachers);
      }


    }
}