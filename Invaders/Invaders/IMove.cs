using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    /// <summary>
    /// Interface of move
    /// </summary>
    interface IMove
    {
        void move(Direction direction);
    }
}
