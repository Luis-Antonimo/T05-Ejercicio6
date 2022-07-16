using System;

namespace T05Ejercicio6
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Escriba un número entero positivo (mayor que 0) del que contaremos las cifras:");
                int numero = Convert.ToInt32(Console.ReadLine());
                double controlDecimal = numero % 1;
                //Control de si el número no es negativo (mayor que cero) y que no es decimal
                //(si lo dividimos por 1 es igual a cero).
                if (numero > 0)
                {
                    Console.WriteLine("El número de cifras del número " + numero + " es: " + CuentaCifras(numero));
                }
                else
                {
                    Console.WriteLine("Error. El número escrito no es positivo.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Lo que ha escrito no es un número entero.");
            }
        }

        static int CuentaCifras(int numero)
        {
            int contador = 0;
            while (numero > 0)
            {
                numero = numero / 10;
                contador = contador + 1;
            }
            return contador;
        }

    }
}