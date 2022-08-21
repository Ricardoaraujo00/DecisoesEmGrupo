using Microsoft.EntityFrameworkCore;
using DecisoesEmGrupo.Shared.Models;
using Microsoft.Extensions;
using System.Reflection;

namespace DecisoesEmGrupo.Server.Context
{
    public class DatabaseDbContext : DbContext
    {
        public static string dbconnectionstring = "";

      //public DatabaseDbContext()
      //  {
      //      this.Database.EnsureCreatedAsync();
      //  }




        public DbSet<Comentario> Comentario { get; set; }
        public DbSet<GostoComentario> GostoComentario { get; set; }
        public DbSet<Proposta> Proposta {get;set;}
        public DbSet<RepUser> ReppUser { get; set; }
        public DbSet<Utilizador> Utilizador {get;set;}
        public DbSet<Votacao> Votacao {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "Filename=dsdb.db",
                    sqliteOptionsAction: op =>
                    {
                        op.MigrationsAssembly(
                            Assembly.GetExecutingAssembly().FullName);
                    });
        }
        



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            //modelBuilder.Entity<Proposta>(entity =>
            //{
            //    entity.ToTable("aceitarexpulsarmembro");

            //    entity.Property(e => e.Id).HasColumnName("id");

            //    entity.Property(e => e.Aceite).HasColumnName("Aceite");

            //    entity.Property(e => e.Comentarios).HasColumnName("Comentarios");

            //    entity.Property(e => e.DataSubmissao).HasColumnName("DataSubmissao");

            //    entity.Property(e => e.Concluida).HasColumnName("Concluida");
            //});

            //modelBuilder.Seed();
            ////modelBuilder.Entity<Utilizador>().ToTable("Utilizador");
            ////modelBuilder.Entity<Veiculo>().ToTable("Veiculo");
            base.OnModelCreating(modelBuilder);
        }

    }
}
