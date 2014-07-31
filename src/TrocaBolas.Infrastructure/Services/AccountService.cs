namespace TrocaBolas.Infrastructure.Services
{
    using System;
    using System.Diagnostics;
    using System.Web.Security;
    using Database.Repositories;
    using Domain.Entities;

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
            try
            {
                throw new NotImplementedException();
            }
            catch (NotImplementedException notImplementedException)
            {
                System.Diagnostics.EventLog.WriteEntry(string.Empty, notImplementedException.Message, EventLogEntryType.Error);
                return new TrocaBolasUser();
            }
        }

        public bool Validate(string userName, string password)
        {
            return Membership.ValidateUser(userName, password);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userRepository != null)
                {
                    _userRepository.Dispose();
                }
            }
        }
    }
}