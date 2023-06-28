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
    internal class AdminRepository : IAdminRepository
    {
        public bool AdminLogin(int adminId, string pass) => AdminManagement.Instance.AdminLogin(adminId, pass);

        public Admin GetAdminByID(int adminId)=>AdminManagement.Instance.GetAdminByID(adminId);
    }
}
