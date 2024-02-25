using BusinessObject;
using BusinessService;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private UserService userService = null;

        private UserService _userService()
        {
            if (this.userService == null)
            {
                this.userService = new UserService();
            }
            return this.userService;
        }

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Text;

            if (!username.Trim().Equals(string.Empty) && !password.Trim().Equals(string.Empty))
            {
                User authenUser = _userService().AuthenticateUser(username, password);
                if (authenUser != null)
                {
                    new HomepageWindow(authenUser.Userid).Activate();
                    this.Close();
                } else if (authenUser != null && authenUser.Userid.IsNullOrEmpty())
                {
                    MessageBox.Show("Wrong password!", "Wrong password", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtUsernameLogin.Clear();
                    txtPasswordLogin.Clear();
                }
                else
                {
                    MessageBox.Show("User not existed!", "User not existed", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtPasswordLogin.Clear();
                }
            }
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameRegister.Text;
            string password = txtPasswordRegister.Text;

            try
            {
                if (!username.Trim().Equals(string.Empty) && !password.Trim().Equals(string.Empty))
                {
                    User _user = _userService().GetUserByUsername(username);
                    if (_user == null)
                    {
                        string userId = Guid.NewGuid().ToString();
                        User newUser = new User(userId, username, password);
                        _userService().AddUser(newUser);
                        MessageBox.Show("User registered!", "User registered", MessageBoxButton.OK, MessageBoxImage.Information);
                        txtUsernameRegister.Clear();
                        txtPasswordRegister.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Username existed!", "User existed", MessageBoxButton.OK, MessageBoxImage.Information);
                        txtUsernameRegister.Clear();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
