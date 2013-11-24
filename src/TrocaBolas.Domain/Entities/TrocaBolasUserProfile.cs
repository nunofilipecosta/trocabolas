namespace TrocaBolas.Domain.Entities
{
    using System;

    public class TrocaBolasUserProfile
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string ZipCode { get; set; }

        public string Address { get; set; }

        public string Town { get; set; }

        public string Phone { get; set; }
    }
}