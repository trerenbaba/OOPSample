using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Services
{
    public class GoogleAddressService : ICompanyAddressService
    {
        public bool CheckAddress(string address)
        {
            //Google maps api kullanarak adres sorgulaması yapılacak.
            return false;
        }
    }
}
