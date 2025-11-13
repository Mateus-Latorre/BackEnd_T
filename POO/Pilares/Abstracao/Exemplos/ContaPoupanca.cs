namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
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
            if (Saldo > 5 && valor > 0 && valor < Saldo + 5)
            {
                Saldo -= valor + 5f;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O saldo e/ou o valor desejado não pode ser igual á zero");
            }

        }
        public void CalcularSaldo()
        {
            Saldo += 0.05f * Saldo;
            Console.WriteLine($"Saldo {Saldo}");

        }
    }
}