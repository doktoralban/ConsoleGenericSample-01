using ConsoleGenericSample_01.Models;
using System;

namespace ConsoleGenericSample_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var utl = new Utils.Utils(); 

            foreach (var c in utl.BuildListGen(new Customer { CustomerName = "Aydın Türker" }
            , new Customer { CustomerName = "Ayşe Güneş" }))
            {
                Console.WriteLine(c.CustomerName);
            }


            Console.ReadLine();
        } 


           
    }




}
