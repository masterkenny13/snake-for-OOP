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

            Point p1 = new Point(1, 5, '*');
            p1.Drow();

            Point p2 = new Point(5, 9, '#');         
            p2.Drow();
            Console.ReadLine();
        }
    }
}
