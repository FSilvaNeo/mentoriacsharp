using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceGame.Domain
{
    internal class Player
    {
        public string Name { get; set; }
        public Dance Dance { get; set; }

        public Player()
        {
            Dance = new Dance();
        }
    }
}
