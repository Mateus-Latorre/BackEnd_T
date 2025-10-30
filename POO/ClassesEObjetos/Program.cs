using ClassesEObjetos;
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("-------------------------");
Console.WriteLine("|   Bem vindo Usuario   |");
Console.WriteLine("-------------------------");
Console.WriteLine("");
Console.WriteLine("");

int op = 0;
string nome = "";
Console.WriteLine($"Olá usuário, qual seu nome?");
nome = Console.ReadLine();
Console.WriteLine($"");
Console.WriteLine($"");

do
{
    Console.WriteLine($"Ok {nome}, selecione uma das funções abaixo");
    Console.WriteLine($"1 - Garrafa");
    Console.WriteLine($"2 - Agência");
    Console.WriteLine($"0 - Sair");
    Console.WriteLine($"");
    Console.WriteLine($"");
    op = int.Parse(Console.ReadLine());
    switch (op)
    {
        case 0:
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|    Até mais Usuario   |");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            break;
        case 1:
            Garrafa();
            break;
        case 2:
            ContaBancaria();
            break;
        default:
            Console.WriteLine("ERRO, a função escolhida não existe");
            break;
    }

    void Garrafa()
    {
        int menu = 0;
        do
        {
            Garrafa g1 = new Garrafa();
            Console.WriteLine($"Olá {nome}, vamos personalizar sua garrafa.");
            Console.WriteLine($"Qual será a marca da sua garrafa?");
            g1.marca = Console.ReadLine();

            Console.WriteLine("Qual será o modelo da sua garrafa?");
            g1.modelo = Console.ReadLine();

            Console.WriteLine($"Qual será a capacidade da sua garrafa (em ml)?");
            g1.capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual será a cor a da sua garrafa?");
            g1.cor = Console.ReadLine();

            Console.WriteLine($"Estamos preparando sua garrafa {nome}");
            Console.WriteLine($"Aguarde...");
            Thread.Sleep(2000);

            Console.WriteLine($"Tudo pronto, essas são as características da sua garrafa");
            Thread.Sleep(1000);

            Console.WriteLine($"");
            Console.WriteLine($"Características");
            Console.WriteLine($"");


            Console.WriteLine($"-------- {g1.marca} --------");


            Console.WriteLine($"Marca: {g1.marca}");
            Console.WriteLine($"Modelo: {g1.modelo}");
            Console.WriteLine($"Capacidade: {g1.capacidade}");
            Console.WriteLine($"Cor: {g1.cor}");
            Console.WriteLine($"");
            Console.WriteLine($"---");
            Console.WriteLine($"");
            Thread.Sleep(3000);


            Console.WriteLine($"Abrindo a garrafa {g1.marca}");
            Console.WriteLine($"Enchendo a garrafa {g1.marca}");
            Console.WriteLine($"Esvaziando a garrafa {g1.marca}");
            Console.WriteLine($"Fechando a garrafa {g1.marca}");

            Console.WriteLine($"Deseja voltar ao menu ou continuar no sistema?");
            Console.WriteLine($"1 - Sistema");
            Console.WriteLine($"0 - Menu");
            Console.WriteLine($"");
            Console.WriteLine($"");
            menu = int.Parse(Console.ReadLine());

        } while (menu != 0);
    }
    void ContaBancaria()
    {
        int acao = 0;
            ContaBancaria t1 = new ContaBancaria();
            Console.WriteLine($"Olá {nome} vamos abrir uma conta bancária.");
            Console.WriteLine($"Quem será o titular dessa conta?");
            t1.Titular = Console.ReadLine();
            Console.WriteLine($"");
            Console.WriteLine($"");
        do
        {

            Console.WriteLine($"Ok, o que o {t1.Titular} deseja fazer?");
            Console.WriteLine($"1 - Sacar");
            Console.WriteLine($"2 - Depositar");
            Console.WriteLine($"0 - Sair");
            Console.WriteLine($"");
            Console.WriteLine($"");
            acao = int.Parse(Console.ReadLine());

            switch (acao)
            {
                case 0:
                    Console.WriteLine($"Adeus {nome}");
                    break;
                case 1:
                    t1.Sacar();
                    break;
                case 2:
                    t1.Depositar();
                    break;
                default:
                    Console.WriteLine($"ERRO, o comando escolhido não existe");
                    break;
            }
        } while (acao != 0);

    }
} while (op != 0);
