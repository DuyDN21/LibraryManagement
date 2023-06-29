using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (sidebar.SelectedIndex)
            {
                case 0:
                    navFrame.Navigate("/Pages/HomePage.xaml");
                    break;
                case 1:
                    navFrame.Navigate("/Pages/BookManagementPage.xaml");
                    break;
                case 2:
                    navFrame.Navigate("/Pages/ReaderManagementPage.xaml");
                    break;
                case 3:
                    navFrame.Navigate("/Pages/BorrowBookPage.xaml");
                    break;
                case 4:
                    navFrame.Navigate("/Pages/StatisticPage.xaml");
                    break;
                case 5:
                    navFrame.Navigate("/Pages/AboutPage.xaml");
                    break;
            }
        }
    }
}
