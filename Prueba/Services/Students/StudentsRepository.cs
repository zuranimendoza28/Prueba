using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Models;

namespace Prueba.Services.Students
{
    public class StudentsRepository : IStudentsRepository
    {
        private readonly SchoolContext _context;
        public StudentsRepository(SchoolContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Student students)
        {
            _context.Student.Add(students);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Student.ToListAsync();
        }
        //buscar por id
        public async  Task <Student> GetById(int id)
        {
            return await _context.Student.FindAsync(id);
        }
        //actualizar
        public void Update(Student student)
        {
            _context.Student.Update(student);
            _context.SaveChanges();
        } 
    }
}