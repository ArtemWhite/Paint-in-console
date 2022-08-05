using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        int x_start; int x_end;
        int y_start; int y_end;
        bool paint = false;
        Bitmap bitmap;
        Bitmap temp;
        Bitmap clear;
        string tool = "toolStripBtnPen";
        Color color = Color.Black;
        Color color2 = Color.Red;
        string MouseBtn = "BtnLeft";
        int size = 5;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(panelDrawing.Width, panelDrawing.Height);
            temp = (Bitmap)bitmap.Clone();
            clear = (Bitmap)bitmap.Clone();
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(color, size);
            if(MouseBtn == "BtnRight") 
                pen = new Pen(color2, size);
            if (tool == "toolStripBtnPen"|| tool == "toolStripBtnClear")
            {
                Graphics g = Graphics.FromImage(temp);
                g.DrawLine(pen, x_start, y_start, x_end, y_end);
                x_start = x_end; y_start = y_end;               
            }
            if (tool== "toolStripBtnLine")
            { 
                temp = (Bitmap)bitmap.Clone();
                Graphics g = Graphics.FromImage(temp);
                g.DrawLine(pen, x_start, y_start, x_end, y_end);                                   
            }
            if (tool == "toolStripBtnRectangle")
            {
                temp = (Bitmap)bitmap.Clone();
                Graphics g = Graphics.FromImage(temp);
                if(x_start<x_end&&y_start<y_end)
                    g.DrawRectangle(pen, x_start, y_start, x_end-x_start, y_end-y_start);
                else if (x_start > x_end && y_start > y_end)
                    g.DrawRectangle(pen, x_end, y_end, x_start - x_end, y_start - y_end);
                else if (x_start < x_end && y_start > y_end)
                    g.DrawRectangle(pen, x_start, y_end, x_end - x_start, y_start - y_end);
                else if (x_start > x_end && y_start < y_end)
                    g.DrawRectangle(pen, x_end, y_start, x_start - x_end, y_end - y_start);
            }
            if (tool == "toolStripBtnEllips")
            {
                temp = (Bitmap)bitmap.Clone();
                Graphics g = Graphics.FromImage(temp);
                g.DrawEllipse(pen, x_start, y_start, x_end - x_start, y_end - y_start);         
            }
            if (tool == "toolStripBtnEraser")
            {
                Graphics g = Graphics.FromImage(temp);
                g.DrawLine(new Pen(Color.White,size), x_start, y_start, x_end, y_end);
                x_start = x_end; y_start = y_end;
            }
            e.Graphics.DrawImageUnscaled(temp, 0, 0);
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            bitmap = (Bitmap)temp.Clone();
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                x_end = e.X;
                y_end = e.Y;
                panelDrawing.Invalidate();
                panelDrawing.Update();
                Text = $"{x_start} {y_start} {x_end} {y_end}";

            }
        }

        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left) MouseBtn = "BtnLeft";
            else if(e.Button==MouseButtons.Right) MouseBtn = "BtnRight";
            x_start = e.X; y_start = e.Y;
            paint = true;
            temp = (Bitmap)bitmap.Clone();
        }
        private void toolStripBtnTool(object sender, EventArgs e)
        {
            tool = ((ToolStripButton)sender).Name;
            if (tool == "toolStripBtnClear")
            {
                bitmap = (Bitmap)clear.Clone();
                temp = (Bitmap)bitmap.Clone();
                panelDrawing.Invalidate();
                panelDrawing.Update();
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            { 
                color = colorDialog.Color;
                цветToolStripMenuItem.ForeColor = color;
            }
        }

        private void cBoxSize_TextChanged(object sender, EventArgs e)
        {
            int temp = size;
            if (Int32.TryParse(cBoxSize.Text, out temp))
                size = temp;
        }

        private void цвет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color2 = colorDialog.Color;
                цвет2ToolStripMenuItem.ForeColor = color2;
            }
        }
    }
}
