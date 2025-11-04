namespace ClassesEObjetos
{
    public class ContaBancaria
    {
        public double Saldo = 0;

        public double Saque = 0;

        public string Titular = "";

        public void Sacar()
        {
            Console.WriteLine($"Quanto deseja sacar?");
            Saque = int.Parse(Console.ReadLine());
            if (Saque > Saldo)
            {
                Console.WriteLine("ERRO, não a saldo o suficiente para sacar");
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }
            else
            {
                Saldo -= Saque;
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }


        }
        public void Depositar(double deposito)
        {
            Console.WriteLine($"Quanto deseja depositar?");
            deposito = int.Parse(Console.ReadLine());
            if (deposito > 0)
            {
                Saldo += deposito;
                Console.WriteLine($"Seu saldo atual é de R${Saldo}");
            }else
            {
                Console.WriteLine($"ERRO, o valor depositado precisa ser maior que zero ");
                
            }
        }


    }
}