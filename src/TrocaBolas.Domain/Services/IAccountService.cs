using System;

using TrocaBolas.Domain.Entities;

namespace TrocaBolas.Domain.Services
{
    public interface IAccountService
    {
        void Register(TrocaBolasUser currentUser);

        TrocaBolasUser Register(TrocaBolasUser currentUser, string password);

        TrocaBolasUser GetById(Guid userId);

        bool Validate(string userName, string password);
    }
}