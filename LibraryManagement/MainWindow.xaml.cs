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
using LibraryManagement.Pages;

namespace LibraryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Page homePage;
        Page bookManagementPage;
        Page readerManagementPage;
        Page borrowBookPage;
        Page statisticPage;
        Page aboutPage;
        public MainWindow()
        {
            InitializeComponent();
            homePage = new HomePage();
            bookManagementPage = new BookManagementPage();
            readerManagementPage = new ReaderManagementPage();
            borrowBookPage = new BorrowBookPage();
            statisticPage = new StatisticPage();
            aboutPage = new AboutPage();
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (sidebar.SelectedIndex)
            {
                case 0:
                    navFrame.Navigate(homePage);
                    break;
                case 1:
                    navFrame.Navigate(bookManagementPage);
                    break;
                case 2:
                    navFrame.Navigate(readerManagementPage);
                    break;
                case 3:
                    navFrame.Navigate(borrowBookPage);
                    break;
                case 4:
                    navFrame.Navigate(statisticPage);
                    break;
                case 5:
                    navFrame.Navigate(aboutPage);
                    break;
            }
        }
    }
}
