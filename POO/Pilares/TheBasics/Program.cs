using TheBasics;
Console.Clear();


// List<Pessoa> peoples = new List<Pessoa>();


// /**********************************************************************************************/

// Endereco enderecoMateus = new Endereco();
// enderecoMateus.Logradouro = "Av. Estrada das Lagrimás";
// Pessoa mateus = new Pessoa(enderecoMateus);
// mateus.Nome = "Mateus Latorre";
// mateus.Idade = 16;

// /****************************************************************************************************/

// Endereco enderecoSte = new Endereco();
// enderecoSte.Logradouro = "Rua Camargo";
// Pessoa stephani = new Pessoa(enderecoSte);
// stephani.Nome = "Stephani Dandara";
// stephani.Idade = 16;

// /**************************************************************************************/


// peoples.Add(mateus);
// peoples.Add(stephani);


// foreach (var p in peoples)
// {
//     Console.WriteLine($"Nome: {p.Nome}");
// }
// Endereco endEnzo = new Endereco();
// endEnzo.Logradouro = "Spínola Teixeira";
// endEnzo.Numero = 3960;
// Aluno pedroEnzo = new Aluno(endEnzo);
// pedroEnzo.Nome = "Pedro Enzo";
// pedroEnzo.Curso = "Desenvolvimento de Sistemas";
// pedroEnzo.RA = "1234-xpto";
// pedroEnzo.NotaFinal = 9.75f;

// Endereco endProfAlex = new Endereco();
// endProfAlex.Logradouro = "Rua lá de casa";
// endProfAlex.Numero = 987;
// Professor profAlexia = new Professor(endProfAlex);
// profAlexia.Nome = "Aléxia Vitória";

// Console.WriteLine($"Aluno {pedroEnzo.Nome} estuda na turma {pedroEnzo.Curso} da profa. {profAlexia.Nome}");

Carro c1 = new Carro();
c1.Marca = "Jabuti";
c1.Modelo = "Corolla";
c1.qtdRodas = 4;
c1.Ligar();
c1.AbrirPortaMala();
c1.Desligar();

Moto m1 = new Moto();
m1.Marca = "Honda";
m1.Modelo = "Hornet";
m1.qtdRodas = 2;
m1.Ligar();
m1.Empinar();
m1.Desligar();

Aviao a1 = new Aviao();
a1.Marca = "Boeing";
a1.Modelo = "737";
a1.qtdRodas = 6;
a1.qtdTurbinas = 2;
a1.Ligar();
a1.Decolar();
a1.Aterrissar();
a1.Desligar();