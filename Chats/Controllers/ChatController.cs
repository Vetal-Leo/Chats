using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chats.Data;
using Microsoft.AspNetCore.Mvc;

namespace Chats.Controllers
{
    public class ChatController : Controller
    {
        private ApplicationDbContext db;
        public ChatController(ApplicationDbContext context)
        {
            db = context;
        }

        //  [Authorize]
        public IActionResult Chat()
        {
            return View();
        }
    }
}