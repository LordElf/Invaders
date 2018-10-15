using System;
using System.Drawing;
using System.Windows.Forms;

namespace Invaders
{
    /// <summary>
    /// Game对象管理游戏的进行
    /// </summary>
    /// <remarks>
    /// 2018.11.13: 创建. by woan
    /// </remarks>
    public class Game
    {
        /// <summary>
        /// 当前分数
        /// </summary>
        public int currentScore { get; } = 0;
        public PlayerShip playerShip = new PlayerShip();


        /// <summary>
        /// Game类的唯一实例
        /// </summary>
        public static Game instance { get; } = new Game();
        private Game()
        {
        }


    } 
}
