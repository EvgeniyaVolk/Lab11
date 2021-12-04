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
            Equ equ = new Equ();
            Console.WriteLine(equ.root);
            Console.ReadKey();

        }
        struct Equ
        {
            public float k;
            public float b;
            public float x;
            public float root;
          
            public void Root(float K, float B, float X, float F)
            {
                this.x = X;
                this.k = K = 10;
                this.b = B = 6;
                F = 0;

                F = K * X + B;
                if (K != 0)
                {
                    X = (F - B) / K;
                }
                else
                {
                    Console.WriteLine("Ошибка! Деление на ноль");
                }
                root = X;
            }
            

        }

    }
}
