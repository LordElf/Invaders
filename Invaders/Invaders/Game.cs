using System;
namespace Invaders
{
    /// <summary>
    /// Game对象管理游戏的进行
    /// </summary>
    public class Game
    {
        /// <summary>
        /// Game类的唯一实例
        /// </summary>
        public static Game instance { get; } = new Game();

        Stars stars;

        private Game()
        {

        }


    } 
}
