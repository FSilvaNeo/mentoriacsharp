using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DanceGame.Domain;

namespace DanceGame.Service
{
    internal class PlayerService
    {
        public PlayerService() { }

        public string AskName(char num)
        {
            Console.WriteLine("Informe o nome do jogardor {0}:", num);
            return Console.ReadLine();
        }

        public int PlayDance(String name)
        {
            Console.WriteLine("{0}, press some key to play dance", name);
            Console.ReadKey();

            Random random = new Random();
            int danceNumber = random.Next(1, 6);
            this.ShowDanceNumber(danceNumber);
            return danceNumber;
        }

        private void ShowDanceNumber(int danceNumber)
        {
            Console.WriteLine("Number: {0}", danceNumber);
        }
    }
}
