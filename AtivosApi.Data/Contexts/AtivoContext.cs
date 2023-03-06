using AtivosApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivosApi.Data.Contexts;

public class AtivoContext : DbContext
{
    public AtivoContext(DbContextOptions<AtivoContext> options)
        : base(options)
    {

    }

    public DbSet<Ativo> Ativos { get; set; }
}
