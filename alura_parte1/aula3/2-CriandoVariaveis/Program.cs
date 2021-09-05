using System;

namespace _2_CriandoVariaveis
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 2 - Criando Variáveis");

      int idade = 34;
      Console.WriteLine(idade);

      idade = 3 + 4;
      Console.Write(idade);

      idade = (3 + 4) * 1;
      Console.WriteLine("Sua idade é " + idade + '!');

      Console.WriteLine("Execução finalizada. Tecle enter para sair...'");
      Console.ReadLine();
    }
  }
}
