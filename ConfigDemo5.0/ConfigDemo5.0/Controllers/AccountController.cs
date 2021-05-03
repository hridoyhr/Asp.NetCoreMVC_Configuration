using ConfigDemo5._0.Models.Special;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConfigDemo5._0.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignIn()
        {
            var model = new AccountModel();
            return View(model);
        }
    }
}
