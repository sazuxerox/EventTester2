using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var e = new EventTest(5);
            e.SetValue(7);
            e.SetValue(11);
            Console.ReadKey();
        }
    }
}
