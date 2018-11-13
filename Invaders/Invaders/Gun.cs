﻿using System;
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
    abstract public class Gun
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
            if (direction == Direction.up)
            {
                positionY -= distance;
            }
            if (direction == Direction.down)
            {
                positionY += distance;
            }
            if (direction == Direction.left)
            {
                positionX -= distance;
            }
            if (direction == Direction.right)
            {
                positionX += distance;
            }
        }

        Timer timer = new Timer();
        bool isShotting;

        public Gun()
        {
            timer.Start();
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
        public normalGun(int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.shottingInterval = 300;
        }
    }
}
