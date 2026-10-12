using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Podstawy
{
    public class Math
    {
        public int Add(int a, int b) => a + b;

        public int Max(int a, int b) => (a > b) ? a : b;

        //limit 5
        //1, 3, 5
        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i % 2 != 0)
                    yield return i;
            }
        }
    }
}
