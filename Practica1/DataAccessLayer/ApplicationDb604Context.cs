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
            optionsBuilder.UseNpgsql("Host=<ip>;Port=5432;Database=<604 DB name>;Username=<uid>;Password=<psw>");
        }
    }
}