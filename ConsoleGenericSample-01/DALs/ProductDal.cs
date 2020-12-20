using ConsoleGenericSample_01.Models;
using System;
using System.Collections.Generic;

namespace ConsoleGenericSample_01.DALs
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public double TotalProductionAmaount(int id, DateTime startDate, DateTime endDate)
        {
            return 350.89;
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
