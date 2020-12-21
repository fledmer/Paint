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


        public override void Draw(Graphics graphics)
        {
            if(isfilled)
                graphics.FillEllipse(brush, start_x, start_y, size_x, size_y);
            graphics.DrawEllipse(pen, start_x, start_y, size_x, size_y);
        }
    }
}
