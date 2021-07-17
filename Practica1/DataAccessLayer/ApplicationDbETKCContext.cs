using Microsoft.EntityFrameworkCore;
using Practica1.Domains;
using Practica1.Models;

namespace Practica1.DataAccessLayer
{
    public class ApplicationDbETKCContext : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //SET YOUR VALUES HERE
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=etkc;Username=simfonia;Password=enke");
        }
    }
}