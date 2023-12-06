using Gamerr.Entities;

namespace Gamerr.Abstract
{
    public interface ICampaignService
    {
         void Add(Campaign campaign);
         void Update(Game campaign);
         void Delete(Game campaign);
    }
}
