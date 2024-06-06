using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.Models;

namespace Prueba.Services.Courses
{
    public class CoursesRepository : ICoursesRepository
    {
        private readonly SchoolContext _context;
        public CoursesRepository(SchoolContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Course course)
        {
            _context.Course.Add(course);
            _context.SaveChanges();
        }
        //listar
        public async Task<IEnumerable<Course>> GetAll()
        {
            return await _context.Course.Include(t => t.Teacher).ToListAsync();
        }
        //buscar por id
        public async  Task <Course> GetById(int id)
        {
            return await _context.Course.FindAsync(id);
        }
        //actualizar
        public void Update(Course courses)
        {
            _context.Course.Update(courses);
            _context.SaveChanges();
        } 
        //Listar todos los cursos que tiene un estudiante
        public async Task<IEnumerable<Course>> CoursesTeachers(int teacherId)
        {
            return await _context.Course.Where(c => c.TeacherId == teacherId).Include(c => c.Teacher).ToListAsync();
        }
    }
}