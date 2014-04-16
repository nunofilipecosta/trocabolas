
namespace TrocaBolas.Domain.Database
{
    using System;
    using System.Data.Entity;

    using TrocaBolas.Domain.Database.Mappings;
    using TrocaBolas.Domain.Entities;

    public class TrocaBolasContext : DbContext, IDbContext
    {
        public TrocaBolasContext()
            : base("umbracoDbDSN")
        {
        }

        public DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        public DbSet<TrocaBolasProduct> Products { get; set; }

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
