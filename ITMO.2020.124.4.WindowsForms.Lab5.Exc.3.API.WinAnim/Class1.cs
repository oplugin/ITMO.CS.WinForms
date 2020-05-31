using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AnimatedWindow
{
    public class WinAPIClass
    {
        #region Анимация окна
        [Flags]
        public enum AnimatedWindowFlags : int
        {
            AW_HOR_POSITIVE = 1,
            AW_HOR_NEGATIVE = 2,
            AW_VER_POSITIVE = 4,
            AW_VER_NEGATIVE = 8,
            AW_CENTR = 16,
            AW_HIDE = 65536,
            AW_ACTIVATE = 131072,
            AW_SLIDE = 262144,
            AW_BLEND = 524288
        };
        [DllImportAttribute("user32.dll", EntryPoint = "AnimatedWindow", SetLastError = true)]
        public static extern bool AnimatedWindow(IntPtr hwnd, int dwTime, int dwFlags);

        public static bool AnimatedWindow(Control ctrl, int dwTime, AnimatedWindowFlags Flags)
        {
            return AnimatedWindow(ctrl.Handle, dwTime, (int)Flags);
        }
        #endregion
    }
}
