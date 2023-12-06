using Gamerr.Abstract;
using Gamerr.Entities;
using MernisServiceReference;

namespace Gamerr.Adapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName, user.LastName, user.DateOfBirth.Year);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
