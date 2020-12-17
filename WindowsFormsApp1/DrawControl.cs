using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DrawControl
    {
        static public List<Figure> FigureList = new List<Figure>();
        static int old_x,old_y;
        static List<Figure> objectOnMouse = new List<Figure>();
        public static Rectangle selector;

        public static void MakeRectangle(int x, int y)
        {
            old_x = x;
            old_y = y;
            Rectangle rectangle = new Rectangle(x,y,1,1,Convert.ToBoolean(MainForm.fillSwitch));
            FigureList.Add(rectangle);
            objectOnMouse.Add(FigureList[FigureList.Count - 1]);
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }
        public static void MakeLine(int x, int y)
        {
            old_x = x;
            old_y = y;
            Line line = new Line(x, y, 1, 1);
            FigureList.Add(line);
            objectOnMouse.Add(FigureList[FigureList.Count - 1]);
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }
        public static void MakeEllipse(int x, int y)
        {
            old_x = x;
            old_y = y;
            Ellipse elipse = new Ellipse(x, y, 1, 1,Convert.ToBoolean(MainForm.fillSwitch));
            FigureList.Add(elipse);
            objectOnMouse.Add(FigureList[FigureList.Count - 1]);
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }

        public static void ReDrawFigure(Graphics graphics)
        {
            foreach(Figure figure in FigureList)
            {
                figure.Draw(graphics);
            }
        }
        public static void Clear()
        {
            objectOnMouse.Clear();
        }
        public static void ObjectSizeChange(int new_x, int new_y)
        {
            foreach(var Figure in objectOnMouse )
                Figure.SizeChange(new_x, new_y,old_x,old_y);
        }

    }
}
