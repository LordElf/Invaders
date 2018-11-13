using System;
using System.Collections.Generic;
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

        /// <summary>
        /// get the player's poisition
        /// </summary>
        /// <returns></returns>
        public Point getPlayerPoisition()
        {
            return new Point(playerShip.positionX, playerShip.positionY);
        }

        /// <summary>
        /// get the player's width
        /// </summary>
        /// <returns></returns>
        public int getPlayerWidth()
        {
            return playerShip.width;
        }

        /// <summary>
        /// get the player's height
        /// </summary>
        /// <returns></returns>
        public int getPlayerHeight()
        {
            return playerShip.heigh;
        }

        //It's useless
        ///// <summary>
        ///// get the gun location
        ///// </summary>
        ///// <returns></returns>
        //public Point getPlayerGunPosition()
        //{
        //    return new Point(playerShip.positionX + playerShip.width / 2, playerShip.positionY + 5);
        //}

        /// <summary>
        /// 游戏内的所有子弹，用以交由form绘制
        /// </summary>
        public List<Bullet> bullets { get; } = new List<Bullet>();

        /// <summary>
        /// shot a bullet
        /// </summary>
        /// <returns></returns>
        public void shot()
        {
            bullets.AddRange(playerShip.shot());
        }

        /// <summary>
        /// 绘制所有游戏对象
        /// </summary>
        public void draw(Graphics graphics)
        {
            foreach (Bullet i in bullets)
            {
               i.draw(graphics);
            }
        }
    } 
}
