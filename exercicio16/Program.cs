float salario, salarioReajustado;
int cargo;

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Digite o seu sálario:");
Console.WriteLine("");
Console.WriteLine("");
salario = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Digite seu cargo:");
Console.WriteLine("1-Produção");
Console.WriteLine("2-Administrativo");
Console.WriteLine("3-Diretoria");
Console.WriteLine("");
Console.WriteLine("");
cargo = int.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("");

if (cargo == 1)
{

    salarioReajustado = salario * 1.065f;

} else if (cargo == 2)
{

    salarioReajustado = salario * 1.075f;

} else
{

    salarioReajustado = salario * 1.12f;

}

Console.WriteLine("Seu salário reajustado é de R$" + (salarioReajustado));
Console.WriteLine("");
Console.WriteLine("");
