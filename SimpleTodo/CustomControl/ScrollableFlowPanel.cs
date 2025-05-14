using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTodo.CustomControl
{
    public class ScrollableFlowPanel : FlowLayoutPanel
    {
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(nint hWnd, int wBar, bool bShow);

        private const int SB_HORZ = 0;
        private const int SB_VERT = 1;

        public ScrollableFlowPanel()
        {
            AutoScroll = true;
            DoubleBuffered = true;
            Resize += (s, e) => RefreshScrollBars();
            ControlAdded += (s, e) => RefreshScrollBars();
            ControlRemoved += (s, e) => RefreshScrollBars();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            RefreshScrollBars();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x85 || m.Msg == 0x14 || m.Msg == 0x0015 || m.Msg == 0x020A)
            {
                RefreshScrollBars();
            }
        }

        private void RefreshScrollBars()
        {
            if (IsHandleCreated)
            {
                ShowScrollBar(Handle, SB_HORZ, false);
                ShowScrollBar(Handle, SB_VERT, false);
            }
        }
    }

}
