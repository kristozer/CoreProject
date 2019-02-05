using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.Controllers
{
    public class HomeController : Controller
    {
        Context db;
        public HomeController(Context context)
        {
            this.db = context;
        }
        public async Task<IActionResult> Index(SortState sortOrder = SortState.NameAsc)
        {
            IQueryable<User> users = db.Users.Include(x=>x.Company);
 
            switch (sortOrder)
            {
                case SortState.NameDesc:
                    users = users.OrderByDescending(s => s.Name);
                    break;
                case SortState.AgeAsc:
                    users = users.OrderBy(s => s.Age);
                    break;
                case SortState.AgeDesc:
                    users = users.OrderByDescending(s => s.Age);
                    break;
                case SortState.CompanyAsc:
                    users = users.OrderBy(s => s.Company.Name);
                    break;
                case SortState.CompanyDesc:
                    users = users.OrderByDescending(s => s.Company.Name);
                    break;
                default:
                    users = users.OrderBy(s => s.Name);
                    break;
            }
            IndexViewModel viewModel = new IndexViewModel
            {
                Users = await users.AsNoTracking().ToListAsync(),
                SortViewModel = new SortViewModel(sortOrder)
            };
            return View(viewModel);
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
        public IActionResult Person()
        {
            var p = new Person{Name="TTT", Date=DateTime.Now};
            return View(p);
        }
    }
}
