using Domain.Entities.Post;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostMap()); //aqui verifica as configuracoes que fizemos no banco de dados
            base.OnModelCreating(modelBuilder);
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions )
        {

        }
    }
}
