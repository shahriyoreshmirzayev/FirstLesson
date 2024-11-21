using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._5_dars
{
    static class Calculatorr<T>
    {
        public static T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}
