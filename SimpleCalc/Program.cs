// See https://aka.ms/new-console-template for more information
int numero1;
int numero2;



Console.WriteLine("Digite o primeiro numero");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo numero");
numero2 = int.Parse(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine((numero1) + " é maior do que " + (numero2));
}
else if (numero1 < numero2)
{
    Console.WriteLine((numero2) + " é maior do que " + (numero1));
}
else if (numero1 == numero2)
{
    Console.WriteLine((numero2) + " é igual a " + (numero1));
}
