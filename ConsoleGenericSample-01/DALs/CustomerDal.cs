using ConsoleGenericSample_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenericSample_01.DALs
{
    public class CustomerDal : ICustomerDal
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public double TotalOrderAmaount(int id, DateTime startDate, DateTime endDate)
        {
            return 120.256;
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
