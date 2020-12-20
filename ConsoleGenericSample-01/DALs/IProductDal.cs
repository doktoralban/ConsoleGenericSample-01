using ConsoleGenericSample_01.Models;
using ConsoleGenericSample_01.Repositorys;
using System;

namespace ConsoleGenericSample_01.DALs
{
    public interface IProductDal : IRepository<Product>
    {
        double TotalProductionAmaount(int id, DateTime startDate, DateTime endDate);
    }



}
