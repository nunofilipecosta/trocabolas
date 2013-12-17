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

        public RegisterViewModel Build(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                var emptyViewModel = new RegisterViewModel();

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