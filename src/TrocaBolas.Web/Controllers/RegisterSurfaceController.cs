using System;
using System.Web.Mvc;
using System.Web.Security;
using TrocaBolas.Domain.Entities;
using TrocaBolas.Web.Builders;
using TrocaBolas.Web.Builders.DomainBuilders;
using TrocaBolas.Web.Builders.ViewModelBuiders;
using TrocaBolas.Web.Models;
using Umbraco.Web.Mvc;

namespace TrocaBolas.Web.Controllers
{
    using System.ComponentModel;
    using Infrastructure.Services;

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
            _accountService = accountService;
            _domainBuilder = domainBuilder;
            _viewModelBuilder = viewModelBuilder;
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
        public ActionResult PostRegisterForm(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var currentUser = _domainBuilder.Build(viewModel);

                    _accountService.Register(currentUser, viewModel.Password);

                    TempData["RegisterWithSuccess"] = true;

                    return Redirect("~/");
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError(string.Empty, exception);
                }
            }

            return CurrentUmbracoPage();
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
                        return Redirect("~/");
                    }

                    ModelState.AddModelError(string.Empty, "Username / Password inválidos");
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("Business", exception);
                }
            }

            return CurrentUmbracoPage();
        }

        [HttpPost]
        public RedirectToUmbracoPageResult PostLogoutForm()
        {
            FormsAuthentication.SignOut();
            return RedirectToCurrentUmbracoPage();
        }

        [HttpGet]
        [Authorize]
        public ActionResult Edit()
        {
            var viewModel = new EditViewModel();

            throw new InvalidAsynchronousStateException();

            //return PartialView("_EditForm", viewModel);
        }

        [HttpPost]
        public ActionResult EditForm(EditViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TempData["RegisterWithSuccess"] = true;
                    return CurrentUmbracoPage();
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("Business", exception);
                }
            }

            return CurrentUmbracoPage();
        }
    }
}