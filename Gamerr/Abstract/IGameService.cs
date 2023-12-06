using Gamerr.Entities;

namespace Gamerr.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void Sale(Game game, User user, Campaign campaign);
    }
}
