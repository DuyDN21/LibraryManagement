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
using LibraryManagement.DataAccess;
using LibraryManagement.Management;

namespace LibraryManagement
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow _mainWindow;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Int32.Parse(txtUser.Text);
                String password = txtPass.Password;

                bool isAdmin = AdminManagement.Instance.AdminLogin(id, password);
                if (isAdmin)
                {
                    _mainWindow = new MainWindow();
                    _mainWindow.Show();
                    this.Close();
                }
                else
                {
                    txtFail.Visibility = Visibility.Visible;
                }
            }
            catch(Exception ex)
            {
                txtFail.Visibility = Visibility.Visible;
                //MessageBox.Show(ex.Message);
            }
            
        }
    }
}
