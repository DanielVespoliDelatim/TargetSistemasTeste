using System;
using System.Linq;

namespace InverterCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto a ser invertido");
            string texto = Console.ReadLine();
            Console.WriteLine("Texto normal ="+ texto);
            string textoInvertido = new string(texto.Reverse().ToArray());
            Console.WriteLine("Texto invertido = " +textoInvertido);
            Console.ReadLine();
        }
    }
}
