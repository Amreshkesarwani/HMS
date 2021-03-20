using BusinessEntities.RequestDto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Controllers
{
    public class AccountController : Controller
    {

        #region Global variable
        private readonly ILogger<AccountController> _logger;

        #endregion

        #region constructor
        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        #endregion


        #region login and logout functionality

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequest viewModel)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Account");
        }

        #endregion
    }
}
