using System.Runtime.InteropServices;
using Exemplos;
Console.Clear();
// Cachorro c1 = new Cachorro();
// c1.FazerSom();
// c1.Mover();
// Gato g1 = new Gato();
// g1.FazerSom();
// g1.Mover();

ContaCorrente c1 = new ContaCorrente();
c1.Depositar(3000);
c1.Sacar(1000);
ContaPoupanca p1 = new ContaPoupanca();
p1.Depositar(3000);
p1.Sacar(1000);

