using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Course
    {
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public string Description {get;set;}
        [Required]
        public string Duration {get;set;}
        [Required]
        public string Schedule {get;set;}
        [Required]
        public int Capacity {get;set;}
        [Required]
        public int TeacherId {get;set;}
        public Teacher Teacher {get;set;}
        [JsonIgnore]
        public List<Enrollment> Enrollment  {get;set;} 
    }
}