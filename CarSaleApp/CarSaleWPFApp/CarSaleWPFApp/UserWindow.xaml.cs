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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        private User loginUser;

        private UserService userService;

        private UserService _userService()
        {
            if (this.userService == null)
            {
                this.userService = new UserService();
            }
            return this.userService;
        }

        public UserWindow()
        {
            InitializeComponent();
        }

    }
}
