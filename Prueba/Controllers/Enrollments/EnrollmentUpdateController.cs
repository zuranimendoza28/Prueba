using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Enrollments;

namespace Prueba.Controllers.Enrollments
{
    public class EnrollmentUpdateController : ControllerBase
    {
        private readonly IEnrollmentsRepository _EnrollmentsRepository;
        public EnrollmentUpdateController(IEnrollmentsRepository EnrollmentsRepository)
        {
            _EnrollmentsRepository = EnrollmentsRepository;
        }

        [HttpPut]
        [Route("api/enrollments/{id}")]
        public IActionResult Update([FromBody] Enrollment enrollments){
        
        _EnrollmentsRepository.Update(enrollments);
            return Ok( enrollments);
      } 
    }
}