using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    /// <summary>
    /// Bullets 
    /// </summary>
    /// <remarks>
    /// created on 10.17 14：00 by Shawn
    /// </remarks>
    abstract class Bullet 
    {
        protected int speed;
        protected int injury;
        public Rectangle size; 
    }

    class normalBullet : Bullet{
        public normalBullet()
        {
            this.speed = 30;
            this.injury = 1;
            this.size.Height = 15;
            this.size.Width = 5;

        }
    }
}
