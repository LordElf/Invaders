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
    abstract public class Bullet : IDraw
    {
        /// <summary>
        /// 子弹飞行速度
        /// </summary>
        protected int speed;
        /// <summary>
        /// 子弹伤害
        /// </summary>
        protected int injury;
        //public Rectangle bulletSize { get;  set; } 
        /// <summary>
        /// 子弹x轴坐标
        /// </summary>
        public int positionX { get; set; }
        /// <summary>
        /// 子弹Y轴坐标
        /// </summary>
        public int positionY { get; set; }
        /// <summary>
        /// 子弹碰撞箱的高度
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// 子弹碰撞箱的宽度
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// 子弹的移动，//不对啊，这个不是我写的啊
        /// </summary>
        /// <param name="direction"></param>
        /// <returns></returns>
        public bool move(Direction direction)
        {
            if (direction == Direction.up)
            {
                positionY -= speed;
            }
            else if(direction == Direction.down)
            {
                positionY += speed;
            }

            if (positionY >= 0 && positionY <= Options.formHeight)
                return true;
            else return false;
        }

        /// <summary>
        /// 绘制子弹自身
        /// </summary>
        /// <param name="graphics"></param>
        public void draw(Graphics graphics)
        {
            graphics.DrawImage(Image.FromFile(FilePath.ART_NORMAL_BULLET), positionX, positionY, 9, 16);
        }
    }

    class NormalBullet : Bullet{
        public NormalBullet(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.speed = 30;
            this.injury = 1;
            this.height = 15;
            this.width = 5;
        }
    }
}
