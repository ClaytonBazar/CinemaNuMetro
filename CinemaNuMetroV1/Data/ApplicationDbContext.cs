using CinemaNuMetroV1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaNuMetroV1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        public DbSet<Utilizador> Utilizadores { get; set; }
        public DbSet<filme> filmes { get; set; }
        public DbSet<Sessao> Sessions { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
    



    }
}
