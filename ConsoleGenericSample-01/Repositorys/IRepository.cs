using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGenericSample_01.Repositorys
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entitiy);
        void Delete(T entitiy);
        void Update(T entitiy);
    }





}
