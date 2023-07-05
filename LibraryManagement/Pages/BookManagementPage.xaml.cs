﻿using LibraryManagement.IRepository;
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

        }

        private void btn_RefreshClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
