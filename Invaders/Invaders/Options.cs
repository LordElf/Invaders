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



    
    static class Options
    {
        //TODO:Options应有对应配置文件
         
        //以下数个宽高属性顺序不可更改，累赘属性用于可能的UI设计更改

        /// <summary>
        /// 窗体宽度
        /// </summary>
        static public int formWidth { get; } = 1280;

        /// <summary>
        /// 窗体高度
        /// </summary>
        static public int formHeight { get; } = 720;

        /// <summary>
        /// 游戏主体框的宽度
        /// </summary>
        static public int gameWidth { get; } = formWidth;    

        /// <summary>
        /// 游戏主体框的高度
        /// </summary>
        static public int gameHeight { get; } = formHeight;

        /// <summary>
        /// 游戏左边界X坐标
        /// </summary>
        static public int gameLeftBorder { get; } = 0;    



        /// <summary>
        /// 游戏右边界X坐标
        /// </summary>
        static public int gameRightBorder { get; } = gameLeftBorder + gameWidth;

        /// <summary>
        /// 游戏上边界Y坐标
        /// </summary>
        static public int gameUpBorder { get; } = gameHeight / 10;      //预留分数显示位置

        /// <summary>
        /// 游戏下边界Y坐标
        /// </summary>
        static public int gameDownBorder { get; } = gameHeight;
    }


    ///<summary>玩家的行为，GameKeys的映射类型</summary>
    public enum GameBehaviors
    {
        /// <summary>待机</summary>
        standBy,

        /// <summary>向上移动</summary>
        moveUp,

        /// <summary>向下移动</summary>
        moveDown,

        /// <summary>向左移动</summary>
        moveLeft,

        /// <summary>向右移动</summary>
        moveRight,

        /// <summary>发射炮弹</summary>
        shot,

        /// <summary>
        /// 暂停游戏
        /// </summary>
        pause,

        /// <summary>
        /// 退出游戏
        /// </summary>
        quit,
    }


    /// <summary>
    /// 游戏按键设置
    /// </summary>
    public class GameKeys
    {
        /// <summary>
        /// GameKeys类的唯一实例
        /// </summary>
        public static GameKeys instance { get; } = new GameKeys();

        static GameKeys()
        {
            gameKeyList.Add(new GameKey(Keys.W, Keys.Up, GameBehaviors.moveUp));
            gameKeyList.Add(new GameKey(Keys.S, Keys.Down, GameBehaviors.moveDown));
            gameKeyList.Add(new GameKey(Keys.A, Keys.Left, GameBehaviors.moveLeft));
            gameKeyList.Add(new GameKey(Keys.D, Keys.Right, GameBehaviors.moveRight));
            gameKeyList.Add(new GameKey(Keys.Space, Keys.None, GameBehaviors.shot));
            gameKeyList.Add(new GameKey(Keys.Escape, Keys.P, GameBehaviors.pause));
            gameKeyList.Add(new GameKey(Keys.Q, Keys.None, GameBehaviors.quit));

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

            //public GameKey(Keys firstKey, GameBehaviors behaviors)
            //{
            //    this.firstKey = firstKey;
            //    this.secondKey = Keys.None; //None不会引发KeyDown事件
            //    this.behavior = behavior;
            //}
        }
        static List<GameKey> gameKeyList = new List<GameKey>();

        /// <summary>
        /// 将按键解释为游戏行为
        /// </summary>
        /// <param name="keys">按键输入</param>
        /// <returns>GameBehaviors枚举</returns>
        static public GameBehaviors interpret(Keys keys)
        {
            try
            {
                return gameKeyList.Find(f => (f.firstKey == keys || f.secondKey == keys)).behavior;
            }
            catch (NullReferenceException)
            {
                return GameBehaviors.standBy;
            }
                

            
        }
    }

    static class FilePath
    {
        public const string ART_NORMAL_BULLET = 
            @"D:\Projects\Visual Studio项目\Invaders\Art\normalBullet.png";
        public const string ART_PLAYER_SHIP =
            @"D:\Projects\Visual Studio项目\Invaders\Art\playerShip.png";
    }


}
