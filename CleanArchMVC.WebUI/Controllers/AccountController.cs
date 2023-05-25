using CleanArchMVC.Domain.Account;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMVC.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthenticate _authentication;
        public AccountController(IAuthenticate authenticate)
        {
            _authentication = authenticate;
        }
    }
}
