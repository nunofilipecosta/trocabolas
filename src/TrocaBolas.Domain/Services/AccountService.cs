using System;
using System.Web.Security;
using TrocaBolas.Domain.Database.Repositories;
using TrocaBolas.Domain.Entities;
namespace TrocaBolas.Domain.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUserRepository _userRepository;

        public AccountService()
        {
            this._userRepository = new SqlUserRepository();
        }

        public void Register(TrocaBolasUser currentUser)
        {
        }

        public TrocaBolasUser Register(TrocaBolasUser currentUser, string password)
        {
            // TODO : validate business logic
            var trocaBolasUser = _userRepository.Add(currentUser, password);

            return trocaBolasUser;
        }

        public TrocaBolasUser GetById(Guid userId)
        {
            throw new System.NotImplementedException();
        }

        public bool Validate(string userName, string password)
        {
            return Membership.ValidateUser(userName, password);
        }
    }
}