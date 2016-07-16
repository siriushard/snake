using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine line = new HorizontalLine(0,Console.BufferWidth-2, 0, '+');
            line.Drow();

            VerticalLine lineV = new VerticalLine(0, Console.BufferHeight-2, 0, '+');
            lineV.Drow();

            Console.ReadLine();
        }
    }
}
