namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome = "";
        public int Idade = 0;

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}