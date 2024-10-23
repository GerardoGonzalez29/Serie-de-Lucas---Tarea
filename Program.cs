using System;
namespace Serie_de_Lucas
{
    internal class Program
    {
        // Grupo De Proyecto No. 2
        // JOSE GERARDO GONZALEZ MARROQUÍN    1790-24-20539
        // MARVIN ALEXANDER MUÑOZ GALINDO     1790-24-14458
        // NOÉ ISAAC CARRILLO GÓMEZ           1790-24-15624
        // ALEXANDER NEFTALÍ ARÉVALO ORANTES  1790-24-22254

        static void ImprimirSerieLucas(int N)
        {
            int primernumero = 2;
            int segundonumero = 1;
            Console.WriteLine("Los primeros " + N + " números de la serie de Lucas son:");
            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    Console.Write(primernumero);
                }
                else if (i == 1)
                {
                    Console.Write(", " + segundonumero);
                }
                else
                {
                    int numerosiguiente = primernumero + segundonumero;
                    Console.Write(", " + numerosiguiente);
                    primernumero = segundonumero;
                    segundonumero = numerosiguiente;
                }
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int N = 0;
            while (true)
            {
                Console.Write("Ingrese un número entero positivo N: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out N) && N > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: Por favor ingrese un número entero positivo mayor que cero.");
                }
            }
            ImprimirSerieLucas(N);
            Console.ReadKey();
        }
    }
}

