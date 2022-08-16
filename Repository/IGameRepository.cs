
using e_commerce.Models;

namespace e_commerce.Repository
{
    public interface IGameRepository
    {
        List<GameModel> GetAll();
        GameModel Add(GameModel game);
        GameModel GetOne(int id);
        GameModel Edit(GameModel game);
        bool Delete(GameModel game);
    }
}