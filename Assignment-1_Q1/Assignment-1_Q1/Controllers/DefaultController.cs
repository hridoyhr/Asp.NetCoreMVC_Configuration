using Assignment_1_Q1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_1_Q1.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ILogger<DefaultController> _logger;
        public DefaultController(ILogger<DefaultController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            _logger.LogInformation("Hello World");
            return View();
        }

    }
}
