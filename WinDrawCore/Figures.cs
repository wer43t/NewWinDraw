using System;
using System.Collections.Generic;
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
}
