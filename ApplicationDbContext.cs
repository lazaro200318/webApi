using proyectox.Models;
using Microsoft.EntityFrameworkCore;

namespace proyectox
{
    public class ApplicationDbContext : DbContext
    {
        public  ApplicationDbContext(DbContextOptions options) : base (options)
    {

    }

    public DbSet<Alumno> Alumnos {get; set;}
     }
}