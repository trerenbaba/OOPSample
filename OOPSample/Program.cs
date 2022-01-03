using OOPSample.Models;
using OOPSample.Services;
using System;

namespace OOPSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not:Company Address Service ve TaxNumberLookUpService farklı şekillerde sorgulama yapabilme kabiliyetine sahip olsunlar diye company constructor içerisinde interfaceler üzerinden bağlantı kuruldu bu sayede company constructor içerisinde gönderilen classlara ile adapte bir  şekilde çalışması sağlandı.. Polymophism interface vasıtası ile uygulandı.
            var company = new Company(name: "NBUY LTD ŞTİ",
                address: "Levazım, Koru Sokağı No:2, 34340 Beşiktaş/İstanbul",
                taxNumber: "232323",
                companyAddressService: new NbuyCompanyAddressService(),
                taxNumberLookUpService: new NBuyTaxNumberLookUpService()
                );
            company.SetPhoneNumber("0(212) 346 1010");
            

            Console.WriteLine("Hello World!");
        }
    }
}
