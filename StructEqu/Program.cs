using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEqu
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Программа решения уравнения с одной переменной.\n\n Введите значение k и b в уравнение типа 0=х*k+b");
            Console.Write("k- ");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nb- ");
            double b = Convert.ToDouble(Console.ReadLine());
            Equ equ = new Equ { k = k, b = b };
            equ.Root();
            Console.ReadKey();

        }
        struct Equ
        {
            public double k;
            public double b;
           
            public void Root()
            {
                double x = -b / k;
                Console.WriteLine("\nx равняется {0}", x);
            }
            

        }

    }
}
