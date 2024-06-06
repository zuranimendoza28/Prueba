using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Models;

namespace Prueba.Services.Teachers
{
    public class TeachersRepository : ITeachersRepository
    {
        private readonly SchoolContext _context;
        public TeachersRepository(SchoolContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Teacher teacher)
        {
            _context.Teacher.Add(teacher);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Teacher>> GetAll()
        {
            return await _context.Teacher.ToListAsync();
        }
        //buscar por id
        public async Task <Teacher> GetById(int id)
        {
            return await _context.Teacher.FindAsync(id);
        }
        //actualizar
        public void Update(Teacher teacher)
        {
            _context.Teacher.Update(teacher);
            _context.SaveChanges();
        } 
    }
}