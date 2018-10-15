using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    public class Ship
    {
        private Point position;
    }

    public class PlayerShip : Ship
    {
        public int life { get; }
    }
}
