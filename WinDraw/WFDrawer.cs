using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using WinDrawCore;

namespace WinDraw
{
    public class WFDrawer : Drawer
    {
        private Pen pen;
        private Graphics paper;

        public WFDrawer(Pen newPen, Graphics newPaper)
        {
            pen = newPen;
            paper = newPaper;
        }

        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            paper.DrawLine(pen, x1, y1, x2, y2);
        }

        public override void DrawCircle(int x, int y, int r)
        {
            paper.DrawEllipse(pen, x, y, r, r);
        }
    }
}
