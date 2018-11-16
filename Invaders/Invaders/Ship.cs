using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    /// <summary>
    /// 用于舰船移动的方向枚举
    /// </summary>
    [Flags]
    public enum Direction
    {
        /// <summary>左</summary>
        left,

        /// <summary>右</summary>
        right,

        /// <summary>上</summary>
        up,

        /// <summary>下</summary>
        down
    }

    /// <summary>
    /// 舰船类
    /// </summary>
    abstract public class Ship
    {
        public bool isDead = false;

        /// <summary>
        /// 舰船的生命值
        /// </summary>
        public int life { get; }
        /// <summary>
        /// 舰船的X坐标
        /// </summary>
        public int positionX { get; set; }
        /// <summary>
        /// 舰船的Y坐标
        /// </summary>
        public int positionY { get; set; }
        ///<summary>
        ///飞船的大小 Width Height
        /// </summary>
        public int width { get; set; }
        ///<summary>
        ///飞船的高度Heigh 为width的4/3
        /// </summary>
        public int heigh { get; set;} 
        /// <summary>
        /// 舰船每帧可移动的距离，单位为像素
        /// </summary>
        protected int speed;

        protected int leftBorderMagicNum = 0;       //左边界的神奇误差
        protected int rightBorderMagicNum = 0;       //右边界的神奇误差
        protected int upBorderMagicNum = 0;       //上边界有计算误差，因为根本没有算分数等元素的高度
        protected int downBorderMagicNum = 0;       //下边界的神奇误差

        /// <summary>
        /// 舰船上所有的枪
        /// </summary>
        protected List<Gun> guns = new List<Gun>();


        /// <summary>
        /// 飞船的移动
        /// </summary>
        /// <param name="direction">移动方向，在同一命名空间定义</param>
        public void move(Direction direction)
        {

            #region 备用代码
            /*created by Shawn
            int currentPositionX = positionX, currentPositionY = positionY;
            switch (direction)
            {
                case Direction.down:
                    currentPositionY += speed;
                    break;
                case Direction.up:
                    currentPositionY -= speed;
                    break;
                case Direction.left:
                    currentPositionX -= speed;
                    break;
                case Direction.right:
                    currentPositionX += speed;
                    break;
                default:
                    break;
            }
            
            if(currentPositionX >= Options.gameLeftBorder && currentPositionX + shipWidth <= Options.gameRightBorder
                && currentPositionY >= Options.gameUpBorder && currentPositionY + shipHeigh <= Options.gameDownBorder)
            {
                positionX = currentPositionX;
                positionY = currentPositionY;
            }
            */
            #endregion


            int tempPositionX = positionX;
            int tempPositionY = positionY;
            ///枪的偏移量
            int gunsOffsetX = 0;
            int gunsOffsetY = 0;
            
            if (direction == Direction.left)
            {
                tempPositionX -= speed;
                if (tempPositionX <= Options.gameLeftBorder - leftBorderMagicNum)
                {
                    tempPositionX = Options.gameLeftBorder - leftBorderMagicNum;
                }
                gunsOffsetX = tempPositionX - positionX;
            }
            if (direction == Direction.right)
            {
                tempPositionX += speed;
                if (tempPositionX + width >= Options.gameRightBorder + rightBorderMagicNum)
                {
                    tempPositionX = Options.gameRightBorder - width + rightBorderMagicNum;
                }
                gunsOffsetX = tempPositionX - positionX;
            }
            if (direction == Direction.up)
            {
                tempPositionY -= speed;
                if (tempPositionY <= Options.gameUpBorder - upBorderMagicNum)
                {
                    tempPositionY = Options.gameUpBorder - upBorderMagicNum;
                }
                gunsOffsetY = tempPositionY - positionY;
            }
            if (direction == Direction.down)
            {
                tempPositionY += speed;
                if (tempPositionY + heigh >= Options.gameDownBorder - downBorderMagicNum)
                {
                    tempPositionY = Options.gameDownBorder - heigh - downBorderMagicNum;
                }
                gunsOffsetY = tempPositionY - positionY;
            }

            positionX = tempPositionX;
            positionY = tempPositionY;

            int Offset;
            if (direction == Direction.up || direction == Direction.down)
            {
                Offset = gunsOffsetY;
            }
            else
            {
                Offset = gunsOffsetX;
            }
            foreach(Gun g in guns)
            {
                g.move(direction, Offset);
            }
            
        }

        /// <summary>
        /// 遍历所有gun并执行其shot()方法
        /// </summary>
        /// <returns>由所有shot()方法返回的新的Bullet的引用</returns>
        abstract public List<Bullet> shot();

    }

<<<<<<< HEAD
    

=======
>>>>>>> 3fa28764a5aee22609e39d41610f0edff79ae767

    /// <summary>
    /// 玩家的舰船
    /// </summary>
    public class PlayerShip : Ship
    {
        /// <summary>
        /// the player's ship
        /// </summary>
        public PlayerShip()
        {
            this.speed = 10;
            this.width = Options.formWidth / 16;
            this.heigh = width;    
            this.positionX = (Options.gameRightBorder - Options.gameLeftBorder) / 2 - width + 30; //神奇误差，如上
            this.positionY = Options.gameDownBorder - heigh - 35;
            leftBorderMagicNum = 0;       //左边界的神奇误差
            rightBorderMagicNum = -15;       //右边界的神奇误差
            upBorderMagicNum = -15;       //上边界有计算误差，因为根本没有算分数等元素的高度
            downBorderMagicNum = 35;       //下边界的神奇误差

            guns.Add(new normalGun(positionX, positionY));
        }



        /// <summary>
        /// 遍历所有gun并执行其shot()方法
        /// </summary>
        /// <returns>由所有shot()方法返回的新的Bullet的引用</returns>
        public override List<Bullet> shot()
        {
            List<Bullet> bullets = new List<Bullet>();
            Bullet temp;
            foreach(Gun g in guns)
            {
                temp = g.shot();
                if (temp != null)
                {
                    bullets.Add(g.shot());
                }
            }
            return bullets;
        }
    }

    public class EnemyShip : Ship
    {
        public override List<Bullet> shot()
        {
            throw new NotImplementedException();
        }

        public EnemyShip()
        {
            positionY = -20;
            positionX = new Random().Next(0, Options.gameRightBorder);
            //此行代码可能存在导致同一时间内生成的敌船在同一位置
            speed = 16;
            width = 18;
            heigh = 32;
        }

        bool leftTurn = true;//当该值为真时，飞船向左飞行，否则向右
        public void go()
        {
            this.move(Direction.down);
            if (leftTurn)
            {
                move(Direction.left);
            }
            else
            {
                move(Direction.right);
            }

            if (positionX <= 0 + leftBorderMagicNum)
            {
                leftTurn = false;
            }
            if (positionX >= Options.gameRightBorder)
            {
                leftTurn = true;
            }

            if (positionY >= Options.gameDownBorder - 100)
            {
                isDead = true;
            }
        }


        public void draw(Graphics graphics)
        {
           graphics.DrawImage(Image.FromFile(FilePath.ART_PLAYER_SHIP), positionX, positionY, width, heigh);
        }

        
    }

}
