using DAL.models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.contexts
{
    public class NotaEvaluacionContext : DbContext
    {
        public NotaEvaluacionContext()
        {

        }

        public NotaEvaluacionContext(DbContextOptions<NotaEvaluacionContext> options)
            : base(options)
        { 
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=asp.net-bd-examen-2ev;UserId=postgres;Password=12345;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        public virtual DbSet<Evaluacion>? SetEvaluaciones { get; set; }
        public virtual DbSet<Nota>? SetNotas { get; set; }
    }
}
