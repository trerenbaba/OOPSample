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
            //var company = new Company(name: "NBUY LTD ŞTİ",
            //    address: "Levazım, Koru Sokağı No:2, 34340 Beşiktaş/İstanbul",
            //    taxNumber: "232323",
            //    companyAddressService: new NbuyCompanyAddressService(),
            //    taxNumberLookUpService: new NBuyTaxNumberLookUpService()
            //    );
            //company.SetPhoneNumber("0(212) 346 1010");

            var company1 = new Company(name: "NBUY LTD ŞTİ",
                address: "Bulgurlu, Alemdağ Cd No:100, 34696 Üsküdar/İstanbul",
                taxNumber: "43543",
                companyAddressService: new NbuyCompanyAddressService(),
                taxNumberLookUpService: new NBuyTaxNumberLookUpService()
                );
            var company2 = new Company(name: "NBUY İzmir LTD ŞTİ",
                address: "Meşrutiyet, Halaskargazi Cd. No:140, 34363 Şişli/İstanbul",
                taxNumber: "233456",
                companyAddressService: new NbuyCompanyAddressService(),
                taxNumberLookUpService: new NBuyTaxNumberLookUpService()
                );

            var invoice = new Invoice(exporter: company1, consignee: company2);


            //var invoice2 = new Invoice(exporter: company1, consignee: company2);
            //invoice2.add

            

            invoice.AddInvoiceItem(
                new InvoiceItem(
                description: "Tasarım Bedeli",
                unitPrice: 1000,
                unitType: InvoiceUnitType.Daily,
                amount: 5
                ));
            invoice.AddInvoiceItem(new InvoiceItem(
                description: "Yazalım Bedeli",
                unitPrice: 300,
                unitType: InvoiceUnitType.Daily,
                amount: 8
                ));

            invoice.AddInvoiceItem(new InvoiceItem(
                description: "Sosyal Medya Hizmet Bedeli",
                unitPrice: 5000,
                unitType: InvoiceUnitType.Monthly,
                amount: 1
                ));


            Console.WriteLine("Hello World!");
        }
    }
}
