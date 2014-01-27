﻿using System.Web.Mvc;

namespace Tripod.Web.Controllers
{
    public partial class UserController : Controller
    {
        [HttpGet, Route("users/{userId:int}")]
        public virtual ActionResult ById(int userId)
        {
            return View(MVC.Security.Views.User);
        }
    }
}