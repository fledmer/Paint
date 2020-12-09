using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DrawControl
    {
        static int old_x,old_y;
        static Figure objectOnMouse;

        public static void MakeRectangle(int x, int y)
        {
            old_x = x;
            old_y = y;
            Rectangle rectangle = new Rectangle(x,y,1,1);
            MainForm.listObject.Add(rectangle);
            objectOnMouse = MainForm.listObject[MainForm.listObject.Count - 1];
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }
        public static void MakeLine(int x, int y)
        {
            old_x = x;
            old_y = y;
            Line line = new Line(x, y, 1, 1);
            MainForm.listObject.Add(line);
            objectOnMouse = MainForm.listObject[MainForm.listObject.Count - 1];
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }
        public static void MakeEllipse(int x, int y)
        {
            old_x = x;
            old_y = y;
            Ellipse elipse = new Ellipse(x, y, 1, 1);
            MainForm.listObject.Add(elipse);
            objectOnMouse = MainForm.listObject[MainForm.listObject.Count - 1];
            MainForm.MouseMoveEvent += ObjectSizeChange;
        }

        public static void ObjectSizeChange(int new_x, int new_y)
        {
            objectOnMouse.SizeChange(new_x, new_y,old_x,old_y);
        }

    }
}
