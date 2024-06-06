using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prueba.DTO;
using Prueba.Models;

namespace Prueba.Services.Enrollments
{
    public interface IEnrollmentsRepository
    {
        void Add(Enrollment enrollment);
        Task<IEnumerable<Enrollment>> GetAll();
        Task<Enrollment> GetById(int id);  
        void Update( Enrollment enrollment);
        Task update(int Id, StatusDto statusDto);
        Task<IEnumerable<Enrollment>> DateEnrollment(DateTime date);
    }
}