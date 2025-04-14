using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CinemaNuMetroV1.Models;

namespace CinemaNuMetroV1.Data
{
    public class CinemaNuMetroV1Context : DbContext
    {
        public CinemaNuMetroV1Context (DbContextOptions<CinemaNuMetroV1Context> options)
            : base(options)
        {
        }

        public DbSet<CinemaNuMetroV1.Models.filme> filme { get; set; } = default!;
        public DbSet<CinemaNuMetroV1.Models.Sessao> Sessao { get; set; } = default!;
        public DbSet<CinemaNuMetroV1.Models.Utilizador> Utilizador { get; set; } = default!;
    }
}
