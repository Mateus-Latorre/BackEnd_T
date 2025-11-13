namespace TheBasics
{
    public class Veiculo
    {
        public string Marca = "";
        public string Modelo = "";
        public int qtdRodas = 0;
        public void Ligar()
        {
            Console.WriteLine($"Ligando o veículo");
        }

        public void Desligar()
        {
            Console.WriteLine($"Veículo desligado");
        }
        
    }
}