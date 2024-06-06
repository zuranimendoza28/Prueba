using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Data;
using Prueba.DTO;
using Prueba.Models;
using Prueba.Utils;

namespace Prueba.Services.Enrollments
{
    public class EnrollmentsRepository : IEnrollmentsRepository
    {
         private readonly SchoolContext _context;
        public EnrollmentsRepository(SchoolContext context)
        {
            _context = context;
        }
        //crear
        public void Add(Enrollment enrollments)
        {
            
            var student = _context.Student.Find(enrollments.StudentId);
            var course = _context.Course.Find(enrollments.CourseId);
           
            var sendEmail = new MailersendUtils();
            //se utiliza el metodo .Enviarcorreo(), se envia como parametro el email   del paciente y la fecha de la cita:
            sendEmail.EnviarCorreo(student.Email, enrollments.Date, student.Names, course.Name );
            _context.Enrollment.Add(enrollments);
            _context.SaveChanges();

        }
        //listar
        public async Task<IEnumerable<Enrollment>> GetAll()
        {
            return await _context.Enrollment.Include(s => s.Student).Include(c =>c.Course).ToListAsync();
        }
        //buscar por id
        public async Task <Enrollment> GetById(int id)
        {
            return await _context.Enrollment.FindAsync(id);
        }
        //actualizar
        public void Update(Enrollment enrollments)
        {
            _context.Enrollment.Update(enrollments);
            _context.SaveChanges();

        } 
        public async Task update(int Id, StatusDto statusDto)
        {
            var status = await _context.Enrollment.FindAsync(Id);
            if (status == null)
            {
                return;
            }
            status.Status = statusDto.Status;

            await _context.SaveChangesAsync();    
        } 
        //listar matriculas en fechas especificas
        public async Task<IEnumerable<Enrollment>> DateEnrollment(DateTime date)
        {
            return await _context.Enrollment.Where(X => X.Date.Date == date.Date).ToListAsync();
        }
        
    }
}