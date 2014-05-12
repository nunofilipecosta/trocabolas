namespace TrocaBolas.Infrastructure.Database.Repositories
{
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.Security;
    using Domain.Entities;
    using Services;

    public class SqlUserRepository : IUserRepository
    {
        private readonly IDbContext _context;
        

        public SqlUserRepository()
        {
            _context = new TrocaBolasContext();
        }

        public TrocaBolasUser GetById(Guid userId)
        {
            var membershipUser = Membership.GetUser(userId);
            if (membershipUser == null || membershipUser.ProviderUserKey == null)
            {
                throw new InvalidExpressionException(string.Format("No user found with Id : {0}", userId));
            }

            var trocaBolasUserProfile = _context.Profiles.SingleOrDefault(u => u.UserId == userId);

            return new TrocaBolasUser(Guid.Parse(membershipUser.ProviderUserKey.ToString()), membershipUser.UserName, membershipUser.Email, trocaBolasUserProfile);
        }

        ///<exception cref="T:System.InvalidOperationException">The user was not created.</exception>
        public TrocaBolasUser Add(TrocaBolasUser currentUser, string password)
        {
            var membershipUser = Membership.CreateUser(currentUser.Username, password, currentUser.Email);
        
            if (membershipUser.ProviderUserKey == null)
            {
                throw new InvalidOperationException();
            }

            // add user to role
            Roles.AddUserToRole(membershipUser.UserName, "RegisteredUsers");

            var currentProfile = new TrocaBolasUserProfile();
            try
            {
                currentProfile.Address = currentUser.Address;
                currentProfile.Name = currentUser.Name;
                currentProfile.Phone = currentUser.Phone;
                currentProfile.Town = currentUser.Town;
                currentProfile.UserId = Guid.Parse(membershipUser.ProviderUserKey.ToString());
                currentProfile.ZipCode = currentUser.ZipCode;

                _context.Profiles.Add(currentProfile);
                _context.Save();
            }
            catch (Exception exception)
            {
                Membership.DeleteUser(membershipUser.UserName, true);
                Console.WriteLine(exception.Message);
                throw;
            }


            return new TrocaBolasUser(currentProfile.UserId, membershipUser.UserName, membershipUser.Email, currentProfile);
        }
    }
}