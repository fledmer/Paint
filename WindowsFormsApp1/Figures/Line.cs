using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Line:Figure
    {
        int end_x;
        int end_y;

        public override string name => "Line";
        public Line(int x, int y, int size_x, int size_y)
            : base(x, y, size_x, size_y, false)
        { }
        public override void SizeChange(int new_x, int new_y, int old_x, int old_y)
        {
            start_x = new_x;
            start_y = new_y;
            end_x = old_x;
            end_y = old_y;
        }
        public override bool RectangleCollision(int start_x, int start_y, int end_x, int end_y)
        {
            if (Math.Min(this.end_x,this.start_x) >= start_x && Math.Min(this.end_y, this.start_y) >= start_y &&
                Math.Max(this.end_x, this.start_x) <= end_x && Math.Max(this.end_y, this.start_y) <= end_y)
                return true;
            return false;
        }
        public override void SizeChange(int dx, int dy, int type)
        {
            if (type == 1)
            {
                start_x -= dx;
                end_x += dx;
            }
            else if (type == 2)
            {
               start_y -= dy;
               end_y += dy;
            }
            else if (type == 3)
            {
                end_x += dx;
            }
            else if (type == 4)
            {
                end_y = dy;
            }

        }
        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen,start_x,start_y,end_x,end_y);
        }
    }
}
