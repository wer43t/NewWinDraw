using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinDrawCore;

namespace WinDrawConsole
{
    class Program
    {
        static private List<Figure> figures;
        static void Main(string[] args)
        {
            string choose;
            figures = new List<Figure>();
            
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("  Create Line - L");
                Console.WriteLine("  Create Line - C");
                Console.WriteLine("  Redraw      - R");
                Console.WriteLine("  Exit        - X");
                choose = Console.ReadLine().ToUpper();
                switch (choose)
                {
                    case "L": AddLine(); break;
                    case "C": break;
                    case "R": Redraw();  break;
                    case "X": return; 
                }
            }
        }

        static public void AddLine()
        {
            var figData = new FiguresData
            {
                Name = "Line",
                Data = new Dictionary<string, int>
                {
                    { "X1", 0 },
                    { "Y1", 0 },
                    { "X2", 100 },
                    { "Y2", 100 }
                }
            };
            var fig = FigureFab.Make(figData);
            fig.drawer = new ConsoleDrawer();
            figures.Add(fig);
        }

        static public void AddCircle()
        {
            var figData = new FiguresData
            {
                Name = "Circle",
                Data = new Dictionary<string, int>
                {
                    { "X", 0 },
                    { "Y", 0 },
                    { "Radius", 0 }
                }
            };
            var fig = FigureFab.Make(figData);
            fig.drawer = new ConsoleDrawer();
            figures.Add(fig);
        }

        static public void Redraw()
        {
            foreach (var f in figures)
            {
                f.Draw();
            }
        }
    }

    public class ConsoleDrawer : Drawer
    {
        public override void DrawLine(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Draw line from {x1}, {y1}, to {x2}, {y2}");
        }

        public override void DrawCircle(int x, int y, int r)
        {
            Console.WriteLine($"Draw circle at {x}, {y}, radius {r}");
        }
    }
}
