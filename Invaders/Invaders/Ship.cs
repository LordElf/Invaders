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
        ///<summary>
        ///飞船的大小 Width Height
        /// </summary>
        public int shipWidth { get; set; }
        ///<summary>
        ///飞船的高度Heigh 为width的4/3
        /// </summary>
        public int shipHeigh { get; set;} 
        /// <summary>
        /// 舰船每帧可移动的距离，单位为像素
        /// </summary>
        protected int speed;

        /// <summary>
        /// 飞船的移动
        /// </summary>
        /// <param name="direction">移动方向，在同一命名空间定义</param>
        public void move(Direction direction)
        {
            if (direction == Direction.left)
            {
                positionX -= speed;
                if (positionX - shipWidth / 2 <= Options.gameLeftBorder)
                {
                    positionX = shipWidth / 2 + Options.gameLeftBorder;
                }
            }
            if (direction == Direction.right)
            {
                positionX += speed;
                if (positionX + shipWidth / 2 >= Options.gameRightBorder)
                {
                    positionX = Options.gameRightBorder - shipWidth / 2;
                }
            }
            if (direction == Direction.up)
            {
                positionY -= speed;
                if (positionY - shipHeigh / 2 <= Options.gameUpBorder)
                {
                    positionY = shipHeigh / 2 + Options.gameUpBorder;
                }
            }
            if (direction == Direction.down)
            {
                positionY += speed;
                if (positionY + shipHeigh / 2 >= Options.gameDownBorder)
                {
                    positionY = Options.gameDownBorder - shipHeigh / 2;
                }
            }
        }
    }

    /// <summary>
    /// 玩家的舰船
    /// </summary>
    public class PlayerShip : Ship
    {
        /// <summary>
        /// 
        /// </summary>
        public PlayerShip()
        {
            this.speed = 10;
            this.shipWidth = Options.formWidth / 10;
            this.shipHeigh = Options.formHeight / 10;
        }
    }
}
