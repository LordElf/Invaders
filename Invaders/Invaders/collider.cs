using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    abstract class collider
    {
        int locationX;
        int locationY;
    }

    class shipCollider : collider {
        public shipCollider(Ship ship)
        {
            ;
        }
    }

    class normalCollider : collider
    {
        public normalCollider(Object stuff)
        {
            ;
        }
    }
}
