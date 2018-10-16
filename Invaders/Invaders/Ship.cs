using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    [Flags]
    public enum Direction
    {
        left, right, up, down
    }

    public class Ship
    {
        private Point position;
        private int speed; //每帧可移动的距离，单位为像素
        /// <summary>
        /// 舰船的飞行方向，用于传参给move函数
        /// </summary>
        public void move(Direction direction)
        {
            if ((direction & Direction.left) != 0)
            {
                position.X -= speed;
            }
            if ((direction & Direction.right) != 0)
            {
                position.X += speed;
            }
            if ((direction & Direction.up) != 0)
            {
                position.Y -= speed;
            }
            if ((direction & Direction.down) != 0)
            {
                position.Y += speed;
            }
        }
    }

    public class PlayerShip : Ship
    {
        public int life { get; }
    }
}
