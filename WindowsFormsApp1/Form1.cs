using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        static public Color firstColor = Color.Black;
        static public Color secondColor = Color.White;
        static public int penSize = 1;
        static public int fillSwitch = 1;


        public static Selector select;
        Graphics graphics;
        Bitmap bitmap;

        public delegate void MouseHandler(int x, int y);
        public delegate void ClickHandler(int x, int y);
        public delegate void DrawHandler(Graphics graphics);
        public static event MouseHandler MouseMoveEvent;
        public static event ClickHandler MouseClickEvent;
        public static event DrawHandler ReDrawEvent;


        void ChangePositionBoxText(int x, int y)
        {
            textbox_PositionBoxX.Text = "M.X: " + x;
            textbox_PositionBoxY.Text = "M.Y: " + y;
        }

        public MainForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height);
            graphics = Graphics.FromImage(bitmap);
            MouseMoveEvent += ChangePositionBoxText;
        }

        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveEvent(e.X, e.Y);
            if (ReDrawEvent != null)
            {
                graphics.Clear(Color.White);
                ReDrawEvent(graphics);
                mainCanvas.Image = bitmap;

            }
        }

        private void mainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            ReDrawEvent += DrawControl.ReDrawFigure;
            MouseClickEvent?.Invoke(e.X,e.Y);
            
        }

        private void mainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMoveEvent -= DrawControl.ObjectSizeChange;
            ReDrawEvent -= DrawControl.ReDrawFigure;

            if (select != null)
            {
                graphics.Clear(Color.White);
                select.MouseUP();
                DrawControl.ReDrawFigure(graphics);
                select.ReDraw(graphics);
                mainCanvas.Image = bitmap;
            }
            DrawControl.Clear();
        }

        private void PenBox_CheckedChanged(object sender, EventArgs e)
        {
            colorDialog.Color = firstColor;
            colorDialog.ShowDialog();
            firstColor = colorDialog.Color;
            PenBox.BackColor = firstColor;
        }

        private void BrushBox_CheckedChanged(object sender, EventArgs e)
        {
            colorDialog.Color = secondColor;
            colorDialog.ShowDialog();
            secondColor = colorDialog.Color;
            BrushBox.BackColor = secondColor;
        }

        SizeChanger SizeChanger;
        private void PenButton_Click(object sender, EventArgs e) 
        {
            if(SizeChanger != null)
            {
                SizeChanger.Close();
            }
            SizeChanger = new SizeChanger(1, 40, 1,penSize,PenButton);
            SizeChanger.Show();
        }

        private void BrushButton_Click(object sender, EventArgs e)
        {
            if (SizeChanger != null)
            {
                SizeChanger.Close();
            }
            SizeChanger = new SizeChanger(0, 1, 1, fillSwitch, BrushButton);
            SizeChanger.Show();
        }

        private void BrushButton_TextChanged(object sender, EventArgs e)
        {
            fillSwitch = Convert.ToInt32(BrushButton.Text);
        }

        private void PenButton_TextChanged(object sender, EventArgs e)
        {
            penSize = Convert.ToInt32(PenButton.Text);
        }

        int FigureBox1ItemCheked = 0;
        private void FigureBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    if (!FigureBox1.GetItemChecked(0))
                    {
                        MouseClickEvent += DrawControl.MakeRectangle;
                        FigureBox1ItemCheked++;
                    }
                    else
                    {
                         MouseClickEvent -= DrawControl.MakeRectangle;
                        FigureBox1ItemCheked--;
                    }
                    break;
                case 1:
                    if (!FigureBox1.GetItemChecked(1))
                    {
                        MouseClickEvent += DrawControl.MakeEllipse;
                        FigureBox1ItemCheked++;
                    }    
                    else
                    {
                        MouseClickEvent -= DrawControl.MakeEllipse;
                        FigureBox1ItemCheked--;
                    }
                    break;
                case 2:
                    if (!FigureBox1.GetItemChecked(2))
                    {
                        MouseClickEvent += DrawControl.MakeLine;
                        FigureBox1ItemCheked++;
                    }
                    else
                    {
                        MouseClickEvent -= DrawControl.MakeLine;
                        FigureBox1ItemCheked--;
                    }
                    break;
            }
            if (FigureBox1ItemCheked != 0)
                ToolBox.Enabled = false;
            else
                ToolBox.Enabled = true;
        }
        int ToolBoxItemCheked = 0;
        private void ToolBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    if (!ToolBox.GetItemChecked(0))
                    {
                        MouseClickEvent = Selector.CreateSelector;
                        ToolBoxItemCheked++;
                    }    
                    else
                    {
                        MouseClickEvent -= Selector.CreateSelector;
                        Selector.Destroy();
                        ToolBoxItemCheked--;
                    }
                    break;
            }
            if (ToolBoxItemCheked != 0)
                FigureBox1.Enabled = false;
            else
                FigureBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                // запишем в нашу переменную путь к папке
                bitmap.Save(folderBrowserDialog1.SelectedPath + "\\picture.png");
                bitmap.Save("picture.png");
            }
        }
    }
}
