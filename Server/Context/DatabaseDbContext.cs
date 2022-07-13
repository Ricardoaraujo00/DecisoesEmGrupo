using Microsoft.EntityFrameworkCore;
using DecisoesEmGrupo.Shared.Models;

namespace DecisoesEmGrupo.Server.Context
{
    public class DatabaseDbContext : DbContext
    {

        public DbSet<Comentario>? Comentario { get; set; }
        public DbSet<GostoComentario>? GostoComentario { get; set; }
        public DbSet<Proposta>? Proposta {get;set;}
        public DbSet<RepUser>? ReppUser { get; set; }
        public DbSet<Utilizador>? Utilizador {get;set;}
        public DbSet<Votacao>? Votacao {get;set;}
        
    }
}
