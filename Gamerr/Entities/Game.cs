namespace Gamerr.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public int CompaignId { get; set; }
        public string GameName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Campaign Campaign { get; set; }
    }
}
