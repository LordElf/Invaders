using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    /// <summary>
    /// 统一管理游戏各项选项属性，如分辨率、操作按键设定等
    /// demo暂时不提供修改权限
    /// </summary>
    /// <remarks>
    /// 2018.10.13:创建. by woan
    /// </remarks>
    static class Options
    {
        /// <summary>
        /// 窗体宽度
        /// </summary>
        public static int width { get; } = 1280;

        /// <summary>
        /// 窗体高度
        /// </summary>
        public static int height { get; } = 720;


    }
}
