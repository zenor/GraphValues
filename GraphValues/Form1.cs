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
        bool _axisMode, _pointMode;
        bool _drawing = false;
        
        Rectangle drawingRect;

        enum AxisData
        {
            XStart = 0, XEnd = 1, YStart = 2, YEnd = 3
        };
        List<float> _axisData = new List<float>(4);
        List<Point> _visPoints = new List<Point>();
        List<PointF> _dataPoints = new List<PointF>();

        //public BindingList<PointF> DataPoints 

        enum Mode {Boundary, Point};

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
                _axisData.Add(0f);
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
            if (_axisMode)
            {
                _start = e.Location;
                drawingRect = new Rectangle(e.X, e.Y, 0, 0);
                graphImage.Invalidate();
                _drawing = true;
            }
        }

        private void graphImage_MouseMove(object sender, MouseEventArgs e)
        {
            if (_drawing && _axisMode)
            {
                if (graphImage.Image == null)
                    return;

                drawingRect = new Rectangle(_start.X, _start.Y, Math.Max(_start.X, e.X) - Math.Min(_start.X, e.X), Math.Max(_start.Y, e.Y) - Math.Min(_start.Y, e.Y));

                graphImage.Invalidate();
            }
        }

        private void graphImage_MouseUp(object sender, MouseEventArgs e)
        {
            if (_drawing && _axisMode)
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

                _dataPoints.Add(GetScalePoint(point));
            }
        }

        private void SwitchModes()
        {
            _axisMode = !_axisMode;
            toolStripButtonBoundary.Checked = _axisMode;

            _pointMode = !_pointMode;
            toolStripButtonPoint.Checked = _pointMode;
        }

        private void SetMode(Mode mode)
        {
            if (mode == Mode.Boundary)
            {
                _axisMode = toolStripButtonBoundary.Checked = true;
                _pointMode = toolStripButtonPoint.Checked = false;
            }
            else
            {
                _pointMode = toolStripButtonPoint.Checked = true;
                _axisMode = toolStripButtonBoundary.Checked = false;
            }
        }

        private PointF GetScalePoint(Point visPoint)
        {
            float relX = visPoint.X - drawingRect.Left;
            // rectangle is wrong way up compared to the graph
            // so we first find where we are whilst upside down
            // then flip, by subtracting that from the height.
            float relY = visPoint.Y - drawingRect.Top;
            relY = drawingRect.Height - relY;

            float percentX = (relX / (float)drawingRect.Width);
            float percentY = (relY / (float)drawingRect.Height);
            System.Diagnostics.Debug.WriteLine("percents = " + percentX + ", " + percentY);

            float xAxisLength = _axisData[(int)AxisData.XEnd] - _axisData[(int)AxisData.XStart];
            float realXVal = _axisData[(int)AxisData.XStart] + (xAxisLength * percentX);
            float yAxisLength = _axisData[(int)AxisData.YEnd] - _axisData[(int)AxisData.YStart];
            float realYVal = _axisData[(int)AxisData.YStart] + (yAxisLength * percentY);
            Debug.WriteLine("realVals = " + realXVal + ", " + realYVal);

            return new PointF(realXVal, realYVal);
        }

        private void ValidatingAxisText(object sender, CancelEventArgs e)
        {
            Debug.WriteLine("sender type = " + sender.GetType().ToString());
            ToolStripTextBox txtBox = (ToolStripTextBox)sender;
            float val;
            if (!float.TryParse(txtBox.Text, out val))
            {
                e.Cancel = true;
                txtBox.BackColor = Color.Red;
            }
            else
            {
                txtBox.BackColor = SystemColors.Window;
                AxisData index = (AxisData) Enum.Parse(typeof(AxisData), txtBox.Tag.ToString());
                _axisData[(int)index] = val;
            }
            foreach (int i in _axisData)
                Debug.WriteLine("axis data: " + i);
        }
    }
}
