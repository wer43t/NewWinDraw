using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDrawCore
{
    abstract public class Drawer
    {
        public abstract void DrawLine(int x1, int y1, int x2, int y2);
        public abstract void DrawCircle(int x, int y, int r);

        public abstract void DrawRectangle(int x, int y, int height, int width);

        public abstract void DrawTriangle(int x, int y, Point[] points);
    }

}
