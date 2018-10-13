using System;
using System.Drawing;
using System.Windows.Forms;
using Invaders;

namespace Invaders
{
    /// <summary>
    /// 窗体包括一些定时器来通知游戏继续进行，它要传递按键事件，并完成入侵者和闪
    /// 烁星星的动画。它还有一个paint事件处理程序来绘制图形，这个事件处理程序只
    /// 需调用Game对象的draw()方法
    /// </summary>
    /// <remarks>
    /// 2018.10.13: 创建. by woan 
    /// 2018.10.14: 加入欢迎界面.  by woan
    /// </remarks>
    public partial class Form : System.Windows.Forms.Form
    {

        private Game game = Game.instance;

        /// <summary>
        /// Form的构造函数
        /// </summary>
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            animationTimer.Start();
            gameTimer.Start();
        }


        bool isStartTipFadein = false;
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //以下代码试图通过改变a值（透明度）实现startTip的渐变闪烁，但不生效

            //if (startTip.Visible == true)
            //{
            //    if (startTip.ForeColor.A <= 0)
            //    {
            //        isStartTipFadein = true;
            //    }
            //    else if (startTip.ForeColor.A >= 255)
            //    {
            //        isStartTipFadein = false;
            //    }

            //    Color temp = startTip.ForeColor;

            //    if (isStartTipFadein)
            //    {
            //        startTip.ForeColor = Color.FromArgb(startTip.ForeColor.A + 1, temp);

            //    }
            //    else
            //    {
            //        startTip.ForeColor = Color.FromArgb(startTip.ForeColor.A - 1, temp);
            //    }   
            //}
            //以下是临时替代代码，通过改变RGB值实现，局限性较大，要求startTip前景RGB值全为255（纯白）

            if (startTip.Visible == true)
            {
                if (startTip.ForeColor.R <= 45)
                {
                    isStartTipFadein = true;
                }
                else if (startTip.ForeColor.R >= 210)
                {
                    isStartTipFadein = false;
                }
                int i;
                if (isStartTipFadein)
                {
                    i = 15;
                }
                else
                {
                    i = -15;
                }
                startTip.ForeColor = Color.FromArgb(startTip.ForeColor.R + i, startTip.ForeColor.R + i, startTip.ForeColor.R + i);      
            }

            //TODO:以上代码请尽早修改

            game.stars.twinkle();
            this.Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            game.draw(e.Graphics);
        }

        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            welcomeTitle.Visible = false;
            startTip.Visible = false;
        }
    }
}
