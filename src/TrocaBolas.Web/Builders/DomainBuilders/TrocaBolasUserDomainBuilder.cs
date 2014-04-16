using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TrocaBolas.Domain.Entities;
using TrocaBolas.Domain.Services;
using TrocaBolas.Web.Builders.ViewModelBuiders;
using TrocaBolas.Web.Models;

namespace TrocaBolas.Web.Builders.DomainBuilders
{
    using System.Web.UI.WebControls;

    public class TrocaBolasUserDomainBuilder : IDomainBuilder<RegisterViewModel, TrocaBolasUser>
    {
        private readonly IAccountService _accountService;

        public TrocaBolasUserDomainBuilder(IAccountService accountService)
        {
            _accountService = new AccountService();
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