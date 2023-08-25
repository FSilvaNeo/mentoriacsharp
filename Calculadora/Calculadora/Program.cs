using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool controle = true;
            float n1;
            float n2;
            float resultado;

            while (controle)
            {
                opcao = MostrarMenu();

                switch (opcao)
                {
                    case "0":
                        controle = false;
                        break;

                    case "1":
                        n1 = LerNumero("primeiro");
                        n2 = LerNumero("segundo");
                        resultado = Somar(n1, n2);
                        ExibirResultado("soma", resultado);
                        break;

                    case "2":
                        n1 = LerNumero("primeiro");
                        n2 = LerNumero("segundo");
                        resultado = Subtrair(n1, n2);
                        ExibirResultado("subtração", resultado);
                        break;

                    case "3":
                        n1 = LerNumero("primeiro");
                        n2 = LerNumero("segundo");
                        resultado = Multiplicar(n1, n2);
                        ExibirResultado("multiplicação", resultado);
                        break;

                    case "4":
                        n1 = LerNumero("primeiro");
                        n2 = LerNumero("segundo");
                        resultado = Dividir(n1, n2);
                        ExibirResultado("divisão", resultado);
                        break;

                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }

                Console.Clear();
            }
        }

        static string MostrarMenu()
        {
            Console.WriteLine("\tCALCULADORA\n");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("0 - Sair");
            return Console.ReadLine();
        }

        static float Somar(float n1, float n2)
        {
            return n1 + n2;
        }

        static float Subtrair(float n1, float n2)
        {
            return n1 - n2;
        }

        static float Multiplicar(float n1, float n2)
        {
            return n1 * n2;
        }

        static float Dividir(float n1, float n2)
        {
            return n1 / n2;
        }

        static float LerNumero(string ordinal)
        {
            Console.WriteLine("Entre com o " + ordinal + " número:");
            return float.Parse(Console.ReadLine());
        }

        static void ExibirResultado(string operacao, float resultado)
        {
            Console.WriteLine("O resultado da " + operacao + " é: " + resultado);
            Console.ReadLine();
        }
    }
}
