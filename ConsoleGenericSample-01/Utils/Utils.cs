using System.Collections.Generic;

namespace ConsoleGenericSample_01.Utils
{
    public class Utils
    {

        public  List<T> BuildListGen<T>(params T[] items)
        {
            return new List<T>(items);
        }


    }
}
