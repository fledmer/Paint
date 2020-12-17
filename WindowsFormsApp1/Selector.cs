using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Selector
    {
        List<Figure> inArea = new List<Figure>();
        Rectangle area;
        int old_start_x;
        int old_start_y;
        int move_point_x;
        int move_point_y;
        public int start_x
        {
            get
            {
                return area.start_x;
            }
            set
            {
                area.start_x = value;
            }
        }
        public int start_y
        {
            get
            {
                return area.start_y;
            }
            set
            {
                area.start_y = value;
            }
        }
        public int end_x
        {
            get
            {
                return start_x + area.size_x;
            }
            set
            {
                area.size_x = value - start_x;
            }
        }
        public int end_y
        {
            get
            {
                return start_y + area.size_y;
            }
            set
            {
                area.size_y = value - start_y;
            }
        }

        public Selector(int x, int y)
        {
            Destroy();
            old_start_x = x;
            old_start_y = y;
            area = new Rectangle(x, y, 1, 1, false);
            area.pen.Color = Color.Black;
            area.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            area.pen.Width = 1;
            MainForm.MouseMoveEvent += ChangeSize;
            MainForm.ReDrawEvent += ReDraw;
        }

        ~Selector()
        {
            foreach (Figure figure in inArea)
            {
                try
                {
                    figure.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    figure.pen.Width -= 3;
                }
                catch { }
            }
        }

        void CollisionCheck()
        {
            List<Figure> removelist = new List<Figure>();
            foreach (Figure figure in inArea)
            {
                if (!figure.RectangleCollision(start_x, start_y, end_x, end_y))
                {
                    figure.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    figure.pen.Width -= 3;
                    removelist.Add(figure);
                }
            }
            foreach (Figure figure in removelist)
            {
                inArea.Remove(figure);
            }
                foreach (Figure figure in DrawControl.FigureList)
                {
                if (figure.RectangleCollision(start_x, start_y, end_x, end_y))
                {
                    if (!inArea.Contains(figure))
                    {
                        inArea.Add(figure);
                        figure.pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        figure.pen.Width += 3;
                    }
                }
            }
        }

        public void ChangeSize(int new_x, int new_y)
        {
            area.SizeChange(new_x, new_y, old_start_x, old_start_y);
            CollisionCheck();
        }
        public void ReDraw(Graphics graphics)
        {
            area.Draw(graphics);
        }

        public void SetPointMove(int x, int y)
        {
            move_point_x = x;
            move_point_y = y;
            MainForm.MouseMoveEvent += Move;
            MainForm.ReDrawEvent += DrawControl.ReDrawFigure;
        }
        public void Move(int x, int y)
        {
            area.start_x += x - old_start_x;
            area.start_y += y - old_start_y;
            foreach (Figure figure in inArea)
            {
                figure.start_x += x - old_start_x;
                figure.start_y += y - old_start_y;
            }
        }
        public void MouseUP()
        {
            int min_x = int.MaxValue;
            int min_y = int.MaxValue;
            int max_x = 0;
            int max_y = 0;
            foreach (Figure figure in inArea)
            {
                if (figure.start_x < min_x)
                    min_x = figure.start_x;
                if (figure.start_y < min_y)
                    min_y = figure.start_y;
                if (figure.start_x+figure.size_x > max_x)
                    max_x = figure.start_x + figure.size_x;
                if (figure.start_y+figure.size_y > max_y)
                    max_y = figure.start_y + figure.size_y;
            }
            start_x = min_x;
            start_y = min_y;
            end_x = max_x;
            end_y = max_y;
        }
        public static void CreateSelector(int x, int y)
        {
            MainForm.select = new Selector(x, y);
        }
        static public void Destroy()
        {
            MainForm.select = null;
            GC.Collect();
        }
    }
}
