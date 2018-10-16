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
        private PlayerShip playerShip = new PlayerShip();

        /// <summary>
        /// 玩家生命值
        /// </summary>
        public int getPlayerLife()
        {
            return playerShip.life;
        }


        /// <summary>
        /// Game类的唯一实例
        /// </summary>
        public static Game instance { get; } = new Game();
        private Game()
        {
        }

        /// <summary>
        /// 移动玩家舰船
        /// </summary>
        /// <param name="direction">移动方向</param>
        /// <example>movePlayer(Direction.up | Direction.left)</example>
        public void movePlayer(Direction direction)
        {
            playerShip.move(direction);
        }

    } 
}
