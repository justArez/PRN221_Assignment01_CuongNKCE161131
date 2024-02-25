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
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        private User loginUser;

        private CarService carService = null;

        public IEnumerable<Car> carList;

        private CarService _carService()
        {
            if (this.carService == null)
            {
                this.carService = new CarService();
            }
            return this.carService;
        }

        public CarWindow(User _loginUser)
        {
            this.loginUser = _loginUser;
            InitializeComponent();
        }

        public void LoadCarList()
        {
            carList = _carService().GetCarList();
        }

        private void btnReload_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
