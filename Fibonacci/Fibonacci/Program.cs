using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 0;
            int valor = 0;


            int numero = int.Parse(Console.ReadLine());

            while (numero > valor)
            {
                valor = num1 + num2;
                num2 = num1;
                num1 = valor;

                Console.WriteLine(valor);
            }
            if (numero == valor)
            {
                Console.WriteLine("seu numero pertence à sequência de  Fibonacci");
            }
            else
            {
                Console.WriteLine("seu numero não pertence à sequência de Fibonacci");
            }


        }
    }
}
