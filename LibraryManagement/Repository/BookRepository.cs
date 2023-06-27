﻿using LibraryManagement.DataAccess;
using LibraryManagement.IRepository;
using LibraryManagement.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository
{
    internal class BookRepository : IBookRepository
    {
        public Book GetBookByID(string bookId)=>BookManagement.Instance.GetBookByID(bookId);

        public IEnumerable<Book> GetBooks()=>BookManagement.Instance.GetBookList();

        public void InsertBook(Book book)=> BookManagement.Instance.AddNew(book);

        public void UpdateBook(Book book) => BookManagement.Instance.Update(book);
    }
}
