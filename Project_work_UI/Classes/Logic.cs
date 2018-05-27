using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_work_UI
{
    public static class Logic
    {
        public static void FrameContentxPage(System.Windows.Controls.Page page, System.Windows.Controls.Frame frame)
        {
            page.Width = frame.Width;
            page.Height = frame.Height;
            frame.Content = page;
        }


    }
}
