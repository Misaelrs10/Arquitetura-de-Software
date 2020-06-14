using MeuPrimeiroProjeto.DAL.Infra;
using MeuPrimeiroProjeto.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MeuPrimeiroProjeto.DAL.DataBaseContext
{
    public class MeuPrimeiroProjetoDbContext : DbContext, IUnityOfWork
    {
        private IConfiguration configuration;

        public MeuPrimeiroProjetoDbContext(IConfiguration config)
        {
            configuration = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = configuration.GetConnectionString("MeuPrimeiroProjetoDbBase");
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        public async Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }

        public DbSet <Login> Login { get; set; }

    }

}
