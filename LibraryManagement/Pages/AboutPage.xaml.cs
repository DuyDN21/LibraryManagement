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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryManagement.Pages
{
    /// <summary>
    /// Interaction logic for AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        Page about;
        Page regu;
        public AboutPage()
        {
            InitializeComponent();
            about= new AboutContent();
            regu= new Regulations();

            contentFrame.Navigate(about);
            bar.SelectedIndex = 0;
        }

        private void bar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (bar.SelectedIndex)
            {
                case 0:
                    contentFrame.Navigate(about);
                    break;
                case 1:
                    contentFrame.Navigate(regu);
                    break;
            }
        }
    }
}
