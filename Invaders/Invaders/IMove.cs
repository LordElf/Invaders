using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    /// <summary>
    /// 用于的方向枚举
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
    /// Interface of move
    /// </summary>
    interface IMove
    {
        void Move(Direction direction);
    }
}
