using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Models;

namespace Prueba.Services.Courses
{
    public interface ICoursesRepository
    {
        Task<IEnumerable<Course>> GetAll();
        Task<Course> GetById(int id);  
        void Add(Course course);
        void Update( Course course);  
        Task<IEnumerable<Course>> CoursesTeachers(int teacherId);
    }
}