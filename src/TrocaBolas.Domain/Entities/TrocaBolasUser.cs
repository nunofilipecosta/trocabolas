namespace TrocaBolas.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class TrocaBolasUser 
    {
        public TrocaBolasUser()
        {
        }

        public TrocaBolasUser(Guid userId, string username, string email, TrocaBolasUserProfile userProfile)
        {
            this.UserId = userId;
            this.Email = email;
            this.Username = username;
            this.Name = userProfile.Name;
            this.Address = userProfile.Address;
            this.ZipCode = userProfile.ZipCode;
            this.Town = userProfile.Town;
        }

        public Guid UserId { get; set; }

        public string Town { get; set; }    

        public string Username { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public string FiscalIdentificationNumber { get; set; }

        public string Phone { get; set; }

        public virtual ICollection<TrocaBolasProduct> InsertedProducts { get; set; }
    }
}