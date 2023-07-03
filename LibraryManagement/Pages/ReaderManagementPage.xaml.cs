using LibraryManagement.IRepository;
using LibraryManagement.Repository;
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
    /// Interaction logic for ReaderManagementPage.xaml
    /// </summary>
    public partial class ReaderManagementPage : Page
    {
        IStudentRepository studentRepository;
        public ReaderManagementPage()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();
            lvStudents.ItemsSource = studentRepository.GetStudents();
        }
    }
}
