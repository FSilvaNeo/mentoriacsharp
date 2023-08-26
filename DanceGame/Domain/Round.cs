using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceGame.Domain
{
    internal class Round
    {
        public int Number { get; set; }
        public int Winner { get; set; }
        public Round() { }

        public Round(int roundNumber)
        {
            Number = roundNumber;
        }
    }
}
