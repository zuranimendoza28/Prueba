using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Student
    {
        public int Id {get; set;}
        [Required]
        public string Names {get; set;}
        [Required]
        public DateOnly BirthDate {get; set;}
        [Required]
        public string Address {get; set;}
        [Required]
        public string Email {get; set;}
        [JsonIgnore]
        public List<Enrollment> Enrollment {get;set;}


    }
}