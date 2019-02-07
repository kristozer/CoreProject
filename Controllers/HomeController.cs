using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoreProject.Services;
using CoreProject.Data;

namespace CoreProject.Controllers
{
    public class HomeController : Controller
    {
        Context db;
        public HomeController(Context context)
        {
            this.db = context;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUsers(int? company, string name)
        {
            
                return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
