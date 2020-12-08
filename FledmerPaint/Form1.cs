﻿using System;
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
        public static Pen pen = new Pen(Color.Black,1);
        public static Brush brush = new SolidBrush(Color.DarkGray);

        Graphics graphics;
        Bitmap bitmap;

        static public List<Figure> listObject = new List<Figure>();

        public delegate void MouseHandler(int x, int y);
        public delegate void ClickHandler(int x, int y, Color fill, Color pen);
        public static event MouseHandler MouseMoveEvent;
        public static event ClickHandler MouseClickEvent;

        Color color_fill = Color.Black;
        Color color_pen = Color.Black;

        void ChangePositionBoxText(int x, int y)
        {
            textbox_PositionBoxX.Text = "M.X: " + x;
            textbox_PositionBoxY.Text = "M.Y: " + y;
        }

        void ReDraw(int x, int y)
        {
            graphics.Clear(Color.White);
            foreach (var Object in listObject)
                Object.Draw(graphics);
            mainCanvas.Image = bitmap;
        }

        public MainForm()
        {
            InitializeComponent();
            bitmap = new Bitmap(mainCanvas.Width, mainCanvas.Height);
            graphics = Graphics.FromImage(bitmap);
            MouseMoveEvent += ChangePositionBoxText;
            MouseClickEvent += DrawControl.MakeRectangle;
        }

        private void mainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoveEvent(e.X, e.Y);
        }

        private void mainCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            MouseClickEvent(e.X, e.Y, color_fill, color_pen);
            MouseMoveEvent += ReDraw;
        }

        private void mainCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMoveEvent -= DrawControl.ObjectSizeChange;
            MouseMoveEvent -= ReDraw;
        }


        private void rectanlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseClickEvent = DrawControl.MakeRectangle;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseClickEvent = DrawControl.MakeLine;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MouseClickEvent = DrawControl.MakeEllipse;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void figureBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch(figureBox.SelectedIndex)
            {
                case 0:
                    MouseClickEvent = DrawControl.MakeLine;
                    break;
                case 1:
                    MouseClickEvent = DrawControl.MakeRectangle;
                    break;
                case 2:
                    MouseClickEvent = DrawControl.MakeEllipse;
                    break;

            }
        }
    }
}
