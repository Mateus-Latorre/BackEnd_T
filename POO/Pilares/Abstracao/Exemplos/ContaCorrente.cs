namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public override void Depositar(float valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O valor depositado não pode ser igual á zero");
            }
        }

        public override void Sacar(float valor)
        {
            Console.WriteLine($"{valor * 1.01}");
            
            if (Saldo > valor * 1.01f && valor > 0 && valor <= Saldo + valor * 1.01f)
            {
                Saldo -= valor * 1.01f;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O saldo e/ou o valor desejado não é suficiente");
            }
        }
    }
}