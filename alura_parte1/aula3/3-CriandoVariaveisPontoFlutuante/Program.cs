using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante");

            double salario = 1234.56;
            Console.WriteLine(salario);

            double salario2 = 12 / 3;
            Console.WriteLine("12 / 3" + salario2);

            salario2 = 12 / 3.0;
            Console.WriteLine("12 / 3.0" + salario2);

            Console.WriteLine("A execução acabou. Tecle enter para sair ...");
            Console.ReadLine();
        }
    }
}
