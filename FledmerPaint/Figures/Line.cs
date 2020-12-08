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
        public Line(int x, int y, int size_x, int size_y, Color color_fill, Color color_pen)
    : base(x, y, size_x, size_y, color_fill, color_pen)
        { }

        public override void SizeChange(int new_x, int new_y, int old_x, int old_y)
        {
            start_x = new_x;
            start_y = new_y;
            end_x = old_x;
            end_y = old_y;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(MainForm.pen,start_x,start_y,end_x,end_y);
        }
    }
}
