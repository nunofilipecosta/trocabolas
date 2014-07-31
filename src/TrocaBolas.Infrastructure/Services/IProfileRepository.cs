namespace TrocaBolas.Infrastructure.Services
{
    using System;
    using Domain.Entities;

    public interface IUserRepository
    {
        TrocaBolasUser GetById(Guid userId);

        TrocaBolasUser Add(TrocaBolasUser currentUser, string password);

        void Dispose();
    }   
}