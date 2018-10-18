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
        //public Rectangle bulletSize { get;  set; } 
        protected int positionX;
        protected int positionY;
        protected int height;
        protected int width;

        public bool move(Direction direction)
        {
            if (direction == Direction.up)
            {
                positionY -= this.speed;
            }

            if (positionY >= 0 && positionY <= Options.formHeight)
                return true;
            else return false;
        }
    }

    class NormalBullet : Bullet{
        public NormalBullet()
        {
            this.speed = 30;
            this.injury = 1;
            this.height = 15;
            this.width = 5;

        }
    }
}
