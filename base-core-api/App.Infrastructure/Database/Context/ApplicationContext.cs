using App.Infraestructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure.Database.Context
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }


        public DbSet<UserEntity> Users { get; set; } = default!;

        public DbSet<PersonEntity> Persons { get; set; } = default!;

        public DbSet<DocumentTypeEntity> DocumentTypes { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<UserEntity>(entity => { entity.HasIndex(e => e.UserName).IsUnique(); });

            model.Entity<PersonEntity>(entity => { entity.HasIndex(e => new { e.Email, e.DNI }).IsUnique(); });

            model.Entity<DocumentTypeEntity>(entity => { entity.HasIndex(e => e.Code).IsUnique(); });
        }
    }
}
