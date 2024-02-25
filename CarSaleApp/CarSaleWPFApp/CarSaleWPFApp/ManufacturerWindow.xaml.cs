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
    /// Interaction logic for ManufacturerWindow.xaml
    /// </summary>
    public partial class ManufacturerWindow : Window
    {
        private User loginUser;

        private ManufacturerService manufacturerService;

        private ManufacturerService _manufacturerService()
        {
            if (this.manufacturerService == null)
            {
                this.manufacturerService = new ManufacturerService();
            }
            return this.manufacturerService;
        }

        public ManufacturerWindow(User _loginUser)
        {
            this.loginUser = _loginUser;
            InitializeComponent();
        }
    }
}
