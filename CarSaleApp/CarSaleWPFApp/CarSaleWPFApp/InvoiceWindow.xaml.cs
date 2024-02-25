using BusinessObject;
using BusinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarSaleWPFApp
{
    /// <summary>
    /// Interaction logic for InvoiceWindow.xaml
    /// </summary>
    public partial class InvoiceWindow : Window
    {
        private User loginUser;

        private InvoiceService invoiceService = null;

        private InvoiceService _invoiceService()
        {
            if (this.invoiceService == null)
            {
                this.invoiceService = new InvoiceService();
            }
            return this.invoiceService;
        }

        public InvoiceWindow(User _loginUser)
        {
            this.loginUser = _loginUser;
            InitializeComponent();
        }
    }
}
