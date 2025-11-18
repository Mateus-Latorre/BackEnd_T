using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Circulo : IForma
    {
        public void CalcularArea()
        {
            Console.WriteLine($"Vamos Calcular a área do círculo.");
            double r;
            double a;
            Console.Write($"Digite o raio do círculo:");
            r = double.Parse(Console.ReadLine());
            a = r * r * 3.14;
            Console.WriteLine($"A área do círculo é de {a}");
        }
    }
}