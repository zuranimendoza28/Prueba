using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.DTO;
using Prueba.Services.Enrollments;

namespace Prueba.Controllers.Enrollments
{
    public class EnrollmentStatusController : ControllerBase
    {
        private readonly IEnrollmentsRepository _EnrollmentsRepository;
        public EnrollmentStatusController(IEnrollmentsRepository EnrollmentsRepository)
        {
            _EnrollmentsRepository = EnrollmentsRepository;
        }

        [HttpPut]
        [Route("api/enrollments/status/{id}")]
        public async Task<IActionResult> update(int id, [FromBody] StatusDto statusDto)
        {
            await _EnrollmentsRepository.update(id, statusDto);
            return Ok(204);
        }
    }
}