
namespace PrimeiraClasse
{
    public class Moto
    {
        public string marca = "";

        public string modelo = "";

        public string cor = "";

        public int qtdRodas;

        //Métodos

        public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");
        }

        public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }

        public void Ligar()
        {
            Console.WriteLine($"Moto Ligando");
        }
    }
}