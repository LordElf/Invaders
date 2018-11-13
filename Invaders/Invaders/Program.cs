using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    /// <summary>
    /// 应用程序主入口点
    /// </summary>
    /// <remarks>
    /// 2018.10.12: 由VS自动创建  by woan
    /// </remarks>
    static class Program
    {
        static public Form form = new Form();

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form);
        }
    }
}
