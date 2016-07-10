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
            Console.SetBufferSize(80, 25);

            //Отрисовка рамочки
            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '#');
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '#');
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '#');
            UpLine.Drow();
            DownLine.Drow();
            LeftLine.Drow();
            RightLine.Drow();

            //Отрисовка точек


            HorizontalLine hline = new HorizontalLine(4, 8, 6, '+');
            hline.Drow();

            VerticalLine vline = new VerticalLine(2, 4, 10, '!');
            vline.Drow();

            Console.ReadLine();

        }
    }
}
