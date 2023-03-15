namespace exercicio_alunos;
class Program
{
    static void Main(string[] args)
    {
       alunos aluno1=  new alunos();
       aluno1.nome = "outro aluno";
       aluno1.nota1 = 4;
       aluno1.nota2 = 5;

       aluno1.mensagem();
    }
}
