namespace TheBasics
{
    public class Aviao : Veiculo
    {
        public int qtdTurbinas = 0;
        public void Decolar()
        {
            Console.WriteLine($"Avião decolando");
        }
        public void Aterrissar()
        {
            Console.WriteLine($"Avião aterrissando");
        }
    }
}