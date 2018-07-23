using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCeas
{
    class Program
    {
        static void Main(string[] args)
        {
            //int h;
            //int m;
            //int ct = 5;
            //int um = 6;
            //int unghi;

            //Console.Write(" h = ");
            //h = int.Parse(Console.ReadLine());

            //Console.Write(" m = ");
            //m = int.Parse(Console.ReadLine());


            //if (h > 0 && h < 12)
            //{
            //    unghi = Math.Abs(h * ct - m) * um;
            //    if (unghi <= 180)
            //    {
            //        Console.WriteLine("Unghiul este de " + unghi + " grade");
            //    }
            //    else
            //    {
            //        unghi = 360 - unghi;
            //        Console.WriteLine("Unghiul este de " + unghi + " grade");
            //    }
            //}

            //if (h > 12 && h < 24)
            //{

            //    unghi = Math.Abs((h - 12) * ct - m) * um;
            //    if (unghi <= 180)
            //    {
            //        Console.WriteLine("Unghiul este de " + unghi + " grade");
            //    }
            //    else
            //    {
            //        unghi = 360 - unghi;
            //        Console.WriteLine("Unghiul este de " + unghi + " grade");
            //    }
            //}

            //if (h == 0 || h == 12 || h == 24)
            //{
            //    unghi = um * m;
            //    if (unghi <= 180)
            //    {
            //        Console.WriteLine("Unghiul este de " + unghi + " grade");
            //    }
            //    else
            //    {
            //        unghi = 360 - unghi;
            //        Console.WriteLine("Unghiul este de " + unghi + "grade");
            //    }
            //}

            int h;
            int m;
            int ct = 5;
            int um = 6;
            int unghi;

            Console.Write(" h = ");
            h = int.Parse(Console.ReadLine());

            Console.Write(" m = ");
            m = int.Parse(Console.ReadLine());


            if (h <=12)
            {
                unghi = Math.Abs(h * ct - m) * um;
                if (unghi <= 180)
                {
                    Console.WriteLine("Unghiul este de " + unghi + " grade");
                }
                else
                {
                    unghi = 360 - unghi;
                    Console.WriteLine("Unghiul este de " + unghi + " grade");
                }
            }

            else 
            {

                unghi = Math.Abs((h - 12) * ct - m) * um;
                if (unghi <= 180)
                {
                    Console.WriteLine("Unghiul este de " + unghi + " grade");
                }
                else
                {
                    unghi = 360 - unghi;
                    Console.WriteLine("Unghiul este de " + unghi + " grade");
                }
            }

           


            Console.ReadLine();
        }
    }
}
