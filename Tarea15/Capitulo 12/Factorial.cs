using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tarea15.Capitulo_12
{
    public class Factorial
    {
        public static void main()
        {
            factorial(5);
        }

        public static void factorial(int num)
        {
            int factorial = num;

            for (int i=num-1; i>0; --i)
            {
                factorial *= i;
                Console.WriteLine(factorial);
            }

            Console.WriteLine("\nEl Factorial de " + num + " es: " + factorial);
            Console.ReadKey();
        }
    }
}
