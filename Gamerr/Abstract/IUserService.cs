using Gamerr.Entities;

namespace Gamerr.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
    }
}
