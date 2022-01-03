using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Services
{
    public class NBuyTaxNumberLookUpService : ITaxNumberLookUpService
    {
        public List<string> _taxNumber
        {
            get
            {
                return new List<string> {
                    "232323", 
                    "232323",
                    "43543", 
                    "233456", 
                    "5447453"
                };
            }
        }
        public bool LookUp(string taxNumber)
        {
            return _taxNumber.Any(x => x == taxNumber);
        }
    }
}
