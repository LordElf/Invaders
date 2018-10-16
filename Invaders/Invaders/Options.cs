using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    /// <summary>
    /// 统一管理游戏各项选项属性，如分辨率、操作按键设定等
    /// demo暂时不提供修改权限
    /// </summary>
    /// <remarks>
    /// 2018.10.13:创建. by woan
    /// 2018.10.16:增加按键设置. by woan
    /// </remarks>
    class Options
    {
        //TODO:Options应有对应配置文件

        private Options() { }
        public static Options instance { get; } = new Options();

        /// <summary>
        /// 窗体宽度
        /// </summary>
        public int width { get; } = 1280;

        /// <summary>
        /// 窗体高度
        /// </summary>
        public int height { get; } = 720;

        public enum GameBehaviors
        {
            moveUp, moveDown, moveLeft, moveRight, shot,
        }

        public GameKeys gameKeys { get; } = GameKeys.instance;
        public class GameKeys
        {
            public static GameKeys instance { get; } = new GameKeys();
            private GameKeys()
            {
                gameKeyList.Add(new GameKey(Keys.W, Keys.Up, GameBehaviors.moveUp));
                gameKeyList.Add(new GameKey(Keys.S, Keys.Down, GameBehaviors.moveDown));
                gameKeyList.Add(new GameKey(Keys.A, Keys.Left, GameBehaviors.moveLeft));
                gameKeyList.Add(new GameKey(Keys.D, Keys.Right, GameBehaviors.moveRight));
                
            }

            private class GameKey
            {
                public Keys firstKey { get; }  //第一按键设定
                public Keys secondKey { get; } //第二按键设定
                public GameBehaviors behavior { get; }

                public GameKey(Keys firstKey, Keys secondKey, GameBehaviors behavior)
                {
                    this.firstKey = firstKey;
                    this.secondKey = secondKey;
                    this.behavior = behavior;
                }

                public GameKey(Keys firstKey, GameBehaviors behaviors)
                {
                    this.firstKey = firstKey;
                    this.secondKey = Keys.None; //None不会引发KeyDown事件
                    this.behavior = behavior;
                }
            }
            static List<GameKey> gameKeyList = new List<GameKey>();

            static public GameBehaviors interpret(Keys keys)
            {
               return gameKeyList.Find(f => (f.firstKey == keys || f.secondKey == keys)).behavior;
            }
        }


    }
}
