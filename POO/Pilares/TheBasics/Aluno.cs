namespace TheBasics
{
    public class Aluno : Pessoa
    {
        /*
        Cria um construtor na classe Aluno que recebe o endereço
        chama o construtor da classe mãe (base) e repassa o
        endereço pra ela
        */
        public Aluno(Endereco edenreco) : base(edenreco)
        {

        }

        public string RA = "";
        public float NotaFinal = 0;
        public string Curso = "";

    }
}