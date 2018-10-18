using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    /// <summary>
    /// info of guns
    /// </summary>
    /// <remarks>
    /// created on 10/17/2018 20:09 by Shawn 
    /// </remarks>
    abstract class Gun
    {
        // time interval between two shots (ms)
        protected int shottingInterval;
        public void shot(Bullet bullet, PaintEventArgs e)
        {
            Pen myBrush = new Pen(Color.Yellow, 3);
            //e.Graphics.DrawRectangle(myBrush, bullet.size);
            myBrush.Dispose();
        }
        enum direction
        {
            up, 
            down
        }

        internal void shot()
        {
        }
    }

    class railGun : Gun
    {
        public railGun()
        {
            this.shottingInterval = 100;
        }
    }

    class normalGun : Gun
    {
        public normalGun()
        {
            this.shottingInterval = 300;
        }
    }
}
