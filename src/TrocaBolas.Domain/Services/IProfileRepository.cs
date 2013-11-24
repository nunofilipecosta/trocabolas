using System;
using TrocaBolas.Domain.Entities;
namespace TrocaBolas.Domain.Services
{
    public interface IUserRepository 
    {
        TrocaBolasUser GetById(Guid userId);

        TrocaBolasUser Add(TrocaBolasUser currentUser, string password);
    }   
}