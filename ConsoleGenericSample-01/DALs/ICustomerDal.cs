using ConsoleGenericSample_01.Models;
using ConsoleGenericSample_01.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenericSample_01.DALs
{
    public interface ICustomerDal : IRepository<Customer>
    {
        double TotalOrderAmaount(int id,DateTime startDate,DateTime endDate);
    }



}
