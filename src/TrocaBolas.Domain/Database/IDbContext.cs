namespace TrocaBolas.Domain.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using TrocaBolas.Domain.Entities;

    public interface IDbContext : IDisposable
    {
        System.Data.Entity.Database Database { get; }

        DbContextConfiguration Configuration { get; }

        DbSet<TrocaBolasUserProfile> Profiles { get; set; }

        void Save();
    }
}