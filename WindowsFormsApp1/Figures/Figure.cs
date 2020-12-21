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
        public Brush brush = new SolidBrush(MainForm.secondColor);
        public Pen pen = new Pen(MainForm.firstColor, MainForm.penSize);
        public int start_x, start_y;

        int _size_x, _size_y;
        public int size_x
        {
            get
            {
                return _size_x;
            }
            set
            {
                _size_x = Math.Abs(value); 
            }
        }
        public int size_y
        {
            get
            {
                return _size_y;
            }
            set
            {
                _size_y = Math.Abs(value);
            }
        }

        public bool isfilled;

        public virtual string name { get; } = "Figure";

        protected Figure(int x, int y, int size_x, int size_y,bool isfilled)
        {
            start_x = x;
            start_y = y;
            this.size_x = size_x;
            this.size_y = size_y;
            this.isfilled = isfilled;
        }
        public virtual bool RectangleCollision(int start_x, int start_y, int end_x, int end_y)
        {
            if (this.start_x >= start_x && this.start_y >= start_y &&
                this.start_x + size_x <= end_x && this.start_y + size_y <= end_y)
                return true;
            return false;
        }
        virtual public bool PointCollision(int x, int y)
        {
            return false;
        }
        virtual public void SizeChange(int new_x, int new_y, int old_x, int old_y)
        {
            if (new_x < old_x)
            {
                start_x = new_x;
                _size_x = old_x - new_x;
            }
            else
                _size_x = new_x - old_x;
            if (new_y < old_y)
            {
                start_y = new_y;
                _size_y = old_y - new_y;
            }
            else
                _size_y = new_y - old_y;
        }
        virtual public void SizeChange(int dx, int dy,int type)
        {
            if(type == 1)
            {
                size_x -= dx;
                start_x += dx;
            }
            else if(type == 2)
            {
                size_y -= dy;
                start_y += dy;
            }
            else if (type == 3)
            {
                size_x += dx;
            }
            else if (type == 4)
            {
                size_y += dy;
            }

        }

        public virtual void Draw(Graphics graphics)
        {
            return;
        }

        
    }
}
