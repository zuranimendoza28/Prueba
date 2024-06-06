using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Students;

namespace Prueba.Controllers.Students
{
    public class StudentController : ControllerBase
    {
        private readonly IStudentsRepository _StudentsRepository;
        public StudentController(IStudentsRepository StudentsRepository)
        {
            _StudentsRepository = StudentsRepository;
        }
        [HttpGet, Route("api/students")]
        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _StudentsRepository.GetAll();
        }
        [HttpGet, Route("api/Students/{Id}")]
        public async Task<Student> Get(int Id)
        {
        return await _StudentsRepository.GetById(Id);
        } 
    }
}