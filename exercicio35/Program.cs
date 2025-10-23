int q = 0, i = 1, n1 = 0, n2 = 0;

Console.WriteLine("Quantas vezes você que comparar?");
Console.WriteLine("");
Console.WriteLine("");
q = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

while (i <= q)
{
    Console.WriteLine("Digite o primeiro número");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("------------------------");
    Console.WriteLine("");

    Console.WriteLine("Digite o segundo número");
    n2 = int.Parse(Console.ReadLine());
    Console.WriteLine("-----------------------");
    Console.WriteLine("");

    if (n1 > n2)
    {
        Console.WriteLine($"O número {n1} é maior que o número {n2}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");
    }
    else if (n1 < n2)
    {
        Console.WriteLine($"O número {n2} é maior que o número {n1}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine($"O número {n1} é igual ao número {n2}");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("");
    }
    i++;
}
Console.WriteLine("-------------------------------------");
Console.WriteLine("Você terminou suas comparações");
