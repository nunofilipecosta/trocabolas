namespace TrocaBolas.Infrastructure.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Domain.Entities;

    public interface IDbContext
    {
        Database Db { get; }

        DbContextConfiguration Configuration { get; }

        DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        DbSet<Product> Products { get; set; }

        void Save();
    }
}