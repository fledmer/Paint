using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Rectangle:Figure
    {
        public override string name => "Rectangle";
        public Rectangle(int x, int y, int size_x, int size_y, bool isfilled)
            : base(x, y, size_x, size_y, isfilled)
        { }
        public override bool PointCollision(int x, int y)
        {
            if (x >= start_x && x <= start_x + size_x
                && y >= start_y && y <= start_y + size_y)
                return true;
            return false;
        }
        public override void Draw(Graphics graphics)
        {
            if(isfilled)
                graphics.FillRectangle(brush, start_x, start_y, size_x, size_y);
            graphics.DrawRectangle(pen, start_x, start_y, size_x, size_y);
        }
    }
}
