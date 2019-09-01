using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chats.Models;
using Chats.Data;
using Microsoft.AspNetCore.Identity;

namespace Chats.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db;

        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {           
            return View(await db.Topics.ToListAsync());
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
