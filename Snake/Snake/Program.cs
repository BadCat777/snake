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

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 3, '%');
            p3.Draw();

            Point p4 = new Point(5, 9, '&');
            p4.Draw();

            List<int> NumList = new List<int>();
            NumList.Add(0);
            NumList.Add(1);
            NumList.Add(2);

            int x = NumList[0];
            int y = NumList[1];
            int z = NumList[2];

            NumList.RemoveAt(0);

            foreach (int i in NumList)
            {
                Console.WriteLine(i);
            }


            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            Console.ReadLine();

        }
    }
}
