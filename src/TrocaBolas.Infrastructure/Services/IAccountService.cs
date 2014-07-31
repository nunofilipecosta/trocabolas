namespace TrocaBolas.Infrastructure.Services
{
    using System;
    using Domain.Entities;

    public interface IAccountService : IDisposable
    {
        void Register(TrocaBolasUser currentUser);

        TrocaBolasUser Register(TrocaBolasUser currentUser, string password);

        TrocaBolasUser GetById(Guid userId);

        bool Validate(string userName, string password);
    }
}