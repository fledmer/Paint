using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Ellipse:Figure
    {
        public override string name => "Circle";
        public Ellipse(int x, int y, int size_x, int size_y, bool isfilled)
            : base(x, y, size_x, size_y,isfilled)
        { }

        public override bool RectangleCollision(int start_x, int start_y, int end_x, int end_y)
        {
            if(this.start_x >= start_x && this.start_y >= start_y &&
                this.start_x + size_x <= end_x && this.start_y + size_y <= end_y)
                return true;
            return false;
        }

        public override void Draw(Graphics graphics)
        {
            if(isfilled)
                graphics.FillEllipse(brush, start_x, start_y, size_x, size_y);
            graphics.DrawEllipse(pen, start_x, start_y, size_x, size_y);
        }
    }
}
