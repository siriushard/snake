using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(6, 8, '$');

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int num in numList)
            {
                Console.WriteLine(num);
            }

            List<Point> listP = new List<Point>();
            listP.Add(p1);
            listP.Add(p2);
            listP.Add(p3);

            listP[2].Draw();
            Console.ReadLine();
        }
    }
}
