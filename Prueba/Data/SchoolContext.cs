using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class SchoolContext : DbContext
    {
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options){
    } 
         public DbSet<Student> Student { get; set; } 
         public DbSet<Teacher> Teacher { get; set; }
         public DbSet<Course> Course { get; set; }
         public DbSet<Enrollment> Enrollment { get; set; }
    }
}