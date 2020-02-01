using System;

namespace Debuging
{
    
    class Program
    {
        public static int factorial(int Num)
        {
            int Resultado = 1;

            for (int i = Num; i > 1; i--)
            {
                Resultado *= i;
            }

            return Resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ver Cambio de Variable\n");

            int Numero;

            Console.Write("Ingrese un numero: ");
            Numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El factorial de {0} es {1}", Numero, factorial(Numero));
        }
    }
    
}
