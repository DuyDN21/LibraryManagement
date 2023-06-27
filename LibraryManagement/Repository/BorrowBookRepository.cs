using LibraryManagement.DataAccess;
using LibraryManagement.IRepository;
using LibraryManagement.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository
{
    internal class BorrowBookRepository : IBorrowBookRepository
    {
        public void DeleteBorrowBook(BorrowBook borrow)=> BorrowBookManagement.Instance.AddNew(borrow);

        public BorrowBook GetBorrowBook(string bookId, string studentId)=>BorrowBookManagement.Instance.GetBorrowBook(bookId, studentId);

        public IEnumerable<BorrowBook> GetBorrowList() => BorrowBookManagement.Instance.GetBorrowBookList();

        public void InsertBorrowBook(BorrowBook borrow) => BorrowBookManagement.Instance.AddNew(borrow);

        public void UpdateBorrowBook(BorrowBook borrow) => BorrowBookManagement.Instance.Update(borrow);
    }
}
