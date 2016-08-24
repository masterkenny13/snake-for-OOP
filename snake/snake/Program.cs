using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.x = 3;
            p1.y = 1;
            p1.sym = '4';
            p1.Drow();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 8;
            p2.sym = '*';
            p2.Drow();
            Console.ReadLine();
        }
    }
}
