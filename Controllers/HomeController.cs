using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_commerce.Models;

namespace e_commerce.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
