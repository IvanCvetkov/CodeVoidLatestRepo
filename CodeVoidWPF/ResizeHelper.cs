using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeVoidWPF
{
    class ResizeHelper
    {
        public ResizeHelper()
        {
            MainWindow.win.WindowResized += Win_WindowResized;
        }

        private void Win_WindowResized(object sender, EventArgs e)
        {
            if (((MWResizeArgs)e).state == System.Windows.WindowState.Maximized)//When Maximized
            {
                MainWindow.win.TitleBarButtons.Margin = new System.Windows.Thickness(MainWindow.win.Width -355, 0, 0, 0);
            }
            else//When Normal
            {
                MainWindow.win.TitleBarButtons.Margin = new System.Windows.Thickness(630, 0, 0, 0);
            }
        }
    }
}
