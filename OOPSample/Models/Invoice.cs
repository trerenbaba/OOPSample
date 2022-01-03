using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSample.Models
{
    public class Invoice
    {
        public DateTime InvoiceDate { get;private set; }

        // faturayı kesen firma
        public Company Exporter { get;private set; }

        // mal hizmet alan firma
        public Company Consignee { get;private set; }

        public decimal TotalPrice { get;private set; }

        public List<InvoiceItem> _items = new List<InvoiceItem>();
        // list item readolny olarak işaretleyip sadece bu alanın get edibileceğinii söylemiş olduk.

        public IReadOnlyList<InvoiceItem> Items { get; set; }

        //
        //yukarıdaki kod aynı kod.
        //public IReadOnlyList<InvoiceItem> Items2
        //{
        //    get
        //    {
        //        return _items;
        //    }
        //}
        public string Id { get;private set; }


        //fatura kesmek için faturayı kesen ve fatura kesilen firma bilgilerini bilmemiz yeterlidir.
        public Invoice(Company exporter,Company consignee)
        {
            //fatura kesim tarihi işlem yapılan bir tarih olmalıdır.
            //dışarıdan bu bilgiyi almıyoruz.
            Id = Guid.NewGuid().ToString();
            InvoiceDate = DateTime.Now;
            Exporter = exporter;
            Consignee = consignee;
        }

        //faturaya fatura ile alakaklı hizmetlerin listesini eklediğimiz method
        public void AddInvoiceItem(InvoiceItem item)
        {
            //item eklemeden önce elmizdeki invoice item count üzerinden kaçıncı sırada olduğumuzu ildiğimizden için 
            item.SetSequenceNumber(Items.Count + 1);
            _items.Add(item);
            //her bir  item eklendiğinde bu item ait list priceların toplamı
            TotalPrice += item.ListPrice;
        }


    }
}
