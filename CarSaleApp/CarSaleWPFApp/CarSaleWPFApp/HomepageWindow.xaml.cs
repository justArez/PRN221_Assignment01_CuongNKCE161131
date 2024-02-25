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
    /// Interaction logic for HomepageWindow.xaml
    /// </summary>
    public partial class HomepageWindow : Window
    {
        private User loginUser = null;

        private UserService userService = null;

        private UserService _userService()
        {
            if (this.userService == null)
            {
                this.userService = new UserService();
            }
            return this.userService;
        }

        public HomepageWindow(string userId)
        {
            this.loginUser = _userService().GetUserById(userId);
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new LoginWindow().Activate();
        }

        private void btnCar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new CarWindow(this.loginUser).Activate();
        }

        private void btnInvoice_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new InvoiceWindow(this.loginUser).Activate();
        }

        private void btnManu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new ManufacturerWindow(this.loginUser).Activate();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            new UserWindow().Activate();
        }
    }
}
