using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HMS.Areas.UserManagement.Controllers
{
    [Area("UserManagement")]
    [Route("UserManagement/[controller]/[action]")]
    public class UserManagementController : Controller
    {

        [HttpGet]
        public IActionResult List()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Add()
        //{
        //    return View();
        //}
    }
}
