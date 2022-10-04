using GameBackendMiniProject.Abstract;
using GameBackendMiniProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackendMiniProject.Adapters
{
    public class MernisServiceAdapter : ICheckUserManager
    {
        public bool CheckIfRealPerson(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            // return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.IdentityNo), user.FirstName.ToUpper(), user.LastName.ToUpper(), user.BirthYear);  Bu şekilde hata veriyor.
            var result = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.IdentityNo), user.FirstName.ToUpper(),user.LastName.ToUpper(), user.BirthYear).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
