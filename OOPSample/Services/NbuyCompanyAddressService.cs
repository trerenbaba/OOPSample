using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Services
{
    //şirketin kayıt işlemleri register işlemleri sırasında böyle bir adresin olup olmadığını teyit etmek için sorgulama yapan servis.
    //Bu sorgulama servisi şuan için bir liste üzerinden kontrol edilecek olup ilerleyen zamanlarda e-devlet adres sorgulama sistemine bağlanabilir.
    public class NbuyCompanyAddressService : ICompanyAddressService
    {
        List<string> companyAddress = new List<string>();

        public NbuyCompanyAddressService()
        {
            companyAddress.Add("Levazım, Koru Sokağı No:2, 34340 Beşiktaş/İstanbul");
            companyAddress.Add("Bulgurlu, Alemdağ Cd No:100, 34696 Üsküdar/İstanbul");
            companyAddress.Add("Meşrutiyet, Halaskargazi Cd. No:140, 34363 Şişli/İstanbul");
        }

        public bool CheckAddress(string address)
        {
            //Any true false döner. Entity Framework'de de yapılabiliyor.
            return companyAddress.Any(cAddress => cAddress == address);

        }
    }
}
