float n1, n2, n3, n4, media;
string nome = "";

Console.WriteLine("Qual o nome do aluno");
Console.WriteLine("");
Console.WriteLine("");
nome = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Digite a nota de Matemática:");
Console.WriteLine("");
Console.WriteLine("");
n1 = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Digite a nota de Português:");
Console.WriteLine("");
Console.WriteLine("");
n2 = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Digite a nota de História:");
Console.WriteLine("");
Console.WriteLine("");
n3 = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Digite a nota de Ciências:");
Console.WriteLine("");
Console.WriteLine("");
n4 = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

media = (n1 * n2 * n3 * n4) / 4;

if (media >= 7)
{
    Console.WriteLine("O(A) " + (nome) + " foi Aprovado");
} else if (media < 5)
{
    Console.WriteLine("O(A) " + (nome) + " foi Reprovado");
} else
{
    Console.WriteLine("O(A )" + (nome) + " esta de Recuperação");
} 
