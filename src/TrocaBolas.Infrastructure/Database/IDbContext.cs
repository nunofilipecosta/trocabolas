namespace TrocaBolas.Infrastructure.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Domain.Entities;

    public interface IDbContext : IDisposable
    {
        Database Db { get; }

        DbContextConfiguration Configuration { get; }

        DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        DbSet<TrocaBolasProduct> Products { get; set; }

        void Save();
    }
}