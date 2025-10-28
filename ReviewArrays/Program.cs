string[] nomes = new string[4];
int[] idades = new int[4];
int opcao = -1, totalAlunos = 0;

do
{
    Console.Clear();
    Console.WriteLine("1) Cadastrar Alunos");
    Console.WriteLine("2) Listar Alunos");
    Console.WriteLine("0) Sair");
    Console.Write("Digite uma opção:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando...");
            Console.WriteLine($"Pressione <Enter> para encerrar...");
            Console.ReadLine();
            break;
        case 1:
            CadastrarAluno();
            break;
        case 2:
            ListarAlunos();
            break;
    }
} while (opcao != 0);


void CadastrarAluno()
{
    if (totalAlunos >= 4)
    {
        Console.WriteLine("Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para encerrar...");
        Console.ReadLine();
        return;
    }

    Console.WriteLine("Digite o nome do aluno");
    string n = Console.ReadLine();
    Console.WriteLine($"Digite a idade de {n}");
    int i = int.Parse(Console.ReadLine());

    nomes[totalAlunos] = n;
    idades[totalAlunos] = i;
    totalAlunos++;

    Console.WriteLine("Aluno cadastrado com sucesso");
    Console.WriteLine($"Há {totalAlunos} aluno(s) cadastrado(s) no sistema!");
    Console.WriteLine($"Pressione uma tecla para continuar");
    Console.ReadLine();
}



void ListarAlunos()
{
    Console.WriteLine();
    Console.WriteLine("Resultado:");

    for (int q = 0; q < totalAlunos; q++)
    {
        Console.WriteLine($"  Nome: {nomes[q]}");
        Console.WriteLine($"  Idade: {idades[q]}");
        Console.WriteLine();
    }
    Thread.Sleep(1000);
}
