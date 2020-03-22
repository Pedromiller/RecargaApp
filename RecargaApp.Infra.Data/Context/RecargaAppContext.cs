using Microsoft.EntityFrameworkCore;
using RecargaApp.Domain.Aggregates;
using RecargaApp.Domain.Interfaces;
using RecargaApp.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RecargaApp.Infra.Data.Context
{
    public class RecargaAppContext : DbContext, IUnitOfWork
    {
        public RecargaAppContext(DbContextOptions<RecargaAppContext> options) : base(options)
        {

        }

        public virtual DbSet<EstacaoRecarga> EstacaoRecarga { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RecargaAppContext).Assembly);            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=RecargaApp;Trusted_Connection=True;");            
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
