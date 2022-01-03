using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Services
{
    //vergi numarası sorgulama servisi
    //gerçekte böyle bir vergi numarası olıp olmadığının sorgulamak için yazdık.
    public interface ITaxNumberLookUpService
    {
        //bizim bir vergi numarası sorgulama sistemimiz olsun.
        //bu sorgulama sisteminin nasıl çalıştığını bilmiyoruz yada farklı şekillerde sorgulama olabilir sistemde bu sebeple işin özetini yazıp detayını ise  ilgili servislerde yazacağız yani (Abstraction)
        bool LookUp(string taxNumber);
    }
}
