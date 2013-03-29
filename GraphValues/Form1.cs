using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GraphValues
{
    public partial class MainForm : Form
    {
        private Point _start = new Point();
        bool _boundaryMode, _pointMode;
        bool _drawing = false;
        
        Rectangle drawingRect;

        List<Point> _visPoints = new List<Point>();
        List<PointF> _percentPoints = new List<PointF>();
        List<PointF> _dataPoints = new List<PointF>();

        //public List<PointF> PercentPoints { get { return _percentPoints; } }
        //public BindingList<PointF> DataPoints 

        enum Mode {Boundary, Point};

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

            graphImage.Width = graphImage.Image.Width;
            graphImage.Height = graphImage.Image.Height;

            graphImage.Location = new Point((graphImage.Parent.Width / 2) - (graphImage.Width / 2),
                (graphImage.Parent.Height / 2) - (graphImage.Height / 2));

            SetMode(Mode.Boundary);
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void graphImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_boundaryMode)
            {
                _start = e.Location;
                drawingRect = new Rectangle(e.X, e.Y, 0, 0);
                graphImage.Invalidate();
                _drawing = true;
            }
        }

        private void graphImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawing && _boundaryMode)
            {
                if (graphImage.Image == null)
                    return;

                drawingRect = new Rectangle(_start.X, _start.Y, Math.Max(_start.X, e.X) - Math.Min(_start.X, e.X), Math.Max(_start.Y, e.Y) - Math.Min(_start.Y, e.Y));

                graphImage.Invalidate();
            }
        }

        private void graphImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawing && _boundaryMode)
            {
                _drawing = false;
                SetMode(Mode.Point);


            }
        }

        private void graphImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Red, drawingRect);

            foreach (Point point in _visPoints)
            {
                e.Graphics.FillEllipse(Brushes.Red, point.X - 2, point.Y - 2, 4, 4);
            }
        }

        private void toolStripButtonBoundary_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Boundary);
        }

        private void toolStripButtonPoint_Click(object sender, EventArgs e)
        {
            SetMode(Mode.Point);
        }

        private void graphImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (_pointMode)
            {
                Point point = new Point(e.X, e.Y);
                _visPoints.Add(point);
                graphImage.Invalidate();

                _percentPoints.Add(GetScalePoint(point));
            }
        }

        private void SwitchModes()
        {
            _boundaryMode = !_boundaryMode;
            toolStripButtonBoundary.Checked = _boundaryMode;

            _pointMode = !_pointMode;
            toolStripButtonPoint.Checked = _pointMode;
        }

        private void SetMode(Mode mode)
        {
            if (mode == Mode.Boundary)
            {
                _boundaryMode = toolStripButtonBoundary.Checked = true;
                _pointMode = toolStripButtonPoint.Checked = false;
            }
            else
            {
                _pointMode = toolStripButtonPoint.Checked = true;
                _boundaryMode = toolStripButtonBoundary.Checked = false;
            }
        }

        private PointF GetScalePoint(Point visPoint)
        {
            float relX = visPoint.X - drawingRect.X;
            // rectangle is wrong way up compared to the graph
            float relY = drawingRect.Height - visPoint.Y; 

            float percentX = (relX / (float)drawingRect.Width) * 100f;
            System.Diagnostics.Debug.WriteLine("percentX = " + percentX);

            return new PointF(percentX, 0f);
        }
    }
}
