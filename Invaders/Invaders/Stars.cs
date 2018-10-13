using System;
using System.Drawing;

namespace Invaders
{
    /// <summary>
    /// Stars类存储背景的所有星星，并提供绘制方法
    /// </summary>
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
            public void changePositiom(Random random)
            {
                point.X = random.Next(0, Options.width);
                point.Y = random.Next(0, Options.height);
            }

            public void draw(Graphics graphics)
            {
                graphics.FillEllipse(Brushes.White, point.X, point.Y, 2, 2);
            }
        }

        private int amount = 300; //星星的数量
        private int changeInAmount = 5; //每次闪烁变化的星星
    } 
}
