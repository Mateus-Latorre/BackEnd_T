using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Aluno : Pessoa
    {
        public override void Dormir()
        {
            Console.WriteLine($"O aluno está dormindo");
        }

        public override void FazerSom()
        {
            Console.WriteLine($"O aluno está falando");
        }

        public override void Mover()
        {
            Console.WriteLine($"O aluno está andando");
        }
    }
}