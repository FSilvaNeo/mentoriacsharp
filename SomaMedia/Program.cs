using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quantityNumbers = ShowMenu();

            var numbers = ReadNumbers(quantityNumbers);
            var sum = numbers.Select(x => x).Sum();
            var average = numbers.Select(x => x).Average();

            ShowResult(sum, average);
        }

        static int ShowMenu()
        {
            int MIN = 3;
            int MAX = 10;
            int quantityNumbers;

            do
            {
                Console.Clear();
                Console.WriteLine("\tSOMA E MÉDIA\n");
                Console.WriteLine("Informe a quantidade de números serão informados para o cálculo:");
                Console.WriteLine("A quantidade de números deve estar entre {0} e {1}", MIN, MAX);
                int.TryParse(Console.ReadLine(), out quantityNumbers);
            }
            while (quantityNumbers < MIN || quantityNumbers > MAX);
            return quantityNumbers;
        }

        static List<int> ReadNumbers(int quantityNumbers)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < quantityNumbers; i++)
            {
                int.TryParse(Console.ReadLine(), out int number);
                numbers.Add(number);
            }
            return numbers;
        }

        static void ShowResult(int sum, double average)
        {
            Console.WriteLine("A soma dos números é: {0}", sum);
            Console.WriteLine("A média dos números é: {0}", average);
            Console.ReadKey();
        }
    }
}
