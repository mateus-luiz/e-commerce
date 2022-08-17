using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_commerce.Models;
using e_commerce.Data;

namespace e_commerce.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly Context _context;

        public GameRepository(Context context)
        {
            _context = context;
        }

        public List<GameModel> GetAll()
        {
            return _context.Games.ToList();
        }

        public GameModel Add(GameModel game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();
            return game;
        }

        public GameModel GetOne(int id)
        {
            GameModel game = _context.Games.FirstOrDefault(x => x.Id == id);
            return game;
        }

        public GameModel Edit(GameModel game)
        {
            GameModel dbGame = GetOne(game.Id);
            if(dbGame == null) throw new Exception("Error editing game!");

            dbGame.Name = game.Name;
            dbGame.Price = game.Price;
            dbGame.Developer = game.Developer;
            dbGame.Description = game.Description;
            dbGame.ArtUrl = game.ArtUrl;

            _context.Games.Update(dbGame);
            _context.SaveChanges();

            return dbGame;
        }

        public bool Delete(GameModel game)
        {
            GameModel dbGame = GetOne(game.Id);
            if(dbGame == null) throw new Exception("Error deleting game!");

            _context.Remove(dbGame);
            _context.SaveChanges();
            
            return true;
        }
    }
}