using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Models;

namespace Prueba.Services.Students
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);  
        void Add(Student student);
        void Update( Student student);  
    }
}