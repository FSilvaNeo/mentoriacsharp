using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceGame.Domain;

namespace DanceGame.Service
{
    internal class MatchService
    {
        public MatchService() { }

        public bool Next(Match match)
        {
            return false;
        }

        public bool RestartMatch()
        {
            return false;
        }

        public Player GetWinner(Player player1, Player player2)
        {
            Player winner = new Player();
            if (player1.Dance.Number > player2.Dance.Number)
                winner = player1;
            else if (player1.Dance.Number < player2.Dance.Number)
                winner = player2;
            else
                winner = null;

            return winner;
        }

        public void ShowWinner(Player winner)
        {
            if (winner != null)
                Console.WriteLine("O vencedor é {0}, com o número {1}", winner.Name, winner.Dance.Number);
            else
                Console.WriteLine("HOUVE EMPATE!");

            Console.ReadKey();
        }


    }
}
