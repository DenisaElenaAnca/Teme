using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaManhattanDistance
{
    class Program
    {
        static void Main(string[] args)
        {


            Geometry MD = new Geometry();
            int dist;
           
            Console.Write("x1 = " );
            MD.point1.x = int.Parse(Console.ReadLine());
        
            Console.Write("y1 = ");
            MD.point1.y= int.Parse(Console.ReadLine());




            Console.Write("x2 = ");
            MD.point2.x= int.Parse(Console.ReadLine());

            Console.Write("y2 = ");
            MD.point2.y= int.Parse(Console.ReadLine());
           


            dist = MD.ManhattanDistance();

            Console.WriteLine("Manhattan distance = " + dist);
            Console.ReadLine();

        }
    }

        class Point
        {
            public int x;
            public int y;
        }

        class Geometry
        {
            public Point point1 = new Point();
            public Point point2 = new Point();

            public int ManhattanDistance()
            {
                int d;
                d = Math.Abs(point2.x - point1.x) + Math.Abs(point2.y - point1.y);
            return d;
            }
        }

    }
    

