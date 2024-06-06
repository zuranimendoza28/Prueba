using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Teachers;

namespace Prueba.Controllers.Teachers
{
    public class TeacherController : ControllerBase
    {
        private readonly ITeachersRepository _TeachersRepository;
        public TeacherController(ITeachersRepository TeachersRepository)
        {
            _TeachersRepository = TeachersRepository;
        }
        [HttpGet, Route("api/teachers")]
        public async Task<IEnumerable<Teacher>> GetAll()
        {
            return await _TeachersRepository.GetAll();
        }
        [HttpGet, Route("api/teachers/{Id}")]
        public async Task<Teacher> Get(int Id)
        {
        return await _TeachersRepository.GetById(Id);
        } 
    }
}