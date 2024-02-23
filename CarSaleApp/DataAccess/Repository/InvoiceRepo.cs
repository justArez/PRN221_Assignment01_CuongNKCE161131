using BusinessObject;
using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InvoiceRepo: IInvoiceRepo
    {
        private static InvoiceRepo instance = null;
        private static readonly object instanceLock = new object();
        public static InvoiceRepo Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new InvoiceRepo();
                    }
                }
                return instance;
            }
        }
        public void AddInvoice(Invoice invoice) => InvoiceDAO.Instance.Add(invoice);

        public void DeleteInvoiceById(string id) => InvoiceDAO.Instance.Delete(id);

        public Invoice GetInvoiceById(string id) => InvoiceDAO.Instance.GetInvoiceByID(id);

        public IEnumerable<Invoice> GetInvoiceList() => InvoiceDAO.Instance.GetInvoiceList();

        public void UpdateInvoice(Invoice invoice) => InvoiceDAO.Instance.Update(invoice);
    }
}
