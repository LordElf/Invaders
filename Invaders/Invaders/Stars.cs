using System;
using System.Collections.Generic;
using System.Drawing;

namespace Invaders
{
    /// <summary>
    /// Stars类存储背景的所有星星，并提供绘制方法
    /// </summary>
    /// <remarks>
    /// 2018.10.13: 创建并完全实现 by woan</remarks>
    public class Stars
    {
        private class Star
        {
            Point point = new Point();

            /// <summary>
            /// Star的构造函数
            /// </summary>
            /// <param name="random">由外部提供随机数以避免高并发操作造成随机数重合</param>
            public Star(Random random)
            {
                point.X = random.Next(0, Options.width);
                point.Y = random.Next(0, Options.height);
            }

            /// <summary>
            /// 重新设定Star的位置
            /// </summary>
            /// <param name="random"></param>
            public void changePosition(Random random)
            {
                point.X = random.Next(0, Options.width);
                point.Y = random.Next(0, Options.height);
            }

            public void draw(Graphics graphics)
            {
                graphics.FillEllipse(Brushes.White, point.X, point.Y, 2, 2);
            }
        }

        Random random = new Random();
        private int amount = 300; //星星的数量
        private int changeInAmount = 2; //每次闪烁变化的星星

        List<Star> stars = new List<Star>();

        /// <summary>
        /// Stars的构造函数
        /// </summary>
        public Stars()
        {
            for (int i = 0; i < amount; i++)
            {
                stars.Add(new Star(random));
            }
        }

        /// <summary>
        /// 绘制星星
        /// </summary>
        /// <param name="graphics"></param>
        public void draw(Graphics graphics)
        {
            foreach (Star s in stars)
            {
                s.draw(graphics);
            }
        }

        /// <summary>
        /// 删除一些星星并添加一些新的星星
        /// </summary>
        public void twinkle()
        {
            for (int i = 0; i < changeInAmount; i++)
            {
                stars[random.Next(0, amount)].changePosition(random);
            }
        }

    } 
}
