// See https://aka.ms/new-console-template for more information
using Gamerr.Adapters;
using Gamerr.Concrete;
using Gamerr.Entities;

Console.WriteLine("Hello, World!");

User user = new User()
{
    Id = 1,
    FirstName = "Mustafa",
    LastName = "Özdemir",
    DateOfBirth = new DateTime(1995, 06, 26),
    NationalityId = "0000000"
};
UserManager userManager = new UserManager(new MernisServiceAdapter());
userManager.Add(user);
Game game = new Game()
{
    Id = 1,
    CompaignId = 1,
    GameName = "Counter Strike",
    Price = 1000,
    Description = "Savaş oyunu"
};
Campaign campaign = new Campaign()
{
    Id = 1,
    DiscountRate = 50,
    Name = "Kasım İndirimi"
};



