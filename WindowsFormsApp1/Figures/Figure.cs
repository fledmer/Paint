using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Figure
    {
        protected Brush brush = new SolidBrush(MainForm.secondColor);
        protected Pen pen = new Pen(MainForm.firstColor, MainForm.penSize);
        public int start_x, start_y;
        public int size_x, size_y;

        public virtual string name { get; } = "Figure";

        protected Figure(int x, int y, int size_x, int size_y)
        {
            start_x = x;
            start_y = y;
            this.size_x = size_x;
            this.size_y = size_y;
        }

        virtual public void SizeChange(int new_x, int new_y, int old_x, int old_y)
        {
            if (new_x < old_x)
            {
                start_x = new_x;
                size_x = old_x - new_x;
            }
            else
                size_x = new_x - old_x;
            if (new_y < old_y)
            {
                start_y = new_y;
                size_y = old_y - new_y;
            }
            else
                size_y = new_y - old_y;
        }

        public virtual void Draw(Graphics graphics)
        {
            return;
        }

        
    }
}
