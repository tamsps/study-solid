using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWebApplication.Models;
using CarWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly ITransientOperation _transientOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly IMyService _myService;
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger, ISingletonOperation singletonOperation, ITransientOperation transientOperation, IScopedOperation scopedOperation, IMyService myservice)
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _myService = myservice;
            _logger = logger;



        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users users)
        {

            return View();
        }

        [ResponseCache(Duration =0, Location = ResponseCacheLocation.None, NoStore =true)]
        public IActionResult Error()
        {
            return View();
        }


    }
}
