using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public string Contratante = "";
        public string PrestadorServico = "";
        public string TextoClausulas = "";

        public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratante;
            PrestadorServico = contratada;
            TextoClausulas = txtClausulas;
        }
        public void Imprimir()
        {
            Console.WriteLine(@$"
        Partes:
            Contratante: {Contratante}
            Contratada: {PrestadorServico}
            Cláusulas do Contrato:
            
            {TextoClausulas}");
            Console.WriteLine($"---------------------------------");

        }
    }
}