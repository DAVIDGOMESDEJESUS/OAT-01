using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) Solicitar o tempo de casada para mulheres casadas
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o sexo (M/F): ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Digite o estado civil: ");
            string estadoCivil = Console.ReadLine();

            if (sexo == 'F' && estadoCivil == "CASADA")
            {
                Console.Write("Digite o tempo de casada (anos): ");
                int tempoCasada = int.Parse(Console.ReadLine());
                Console.WriteLine("Tempo de casada (anos): " + tempoCasada);
            }
        }
    }
}

