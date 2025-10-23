int n = 0, r = 0;
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Digite o número:");
    Console.WriteLine("");
    Console.WriteLine("");
    n = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("");
    r += n;
}

Console.WriteLine("O resultado é " + (r));
