using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para calcular a área de um terreno, digite 1!");
            int teste = Convert.ToInt32(Console.ReadLine());
            if (teste == 1)
            {
                calcularArea();
            }
            else
            {
                Console.WriteLine("Então suma daqui!");
            }
            
        }

        static void calcularArea()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Calcular área de terreno!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Informe a largura do terreno:");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o comprimento do terreno:");
            int comprimento = Convert.ToInt32(Console.ReadLine());
            int resultado = largura * comprimento;
            Console.WriteLine("A área do terreno é: " + resultado + "m²!");
            Console.WriteLine(@$"A área do terreno é: {resultado}m²!");
            Console.WriteLine(String.Format(@"A área do terreno é: {0}m²!", resultado));
        }


    }
}
