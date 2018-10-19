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
        public int width { get; set; }
        ///<summary>
        ///飞船的高度Heigh 为width的4/3
        /// </summary>
        public int heigh { get; set;} 
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

            /*created by Shawn
            int currentPositionX = positionX, currentPositionY = positionY;
            switch (direction)
            {
                case Direction.down:
                    currentPositionY += speed;
                    break;
                case Direction.up:
                    currentPositionY -= speed;
                    break;
                case Direction.left:
                    currentPositionX -= speed;
                    break;
                case Direction.right:
                    currentPositionX += speed;
                    break;
                default:
                    break;
            }
            
            if(currentPositionX >= Options.gameLeftBorder && currentPositionX + shipWidth <= Options.gameRightBorder
                && currentPositionY >= Options.gameUpBorder && currentPositionY + shipHeigh <= Options.gameDownBorder)
            {
                positionX = currentPositionX;
                positionY = currentPositionY;
            }
            */
            

            int leftBorderMagicNum  = 0;       //左边界的神奇误差
            int rightBorderMagicNum = -15;       //右边界的神奇误差
            int upBorderMagicNum    = -15;       //上边界有计算误差，因为根本没有算分数等元素的高度
            int downBorderMagicNum  = 35;       //下边界的神奇误差


            if (direction == Direction.left)
            {
                positionX -= speed;
                if (positionX <= Options.gameLeftBorder - leftBorderMagicNum)
                {
                    positionX = Options.gameLeftBorder - leftBorderMagicNum;
                }
            }
            if (direction == Direction.right)
            {
                positionX += speed;
                if (positionX + width >= Options.gameRightBorder + rightBorderMagicNum)
                {
                    positionX = Options.gameRightBorder - width + rightBorderMagicNum;
                }
            }
            if (direction == Direction.up)
            {
                positionY -= speed;
                if (positionY <= Options.gameUpBorder - upBorderMagicNum)
                {
                    positionY = Options.gameUpBorder - upBorderMagicNum;
                }
            }
            if (direction == Direction.down)
            {
                positionY += speed;
                if (positionY + heigh >= Options.gameDownBorder - downBorderMagicNum)
                {
                    positionY = Options.gameDownBorder - heigh - downBorderMagicNum;
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
        /// the player's ship
        /// </summary>
        public PlayerShip()
        {
            this.speed = 10;
            this.width = Options.formWidth / 16;
            this.heigh = width;    
            this.positionX = (Options.gameRightBorder - Options.gameLeftBorder) / 2 - width + 30; //神奇误差，如上
            this.positionY = Options.gameDownBorder - heigh - 35;
        }
    }
}
