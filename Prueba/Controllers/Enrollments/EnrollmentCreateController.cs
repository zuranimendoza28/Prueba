using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prueba.Models;
using Prueba.Services.Enrollments;

namespace Prueba.Controllers.Enrollments
{
    public class EnrollmentCreateController : ControllerBase
    {
        private readonly IEnrollmentsRepository _EnrollmentsRepository;
        public EnrollmentCreateController(IEnrollmentsRepository EnrollmentsRepository)
        {
            _EnrollmentsRepository = EnrollmentsRepository;
        }
        [HttpPost,Route("api/enrollments")]
        public ActionResult Add([FromBody] Enrollment enrollments){
        _EnrollmentsRepository.Add(enrollments);
            
            return Ok(enrollments);
        }
    }
}





/* POST:
http://localhost:5287/api/v1/CreateAppointment
Descripción:
Este endpoint realiza una solicitud HTTP POST para crear una cita, y a su vez realizará un nuevo resgistro de la cita enviada en la entidad correspondiente 'Appointments'.
Parámetros de Ruta:
El endpoint no implementa parámetros de ruta.

Solicitud:
La solicitud requiere un 'body' de solicitud en el que se enviará la información de la cita. Así realizará una solicitud POST al endpoint */
