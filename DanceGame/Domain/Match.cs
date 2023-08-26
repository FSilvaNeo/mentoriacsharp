using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceGame.Domain
{
    internal class Match
    {
        public Round Round { get; set; }

        public Match()
        {
            Round = new Round();
        }

        public Match(int roundNumber)
        {
            Round = new Round(roundNumber);
        }
    }
}
