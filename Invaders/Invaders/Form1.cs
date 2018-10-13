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
    /// 2018.10.13: 创建. by woan <br/>
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


        private void animationTimer_Tick(object sender, EventArgs e)
        {
            game.stars.twinkle();
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
    }
}
