
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InvoiceService: IInvoiceService
    {
        public void AddInvoice(Invoice invoice) => InvoiceRepo.Instance.AddInvoice(invoice);

        public void DeleteInvoiceById(string id) => InvoiceRepo.Instance.DeleteInvoiceById(id);

        public Invoice GetInvoiceById(string id) => InvoiceRepo.Instance.GetInvoiceById(id);

        public IEnumerable<Invoice> GetInvoiceList() => InvoiceRepo.Instance.GetInvoiceList();

        public void UpdateInvoice(Invoice invoice) => InvoiceRepo.Instance.UpdateInvoice(invoice);
    }
}
