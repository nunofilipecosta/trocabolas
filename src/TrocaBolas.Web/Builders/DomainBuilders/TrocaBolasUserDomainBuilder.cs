

namespace TrocaBolas.Web.Builders.DomainBuilders
{
    using System;
    using Infrastructure.Services;
    using TrocaBolas.Domain.Entities;
    using TrocaBolas.Web.Models;

    public class TrocaBolasUserDomainBuilder : IDomainBuilder<RegisterViewModel, TrocaBolasUser>
    {
        private readonly IAccountService _accountService;

        public TrocaBolasUserDomainBuilder(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public TrocaBolasUser Build(RegisterViewModel viewModel)
        {
            if (viewModel.UserId.Equals(Guid.Empty))
            {
                var trocaBolasUser = new TrocaBolasUser();
                trocaBolasUser.Name = viewModel.Name;
                trocaBolasUser.Email = viewModel.Email;
                trocaBolasUser.Username = viewModel.Email;
                trocaBolasUser.Address = viewModel.Address;
                trocaBolasUser.ZipCode = string.Format("{0}-{1}", viewModel.ZipCodeLong, viewModel.ZipCodeShort);
                trocaBolasUser.Town = viewModel.Town;
                trocaBolasUser.Phone = viewModel.Phone;
                trocaBolasUser.FiscalIdentificationNumber = viewModel.FiscalIdentificationNumber;

                return trocaBolasUser;
            }

            var existingTrocaBolasUser = _accountService.GetById(viewModel.UserId);
            existingTrocaBolasUser.Name = viewModel.Name;
            existingTrocaBolasUser.Email = viewModel.Email;
            return existingTrocaBolasUser;
        }
    }
}