using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string TextoRelatorio = "";
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo Relatório de {Nome} ...");
            Console.WriteLine(TextoRelatorio);
            Console.WriteLine($"---------------------------------");
        }
    }
}