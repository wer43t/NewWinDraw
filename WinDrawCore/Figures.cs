using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDrawCore
{
    public class Figure
    {
        protected int x;
        protected int y;

        public Drawer drawer;

        public Figure(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public virtual void Draw()
        { }

        public override string ToString()
        {
            return base.ToString()+$";X={x};Y={y};";
        }
    }

    public class Line:Figure
    {
        protected int x2;
        protected int y2;

        public Line(int newX, int newY, int newX2, int newY2) : base(newX, newY)
        {
            x2 = newX2;
            y2 = newY2;
        }

        public override void Draw()
        {
            drawer.DrawLine(x, y, x2, y2);
        }

        public override string ToString()
        {
            return base.ToString() + $"X2={x2};Y2={y2};";
        }
    }

    public class Circle : Figure
    {
        protected int r;

        public Circle(int newX, int newY, int newR) : base(newX, newY)
        {
            r = newR;
        }

        public override void Draw()
        {
            drawer.DrawCircle(x, y, r);
        }

        public override string ToString()
        {
            return base.ToString() + $"R={r}";
        }
    }

    public class MyRectangle : Figure
    {
        protected int height;
        protected int width;

        public MyRectangle(int newX, int newY, int newHeight, int newWidth) : base (newX, newY)
        {
            height = newHeight;
            width = newWidth;
        }

        public override void Draw()
        {
            drawer.DrawRectangle(x, y, height, width);
        }

        public override string ToString()
        {
            return base.ToString() + $"Height = {height}, Width = {width}";
        }
    }

    public class Triangle : Figure
    {
        protected int endX;
        protected int endY;

        public Triangle (int newX, int newY, int newEndX, int newEndY) : base (newX, newY)
        {
            endX = newEndX;
            endY = newEndY;
        }

        private Point[] GetTrianglePoints()
        {
            Point[] p = new Point[3]
            {
                new Point(x + (endX - x) / 2, y),
                new Point(x, endY),
                new Point(endX, endY)
            };
            return p;
        }

        public override void Draw()
        {
            drawer.DrawTriangle(x, y, GetTrianglePoints());
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
