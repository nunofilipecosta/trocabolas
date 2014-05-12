using TrocaBolas.Domain.Entities;
using TrocaBolas.Web.Models;

namespace TrocaBolas.Web.Builders.ViewModelBuiders
{
    using System;
    using Infrastructure.Services;

    public class RegisterViewModelBuilder : IViewModelBuilder<TrocaBolasUser, RegisterViewModel>
    {
        private readonly IAccountService _accountService;

        public RegisterViewModelBuilder(IAccountService accountService)
        {
            _accountService = accountService;
        }

        /// <exception cref="NotImplementedException">Thrown when something goes really bad</exception>
        public RegisterViewModel Build(Guid userId)
        {
            if (userId == Guid.Empty)
            {
                var emptyViewModel = new RegisterViewModel();

                return emptyViewModel;
            }

            throw new NotImplementedException();
        }

        /// <exception cref="NotImplementedException">Thrown when </exception>
        public RegisterViewModel Rebuild(RegisterViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}