using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.Models;

namespace Prueba.Services.Teachers
{
    public interface ITeachersRepository
    {
        Task<IEnumerable<Teacher>> GetAll();
        Task<Teacher> GetById(int id);  
        void Add(Teacher teacher);
        void Update( Teacher teacher);
    }
}