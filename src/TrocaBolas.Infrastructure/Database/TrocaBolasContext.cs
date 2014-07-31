
namespace TrocaBolas.Infrastructure.Database
{
    using System;
    using System.Data.Entity;
    using Domain.Entities;
    using Mappings;

    public class TrocaBolasContext : DbContext
    {
        public TrocaBolasContext()
            : base("umbracoDbDSN")
        {
        }

        public Database Db { get; private set; }

        public DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // add mappings here
            modelBuilder.Configurations.Add(new TrocaBolasUserProfileMapping());
            //modelBuilder.Configurations.Add(new TrocaBolasProductMapping());
        }

        public void Save()
        {
            this.SaveChanges();
        }
    }
}
