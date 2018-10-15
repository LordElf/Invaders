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

        //记录界面的状态
        private enum Status
        {
            beginning,
            playing,
            over
        }
        Status status = Status.beginning;

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
            welcome();
        }


        bool isStartTipFadein = false;
        private Stars stars = new Stars();
        private void animationTimer_Tick(object sender, EventArgs e)
        {


            stars.twinkle();
            this.Refresh();
        }

        private void welcome()
        {
            this.playerShip.Visible = false;
            this.playerLife.Visible = false;
            this.lifeIcon.Visible = false;
            this.currentScore.Visible = false;

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
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            this.currentScore.Text = game.currentScore.ToString();
            this.playerLife.Text = game.playerShip.life.ToString();
            this.Refresh();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            int x = this.playerShip.Location.X;
            int y = this.playerShip.Location.Y;

            if(this.status == Status.playing)
            {
                if (e.KeyCode == Keys.Right) x += 10;
                else if (e.KeyCode == Keys.Left) x -= 10;
                else if (e.KeyCode == Keys.Up) y -= 1;
                else if (e.KeyCode == Keys.Down) y += 1;
            }

            if(x >= 0 && x <= Width - this.playerShip.Height) 
                this.playerShip.Location = new Point(x, y);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
                
            stars.draw(e.Graphics);
        }
        
        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            welcomeShutDown();
        }

        private void welcomeShutDown()
        {
            welcomeTitle.Visible = false;
            startTip.Visible = false;

            this.status = Status.playing;

            this.currentScore.Visible = true;
            this.playerShip.Visible = true;
            this.playerLife.Visible = true;
            this.lifeIcon.Visible = true;
        }

        private void currentScore_Click(object sender, EventArgs e)
        {

        }
    }
}
