using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // time interval between two shots (ms)
        protected int shottingInterval;

        //枪口位置，即子弹生成的坐标点（子弹左上角）
        protected int positionX;
        protected int positionY;

        /// <summary>
        /// 由上级的Ship的move（）调用，移动的同时移动枪口位置，即子弹生成的坐标点（子弹左上角）
        /// </summary>
        /// <param name="direction">移动的方向</param>
        /// <param name="distance">移动的距离（像素）</param>
        public void move(Direction direction, int distance)
        {
            
        }

        public Bullet shot()
        {
            Bullet bullets = new NormalBullet(positionX, positionY);
            //TODO:生成新子弹
            return bullets;
        }
    }

    class railGun : Gun
    {
        public railGun()
        {
            this.shottingInterval = 100;
        }
    }

    class normalGun : Gun
    {
        public normalGun()
        {
            this.shottingInterval = 300;
        }
    }
}
