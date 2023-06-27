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
    internal class StudentRepository : IStudentRepository
    {
        public Student GetStudenByID(string studentId)=> StudentManagement.Instance.GetBookCategoryByID(studentId);

        public IEnumerable<Student> GetStudents() => StudentManagement.Instance.GetBookCategoryList();
    }
}
