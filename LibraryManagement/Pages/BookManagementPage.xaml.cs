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
        AddBookPage addBookPage;
        public BookManagementPage()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
            lvBooks.ItemsSource = bookRepository.GetBooks();

            addBookPage = new AddBookPage();
        }

        private void btn_AddClicked(object sender, RoutedEventArgs e)
        {
/*            try
            {
                Book b = GetBookObject();
                bookRepository.InsertBook(b);
                lvBooks.ItemsSource = bookRepository.GetBooks();
                MessageBox.Show("Insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert fail");
            }*/
        }

        private void btn_EditClicked(object sender, RoutedEventArgs e)
        {
/*            try
            {
                Book b = GetBookObject();
                bookRepository.UpdateBook(b);
                lvBooks.ItemsSource = bookRepository.GetBooks();
                MessageBox.Show("Insert successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert fail");
            }*/
        }

        private void btn_SearchClicked(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<Book> books = from s in myLibrary.Books.Include(s=>s.Author).Include(s => s.Publisher).Include(s => s.Category) select s;
                books = books.Where(s => s.BookName
                    .Contains(search_bookName.Text) &&  s.Author.AuthorName.Contains(search_author.Text));
            if(cboCategory.SelectedItem != null)
            {
                books = books.Where(s => s.CategoryId == Int32.Parse(cboCategory.SelectedValue.ToString()));
            }
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

        private void btn_RefreshClicked(object sender, RoutedEventArgs e)
        {
            cboCategory.SelectedIndex = -1;
            sortAmount.IsChecked =false;
            sortAsc.IsChecked = false;
            sortDes.IsChecked = false;
            sortName.IsChecked = false;
            search_author.Text = "";
            search_bookName.Text = "";
            lvBooks.ItemsSource = bookRepository.GetBooks();

        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var myLibrary = new LibraryManagementContext();
            IQueryable<BookCategory> categories = from s in myLibrary.BookCategories select s;
            cboCategory.ItemsSource = categories.ToList();
            cboCategory.DisplayMemberPath = "CategoryName";
            cboCategory.SelectedValuePath = "CategoryId";


        }
/*        private Book GetBookObject()
        {
            Book b = null;
            try
            {
                b = new Book
                {
                    BookId = tb_BookId.Text,
                    BookName = tb_BookName.Text,
                    Amount = Int32.Parse(tb_Amount.Text),
                    CategoryId = Int32.Parse(cboCategory_edit.SelectedValue.ToString()),
                    AuthorId = cboAutor.SelectedValue.ToString(),
                    PublisherId = cboPublisher.SelectedValue.ToString()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get book");
            }
            return b;
        }*/
    }
}
