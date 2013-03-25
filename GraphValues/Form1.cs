using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphValues
{
    public partial class MainForm : Form
    {
        private Point _start = new Point();
        bool _drawing = false;
        Rectangle drawingRect;

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(open.FileName);
                graphImage.Image = bmp;
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void graphImage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("clik");
        }

        private void graphImage_MouseDown(object sender, MouseEventArgs e)
        {
            _start = e.Location;
            drawingRect = new Rectangle(e.X, e.Y, 0, 0);
            graphImage.Invalidate();
            _drawing = true;
        }

        private void graphImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawing)
            {
                if (graphImage.Image == null)
                    return;

                drawingRect = new Rectangle(_start.X, _start.Y, Math.Max(_start.X, e.X) - Math.Min(_start.X, e.X), (Math.Max(_start.Y, e.Y) - Math.Min(_start.Y, e.Y)));

                graphImage.Invalidate();
            }
        }

        private void graphImage_MouseUp(object sender, MouseEventArgs e)
        {
            _drawing = false;

            //if (graphImage.Image == null)
            //    return;

            //using (Graphics g = Graphics.FromImage(graphImage.Image))
            //{
            //    g.DrawRectangle(Pens.Red, new Rectangle(_start.X, _start.Y, e.X - _start.X, e.Y - _start.Y));
            //}
            //graphImage.Invalidate();
        }

        private void graphImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, drawingRect);
        }
    }
}
