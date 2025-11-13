using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança
{
    public class Moto : Veiculo
    {
        public string Capacete = "";
        public override void MostrarInfo()
        {
            Console.WriteLine(@$"Modelo: {Modelo}
                                 Marca: {Marca}
                                 Capacete: {Capacete}");
        }
    }
}