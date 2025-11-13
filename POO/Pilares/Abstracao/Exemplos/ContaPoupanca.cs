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
            if (Saldo > valor * 1.03f && valor > 0 && valor <= Saldo + valor * 1.03f)
            {
                Saldo -= valor * 1.03f;
                Console.WriteLine($"Saldo {Saldo}");
            }
            else
            {
                Console.WriteLine("ERRO: O saldo e/ou o valor desejado não é suficiente");
            }

        }
    }
}