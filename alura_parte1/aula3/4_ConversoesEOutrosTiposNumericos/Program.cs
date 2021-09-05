using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            // 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // menor precisão
            float altura = 1.80f;
            Console.WriteLine(altura);

            double salario = 123.455555;
            Console.WriteLine(salario);

            // 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // 64 bits
            long idade = 1000000000000000000;
            Console.WriteLine(idade);

            Console.ReadLine();
        }
    }
}
