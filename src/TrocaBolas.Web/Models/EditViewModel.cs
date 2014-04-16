namespace TrocaBolas.Web.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class EditViewModel
    {
        public Guid UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string ZipCodeLong { get; set; }

        [Required]
        public string ZipCodeShort { get; set; }

        [Required]
        public string Town { get; set; }

        [Required]
        public string FiscalIdentificationNumber { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}