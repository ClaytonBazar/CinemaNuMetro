using CinemaNuMetroV1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CinemaNuMetroV1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Models.Utilizador> Utilizador { get; set; }
        public DbSet<Models.filme> filme { get; set; }
        public DbSet<Models.Sessao> Sessao { get; set; }
       
    }
}
