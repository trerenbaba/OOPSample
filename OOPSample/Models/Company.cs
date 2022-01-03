using OOPSample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Models
{
    public class Company
    {
        
        public string Name { get; private set; }
        public string Address { get; private set; }
        //Vergi No
        public string TaxNumber { get; private set; }
        //Şirket hattı
        public string PhoneNumber { get; private set; }
        //adresleri sisteme company olarak girmeden önce bu servis ile adres sorgulaması yapacağız.
        //private field
        private ICompanyAddressService _companyAddressService;
        private ITaxNumberLookUpService _taxNumberLookUpService;
        public Company(string name,string address,string taxNumber,ICompanyAddressService companyAddressService, ITaxNumberLookUpService taxNumberLookUpService)
        {
            _companyAddressService = companyAddressService;
            _taxNumberLookUpService = taxNumberLookUpService;
            SetCompanyName(name);
            SetAddress(address);
            SetTaxNumber(taxNumber);
        }

        private void SetAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new Exception("Adres alanı boş geçilemez");
            }
            if (address.Length<20)
            {
                throw new Exception("Minimum 20 karakterden oluşmalıdır.");
            }
            //AddressService ile bu adresin gerçekte olup olmadığımı teyit etmemiz gerekebilir.
            var result = _companyAddressService.CheckAddress(address);
            //adres onaylanmadıysa hata ver.
            if (result==false)
            {
                throw new Exception("Böyle bir adres sistemde bulunamamıştır");
            }

            Address = address.Trim();
        }

        private void SetCompanyName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Şirket adı boş geçilemez.");
            }
            //kulanıcı input içerisinden Name alanını ön arkasında boşluk girilebilir bu boşlukları sisteme girmeden önce kaldırıyoruz.
            Name = name.Trim();
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
            {
                throw new Exception("telefon numarası boş bırakılamaz.");
            }
            PhoneNumber = phoneNumber;
        }
        private void SetTaxNumber(string taxNumber)
        {
            var result = _taxNumberLookUpService.LookUp(taxNumber);
            if (!result)
            {
                throw new Exception("Bölye bir vergi no sistemde yok");
            }
            TaxNumber = taxNumber;
        }

    }
}
