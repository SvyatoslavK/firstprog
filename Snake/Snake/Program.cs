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
            Point p1 = new Point(1,3, '*'); // Создаем экземпляр p1 класса Point
            p1.position();

            Point p2 = new Snake.Point(2, 4,'┴');
            p2.position();
                      
            Console.ReadLine();
        }

        
    }
}
