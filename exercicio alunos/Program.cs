namespace exercicio_alunos;
class Program
{
    static void Main(string[] args)
    {
      alunos aluno1 = new alunos();
      Console.WriteLine("Dgite seu nome: ");
      string? nome = Console.ReadLine();
      Console.WriteLine("seu nome é: " + nome);
      Console.WriteLine("Digte a primeira nota: ");
      double nota1 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digte a segunda nota: ");
      double nota2 = Convert.ToDouble(Console.ReadLine());

      aluno1.nome = nome = "";
      aluno1.nota1 = nota1;
      aluno1.nota2 = nota2;

      aluno1.mensagem();


    }
}
