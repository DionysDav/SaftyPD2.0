using Microsoft.EntityFrameworkCore;
using Practica1.Domains;
using Practica1.Models;

namespace Practica1.DataAccessLayer
{
    public class ApplicationDb604Context : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=192.168.88.3;Port=5432;Database=db604;Username=foretkc;Password=123ewq");
        }
    }
}