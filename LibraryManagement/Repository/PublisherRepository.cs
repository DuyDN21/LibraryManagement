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
    internal class PublisherRepository : IPublisherRepository
    {
        public Publisher GetPublisherByID(string publisher)=>PublisherManagement.Instance.GetPublisherByID(publisher);

        public IEnumerable<Publisher> GetPublishers() => PublisherManagement.Instance.GetPublisherList();
    }
}
