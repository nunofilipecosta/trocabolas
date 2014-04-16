using System;

namespace TrocaBolas.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
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
        [Display(Name = "Localidade")]
        public string Town { get; set; }

        [Required]
        [Display(Name = "N.I.F")]
        public string FiscalIdentificationNumber { get; set; }

        [Required]
        [Display(Name = "Telemóvel")]
        public string Phone { get; set; }
    }
}