using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExamplePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(1, 2);
            ChangeX(point);
            Console.WriteLine(point.X + " " + point.Y);

            PointStruct pointStruct = new PointStruct(1, 2);
            ChangeX(pointStruct);
            Console.WriteLine(pointStruct.X + " " + pointStruct.Y);
        }

        static void ChangeX(Point p)
        {
            p.X = 5;
        }

        static void ChangeX(PointStruct p)
        {
            p.X = 5;
        }
    }
}
