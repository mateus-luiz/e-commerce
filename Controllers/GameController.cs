using System;
using e_commerce.Models;
using e_commerce.Repository;
using Microsoft.AspNetCore.Mvc;

namespace e_commerce.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _repository; 

        public GameController(IGameRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            List<GameModel> list = _repository.GetAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(GameModel game)
        {
            if(ModelState.IsValid)
            {
                _repository.Add(game);
                return RedirectToAction("Index");
            }

            return View(game);
        }

        public IActionResult Edit(int id){

            GameModel game = _repository.GetOne(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(GameModel game)
        {
            _repository.Edit(game);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            GameModel game = _repository.GetOne(id);
            return View(game);
        }

        public IActionResult ConfirmDelete(GameModel game)
        {
            _repository.Delete(game);
            
            return RedirectToAction("Index");
        }
    }
}