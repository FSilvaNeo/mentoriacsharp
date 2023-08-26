using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanceGame.Domain;
using DanceGame.Service;

namespace DanceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\tDANCE GAMES\n");

            const int MATCH_ROUNDS = 3;

            Match match = new Match(MATCH_ROUNDS);
            MatchService matchService = new MatchService();

            PlayerService playerService = new PlayerService();
            Player player1 = new Player();
            Player player2 = new Player();

            player1.Name = playerService.AskName('1');
            player2.Name = playerService.AskName('2');

            player1.Dance.Number = playerService.PlayDance(player1.Name);
            player2.Dance.Number = playerService.PlayDance(player2.Name);

            Player winner = matchService.GetWinner(player1, player2);

            matchService.ShowWinner(winner);


        }
    }
}
