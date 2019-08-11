using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chats.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Chats.Controllers
{
    public class SearchController : Controller
    {
        private ApplicationDbContext db;
        public SearchController(ApplicationDbContext context)
        {
            db = context;
        }
        //  [Authorize]
        public async Task<IActionResult> Search(int id)
        {
            var topics = await db.Topics.ToListAsync();
            var topic = topics[id - 1].Topic;
            ViewData["Head"] = topic;
            return View();
        }
    }
}