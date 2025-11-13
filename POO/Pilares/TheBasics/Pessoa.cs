//namespace pode ser considerado como a pasta do projeto
//namespace é o módulo do sistema
// namespace é como um pacote,
using System.Globalization;
using System.Security;

namespace TheBasics
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade;

        public Endereco EnderecoCompleto;

        public Pessoa(Endereco edenreco){
            EnderecoCompleto = edenreco;
        }



                public void Falar()
        {
            Console.WriteLine($"Olá, eu sou o(a) {Nome} e tenho {Idade} anos");
        }

        public void Envelhecer()
        {
            Idade++;
        }
    }
}