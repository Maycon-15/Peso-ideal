using System;

namespace Peso_ideal
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PM, PF, Altura;
            String M = "M", F = "F", Sexo;

            Console.WriteLine("Vamos calcular seu peso ideal");

            Console.WriteLine();

            Console.WriteLine("Digite sua altura em metros:");
            Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Por favor informe seu sexo, (M) para masculino e (F) para feminino:");
            Sexo = Console.ReadLine();

            PM = Altura *72.7 - 58.0;
            PF = Altura *62.1 - 44.7;

            if (Sexo == M){
                Console.WriteLine($"Seu peso ideal é de: {PM:N1}");
                Environment.Exit(1);
            }

            else if (Sexo == F)
            {
                Console.WriteLine($"Seu peso ideal é: {PF:N1}");
                Environment.Exit(1);

                Console.ReadKey();
            }
        }
    }
}
