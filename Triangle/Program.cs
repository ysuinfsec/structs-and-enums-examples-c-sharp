using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(1, 1, 1);
            Triangle t2 = new Triangle(2, 2, 3);
            Triangle t3 = new Triangle(4, 2, 3);

            Console.WriteLine(t1.GetType());
            Console.WriteLine(t2.GetType());
            Console.WriteLine(t3.GetType());

        }
    }

}
