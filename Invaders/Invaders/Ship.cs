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
        /// 舰船的飞行方向，用于传参给move函数
        /// </summary>
        public void move(Direction direction)
        {
            int currentLocationX = positionX;
            int currentLocationY = positionY;
            //TODO：加入边界检测
            if (direction == Direction.left)
            {
                currentLocationX -= speed;
            }
            if (direction == Direction.right)
            {
                currentLocationX += speed;
            }
            if (direction == Direction.up)
            {
                currentLocationY -= speed;
            }
            if (direction == Direction.down)
            {
                currentLocationY += speed;
            }
            if(currentLocationX >= 0 && currentLocationX <= Options.width - this.shipWidth && 
                currentLocationY >= 0 && currentLocationY <= Options.height - this.shipHeigh)
            {
                positionX = currentLocationX;
                positionY = currentLocationY;
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
            this.shipWidth = Options.width / 10;
            this.shipHeigh = Options.height / 10;
        }
    }
}
