using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab20
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {

            MyDelegate myDelegate = Get_Length;
            myDelegate += Get_Area;
            myDelegate += Get_Volume;
            myDelegate(5);
            Console.ReadKey();
        }
        //объявление статических медов в классе
        // длина окружности
           public static double Get_Length(double r)
            {
                double length;
                length = 2 * 3.1415 * r;
            Console.WriteLine(length);
            return length;
            }

        //площадь круга
            public static double Get_Area(double r)
            {
            double area;
            area = 3.1415 * r * r;
                Console.WriteLine(area);
                return area;
            }

        //объем шара
        public static double Get_Volume(double r)
        {
            double volume;
            volume = 3.1415 * r * r * r * 4.0 / 3.0;
            Console.WriteLine(volume);
            return volume;
        }
        }
    }


   