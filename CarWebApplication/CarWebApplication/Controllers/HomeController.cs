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
        private IDataSource _dataSource;
        private IUserData _userData;



        public HomeController(ILogger<HomeController> logger, 
            ISingletonOperation singletonOperation, 
            ITransientOperation transientOperation, 
            IScopedOperation scopedOperation, 
            IMyService myservice,
            IDataSource dataSource,
            IUserData userData)
        {
            _singletonOperation = singletonOperation;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _myService = myservice;
            _logger = logger;
            _dataSource = dataSource;
            _userData = userData;
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
        public IActionResult Login(LoginViewModel users)
        {
            IDataSource jsonData = new JsonDataSource();
            
            _userData = new UserData();
            _userData.DataSource = jsonData;
            _userData.UserViewModel = users;

            var checkLogin = _userData.CheckLoginUser();
            return View();
        }

        [ResponseCache(Duration =0, Location = ResponseCacheLocation.None, NoStore =true)]
        public IActionResult Error()
        {
            return View();
        }


    }
}
