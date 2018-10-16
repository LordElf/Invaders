using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    /// <summary>
    /// 用于舰船移动的方向枚举
    /// </summary>
    [Flags]
    public enum Direction
    {
        /// <summary>左</summary>
        left,

        /// <summary>右</summary>
        right,

        /// <summary>上</summary>
        up,

        /// <summary>下</summary>
        down
    }

    /// <summary>
    /// 舰船类
    /// </summary>
    abstract public class Ship
    {

        /// <summary>
        /// 舰船的生命值
        /// </summary>
        public int life { get; }
        /// <summary>
        /// 舰船的X坐标
        /// </summary>
        public int positionX { get; set; }
        /// <summary>
        /// 舰船的Y坐标
        /// </summary>
        public int positionY { get; set; }
        /// <summary>
        /// 舰船每帧可移动的距离，单位为像素
        /// </summary>
        protected int speed;
        /// <summary>
        /// 舰船的炮击速度，单位为像素/帧
        /// </summary>
        protected int shottingSpeed;
        /// <summary>
        /// 舰船的飞行方向，用于传参给move函数
        /// </summary>
        public void move(Direction direction)
        {
            //TODO：加入边界检测
            if (direction == Direction.left)
            {
                positionX -= speed;
            }
            if (direction == Direction.right)
            {
                positionX += speed;
            }
            if (direction == Direction.up)
            {
                positionY -= speed;
            }
            if (direction == Direction.down)
            {
                positionY += speed;
            }
        }
    }

    /// <summary>
    /// 玩家的舰船
    /// </summary>
    public class PlayerShip : Ship
    {
        public PlayerShip()
        {
            this.speed = 10;
            this.shottingSpeed = 50;
        }
    }
}
