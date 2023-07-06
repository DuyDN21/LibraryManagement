using LibraryManagement.DataAccess;
using LibraryManagement.IRepository;
using LibraryManagement.Repository;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for BorrowBookPage.xaml
    /// </summary>
    public partial class BorrowBookPage : Page
    {
        IBorrowBookRepository borrowBookRepository;
        public BorrowBookPage()
        {
            borrowBookRepository = new BorrowBookRepository();
            InitializeComponent();
            lvBorrows.ItemsSource = borrowBookRepository.GetBorrowList();
        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<BorrowBook> books = from s in myLibrary.BorrowBooks.Include(s => s.Student).Include(s => s.Book) select s;

            if (rd_bookid.IsChecked == true)
            {
                books = books.Where(s => s.BookId
                    .Contains(searchText.Text));
            }
            if(rd_studentid.IsChecked == true)
            {
                books = books.Where(s => s.StudentId
                    .Contains(searchText.Text));
            }
            lvBorrows.ItemsSource = books.ToList();
        }
    }
}
