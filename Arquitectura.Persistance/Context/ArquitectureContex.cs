using Arquitectura.Domain.Entities.appointments;
using Microsoft.EntityFrameworkCore;

namespace Arquitectura.Persistance.Context
{
    public class ArquitectureContex : DbContext
    {
        public ArquitectureContex(DbContextOptions<ArquitectureContex> options) : base(options) 
        {
        }

        public DbSet<Appointments> Appointments { get; set; }   
    }
}
