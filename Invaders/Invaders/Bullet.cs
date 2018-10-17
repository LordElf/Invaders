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
        public Rectangle bulletSize { get;  set; } 
        public enum Direction
        {
            up,
            down
        }

        public bool move(Direction direction)
        {
            if (direction == Direction.up)
            {
                bulletSize.Location.Y -= this.speed;
            }

            if (this.bulletSize.Location.Y >= 0 && this.bulletSize.Location.Y <= Options.height)
                return true;
            else return false;
        }
    }

    class normalBullet : Bullet{
        public normalBullet()
        {
            this.speed = 30;
            this.injury = 1;
            this.bulletSize.Height = 15;
            this.bulletSize.Width = 5;

            move(normalBullet.Direction);
        }
    }
}
