﻿using Microsoft.AspNetCore.Mvc;

namespace Fairy_project.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MyTicket()
        {
            return View();
        }
    }
}
