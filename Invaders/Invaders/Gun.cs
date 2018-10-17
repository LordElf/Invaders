using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    /// <summary>
    /// info of guns
    /// </summary>
    /// <remarks>
    /// created on 10/17/2018 20:09 by Shawn 
    /// </remarks>
    abstract class Gun
    {
        protected int shottingSpeed;
        public void shot(Bullet bullet)
        {
            new System.Drawing
        }
    }

    class railGun : Gun
    {
        public railGun()
        {
            this.shottingSpeed = 100;
        }
    }
}
