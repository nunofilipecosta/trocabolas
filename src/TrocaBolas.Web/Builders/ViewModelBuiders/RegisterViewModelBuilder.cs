using TrocaBolas.Domain.Entities;
using TrocaBolas.Domain.Services;
using TrocaBolas.Web.Models;

namespace TrocaBolas.Web.Builders.ViewModelBuiders
{
    using System;

    public class RegisterViewModelBuilder : IViewModelBuilder<TrocaBolasUser, RegisterViewModel>
    {
        private readonly IAccountService _accountService;

        public RegisterViewModelBuilder(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public RegisterViewModel Build(TrocaBolasUser domain)
        {
            throw new System.NotImplementedException();
        }

        public RegisterViewModel Build(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                var emptyViewModel = new RegisterViewModel();
                // dummy values
                emptyViewModel.Name = "Nuno Costa";
                emptyViewModel.Email = "nunofilipe.costa@outlook.com";
                emptyViewModel.ConfirmEmail = "nunofilipe.costa@outlook.com";
                emptyViewModel.Password = "111111";
                emptyViewModel.ConfirmPassword = "111111";
                emptyViewModel.Address = "Rua da Estada";
                emptyViewModel.ZipCodeLong = "2655";
                emptyViewModel.ZipCodeShort = "333";
                emptyViewModel.Town = "Ericeira";
                emptyViewModel.Phone = "966666666";
                emptyViewModel.FiscalIdentificationNumber = "223511110";

                return emptyViewModel;
            }

            throw new NotImplementedException();
        }

        public RegisterViewModel Rebuild(RegisterViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}