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
    /// Interaction logic for BookManagementPage.xaml
    /// </summary>
    public partial class BookManagementPage : Page
    {
        IBookRepository bookRepository;
        public BookManagementPage()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
            lvBooks.ItemsSource = bookRepository.GetBooks();
        }

        private void btn_AddClicked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_EditClicked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<Book> books = from s in myLibrary.Books.Include(s=>s.Author) select s;
            //if (!String.IsNullOrEmpty(search_bookName.Text))
            //{
                books = books.Where(s => s.BookName
                    .Contains(search_bookName.Text) &&  s.Author.AuthorName
                    .Contains(search_author.Text));
            //}
            lvBooks.ItemsSource = books.ToList();
        }

        private void btn_RefreshClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<Book> books = from s in myLibrary.Books.Include(books => books.Category).Include(books => books.Publisher).Include(books => books.Author) select s;
            if (sortName.IsChecked == true)
            {
                if (sortAsc.IsChecked == true)
                {
                    books = books.OrderBy(s => s.BookName);
                }
                if (sortDes.IsChecked == true)
                {
                    books = books.OrderByDescending(s => s.BookName);
                }
            }
            if (sortAmount.IsChecked == true)
            {
                if (sortAsc.IsChecked == true)
                {
                    books = books.OrderBy(s => s.Amount);
                }
                if (sortDes.IsChecked == true)
                {
                    books = books.OrderByDescending(s => s.Amount);
                }
            }
            lvBooks.ItemsSource = books.ToList();
        }
    }
}
