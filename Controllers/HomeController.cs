using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using e_commerce.Models;
using e_commerce.Repository;

namespace e_commerce.Controllers;

public class HomeController : Controller
{
    private readonly IGameRepository _gameRepository;
    
    public HomeController(IGameRepository repository)
    {
        _gameRepository = repository;
    }

    public IActionResult Index()
    {
        List<GameModel> list = _gameRepository.GetAll();
        
        return View(list);
    }

    public IActionResult Game(int id)
    {
        GameModel game = _gameRepository.GetOne(id);
        return View(game);
    }
}
