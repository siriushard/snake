using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
           // Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            x = 1;
           // Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            x = 1;
            //Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Point p1 = new Point(1,3,'*');
            Console.WriteLine("Call Move. p1.x = " + p1.y);

            Point p2 = new Point(4,5,'#');
            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("Call Func1. x = " + x);

            Console.ReadLine();
        }
    }
}
