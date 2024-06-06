using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Enrollments;

namespace Prueba.Controllers.Enrollments
{
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentsRepository _EnrollmentsRepository;
        public EnrollmentController(IEnrollmentsRepository EnrollmentsRepository)
        {
            _EnrollmentsRepository = EnrollmentsRepository;
        }
        [HttpGet, Route("api/enrollments")]
        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            return await _EnrollmentsRepository.GetAll();
        }


        [HttpGet, Route("api/enrollments/{Id}")]
        public async Task<Enrollment> Get(int Id)
        {
        return await _EnrollmentsRepository.GetById(Id);
        } 

        [HttpGet, Route("api/{Date}/date")]
        public async Task<IEnumerable<Enrollment>> DateEnrollment(DateTime date)
        {
            return await _EnrollmentsRepository.DateEnrollment(date);
        }
    }
}