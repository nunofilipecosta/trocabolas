namespace TrocaBolas.Domain.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using Entities;

    public interface IDbContext : IDisposable
    {
        Database Database { get; }

        DbContextConfiguration Configuration { get; }

        DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        DbSet<TrocaBolasProduct> Products { get; set; }

        void Save();
    }
}