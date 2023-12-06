using Gamerr.Entities;

namespace Gamerr.Abstract
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
