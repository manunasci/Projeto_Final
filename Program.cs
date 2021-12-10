using System;

namespace Projeto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Menu = false;
            while (!Menu)
            {
                Menu = MenuPrincipal();
            }
        }

        public static bool MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("========Projeto Final========");
            Console.WriteLine();
            
            Console.WriteLine("Selecione a opção a baixo");
            Console.WriteLine();

            Console.WriteLine("1-Adição");
            Console.WriteLine("2-Subtração");
            Console.WriteLine("3-Multiplicação");
            Console.WriteLine("4-Divisão");
            Console.WriteLine("5-Exponenciação");
            Console.WriteLine("6-Radiciação");
            Console.WriteLine("7-Sobre");
            Console.WriteLine("8-Sair");

            switch (Console.ReadLine())
            {
                case "1":
                    Adicao();
                    return false;
                case "2":
                    Subtracao();
                    return false;
                case "3":
                    Multiplicacao();
                    return false;
                case "4":
                    Divisao();
                    return false;
                case "5":
                    Exponenciacao();
                    return false;
                case "6":
                    Radiciacao();
                    return false;
                case "7":
                    Sobre();
                    return false;
                case "8":
                    return true; 
                default:
                    return true;
            }
        }
        public static void Adicao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0, numero2 = 0;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = numero1 + numero2;

                Console.WriteLine($"{numero1} mais {numero2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Subtracao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0, numero2 = 0;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = numero1 - numero2;

                Console.WriteLine($"{numero1} menos {numero2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Multiplicacao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0, numero2 = 0;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = numero1 * numero2;

                Console.WriteLine($"{numero1} vezes {numero2} é igual à {resultado}");
                
                Console.Write("\nDeseja continuar nessa operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Divisao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0, numero2 = 0;

                Console.Write("Digite o primeiro número: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o segundo número: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = numero1 / numero2;

                Console.WriteLine($"{numero1} dividido {numero2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Exponenciacao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0, numero2 = 0;

                Console.Write("Digite o valor da exponenciação: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o expoente: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Math.Pow(numero1 , numero2);

                Console.WriteLine($"{numero1} elevado à {numero2} é igual à {resultado}");

                Console.Write("\nDeseja continuar nessa operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Radiciacao()
        {
            string escolha = "";
            while(escolha != "Nao")
            {
                Console.Clear();

                double numero1 = 0 , numero2 = 0;

                Console.Write("Digite o valor do radical: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\nDigite o valor do indici: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                double resultado = Math.Pow(numero1, 1/ numero2);

                Console.WriteLine($"A raiz do {numero1} com o indici {numero2} é igual à {resultado} ");

                Console.Write("\nDeseja continuar na operação? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }

        public static void Sobre()
        {
            string escolha = "";

            while(escolha != "Nao")
            {
                Console.Clear();

                Console.WriteLine("É um programa criado por mim, Manuella com o objetivo de levar para o usuário foras de calcular operações rapidamente. Projeto para curso da ETEC Adolpho Berezin ");

                Console.Write("\nDeseja continuar nessa opção? (Sim/Nao): ");
                escolha = Console.ReadLine();
            }
        }       
    }
}