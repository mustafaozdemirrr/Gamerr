using Gamerr.Abstract;
using Gamerr.Entities;

namespace Gamerr.Concrete
{
    public class UserManager : IUserService
    {
        IUserCheckService _userCheckService;

        public UserManager(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }

        public void Add(User user)
        {
            if (_userCheckService.CheckIfRealPerson(user))
                Console.WriteLine("Oyuncu eklendi");
            else
                throw new Exception("Not a valid person");
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
