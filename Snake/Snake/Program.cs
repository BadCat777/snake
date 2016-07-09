using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 8, '#');
            p2.Draw();

            HorizontalLine hline = new HorizontalLine(4, 8, 6, '+');
            hline.Drow();

            VerticalLine vline = new VerticalLine(2, 4, 10, '!');
            vline.Drow();

            Console.ReadLine();

        }
    }
}
