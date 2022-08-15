using System;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}