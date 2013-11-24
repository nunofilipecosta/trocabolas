using System;
using System.Web.Mvc;
using System.Web.Security;
using TrocaBolas.Domain.Entities;
using TrocaBolas.Domain.Services;
using TrocaBolas.Web.Builders;
using TrocaBolas.Web.Builders.DomainBuilders;
using TrocaBolas.Web.Builders.ViewModelBuiders;
using TrocaBolas.Web.Models;
using Umbraco.Web.Mvc;

namespace TrocaBolas.Web.Controllers
{
    public class RegisterSurfaceController : SurfaceController
    {
        private readonly IAccountService _accountService;

        private readonly IViewModelBuilder<TrocaBolasUser, RegisterViewModel> _viewModelBuilder;

        private readonly IDomainBuilder<RegisterViewModel, TrocaBolasUser> _domainBuilder;

        public RegisterSurfaceController(
            IAccountService accountService,
            IViewModelBuilder<TrocaBolasUser, RegisterViewModel> viewModelBuilder,
            IDomainBuilder<RegisterViewModel, TrocaBolasUser> domainBuilder)
        {
            _accountService = _accountService;
            _domainBuilder = _domainBuilder;
            _viewModelBuilder = _viewModelBuilder;

        }

        public RegisterSurfaceController()
        {
            _accountService = new AccountService();
            _domainBuilder = new TrocaBolasUserDomainBuilder(_accountService);
            _viewModelBuilder = new RegisterViewModelBuilder(_accountService);
        }

        public PartialViewResult Register()
        {
            var viewModel = _viewModelBuilder.Build(Guid.Empty);

            return PartialView("_RegisterForm", viewModel);
        }

        [HttpPost]
        public PartialViewResult PostRegisterForm(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = _domainBuilder.Build(viewModel);

                    _accountService.Register(currentUser, viewModel.Password);

                    TempData["RegisterWithSuccess"] = true;

                    //return RedirectToCurrentUmbracoPage();
                    return PartialView("_RegisterForm", viewModel);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    // TODO : add exception to ModelState
                }
            }

            return PartialView("_RegisterForm", viewModel);
        }

        public PartialViewResult Login()
        {
            var model = new LoginViewModel();

            return PartialView("_LoginForm", model);
        }

        [HttpPost]
        public ActionResult PostLoginForm(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var isValid = _accountService.Validate(viewModel.UserName, viewModel.Password);
                    if (isValid)
                    {
                        FormsAuthentication.SetAuthCookie(viewModel.UserName, viewModel.Remember);
                        return RedirectToCurrentUmbracoPage();
                    }

                    ModelState.AddModelError("", "Username / Password inválidos");
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("Business", exception);
                }
            }

            return CurrentUmbracoPage();
        }

        [HttpPost]
        public PartialViewResult PostLogoutForm()
        {
            return new PartialViewResult();
        }


    }
}