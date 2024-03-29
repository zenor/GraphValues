﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GraphValues
{
    public partial class MainForm : Form
    {
        const int DELETE_TOLERENCE_VIS = 3;

        Point _rectangleClickPoint = new Point();
        bool _axisMode, _pointMode;
        bool _drawing = false;
        bool _xLog, _yLog;
        
        Rectangle _drawingRect;

        enum AxisData
        {
            XStart = 0, XEnd = 1, YStart = 2, YEnd = 3
        };
        List<double?> _axisData = new List<double?>(4);
        List<Point> _visPoints = new List<Point>();
        BindingList<DataPoint> _dataPoints = new BindingList<DataPoint>();

        enum Mode {Boundary, Point};
        enum ScaleType { Linear, Logarithmic };
        enum Axis { X, Y };

        string _currentSaveFile = "";

        public MainForm()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
                _axisData.Add(null);

            dgvDataPoints.DataSource = _dataPoints;
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

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV File (*.csv)|*.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                _currentSaveFile = save.FileName;
                Save(sender, e);
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void graphImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (_axisMode)
            {
                _rectangleClickPoint = e.Location;
                _drawingRect = new Rectangle(e.X, e.Y, 0, 0);
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

                int x = e.X < _rectangleClickPoint.X ? e.X : _rectangleClickPoint.X;
                int y = e.Y < _rectangleClickPoint.Y ? e.Y : _rectangleClickPoint.Y;
                _drawingRect = new Rectangle(x, y, Math.Max(_rectangleClickPoint.X, e.X) - Math.Min(_rectangleClickPoint.X, e.X), Math.Max(_rectangleClickPoint.Y, e.Y) - Math.Min(_rectangleClickPoint.Y, e.Y));

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
            e.Graphics.DrawRectangle(Pens.Red, _drawingRect);

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
                foreach (double? axisData in _axisData)
                {
                    if (!axisData.HasValue)
                    {
                        Debug.Print("null axisdata");
                        MessageBox.Show("You need to set start and end values for each axis.");
                        return;
                    }
                }

                Point point = new Point(e.X, e.Y);

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    AddPoint(point);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    RemovePoint(point);

                menuFileSaveAs.Enabled = _dataPoints.Count > 0 ? true : false;
                menuFileSave.Enabled = (_currentSaveFile != "" && _dataPoints.Count > 0) ? true : false;
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

        private void AddPoint(Point point)
        {
            // The code can handle points placed outside of the drawing rect
            // but we will disallow that to prevent polluting the data and screen
            if (point.X < _drawingRect.Left || point.X > _drawingRect.Right
                || point.Y < _drawingRect.Top || point.Y > _drawingRect.Bottom)
                return;

            _visPoints.Add(point);
            graphImage.Invalidate();

            _dataPoints.Add(GetScalePoint(point));
        }

        private void RemovePoint(Point point)
        {
            int indexToRemove = -1;
            for (int i = 0; i < _visPoints.Count; i++)
            {
                if (point.X > _visPoints[i].X - DELETE_TOLERENCE_VIS && point.X < _visPoints[i].X + DELETE_TOLERENCE_VIS
                    && point.Y > _visPoints[i].Y - DELETE_TOLERENCE_VIS && point.Y < _visPoints[i].Y + DELETE_TOLERENCE_VIS)
                {
                    indexToRemove = i;
                    break;
                }
            }

            // If we ever start sorting lists, this could become troublesome.
            if (indexToRemove >= 0)
            {
                _visPoints.RemoveAt(indexToRemove);
                _dataPoints.RemoveAt(indexToRemove);
                graphImage.Invalidate();
            }
        }

        private DataPoint GetScalePoint(Point visPoint)
        {
            double relX = visPoint.X - _drawingRect.Left;
            // rectangle is wrong way up compared to the graph
            // so we first find where we are whilst upside down
            // then flip, by subtracting that from the height.
            double relY = visPoint.Y - _drawingRect.Top;
            relY = _drawingRect.Height - relY;

            double percentX = (relX / (float)_drawingRect.Width);
            double percentY = (relY / (float)_drawingRect.Height);
            System.Diagnostics.Debug.WriteLine("percents = " + percentX + ", " + percentY);

            double realXVal;
            if (_xLog)
                realXVal = LogScale(percentX, Axis.X);
            else
                realXVal = LinearScale(percentX, Axis.X);

            double realYVal;
            if (_yLog)
                realYVal = LogScale(percentY, Axis.Y);
            else
                realYVal = LinearScale(percentY, Axis.Y);

            return new DataPoint(realXVal, realYVal);
        }

        private double LinearScale(double percent, Axis axis)
        {
            double start = axis == Axis.X ? _axisData[(int)AxisData.XStart].Value : _axisData[(int)AxisData.YStart].Value;
            double end = axis == Axis.X ? _axisData[(int)AxisData.XEnd].Value : _axisData[(int)AxisData.YEnd].Value;

            double axisLength = end - start;
            double realVal = start + (axisLength * percent);
            return realVal;
        }

        private double LogScale(double percent, Axis axis)
        {
            // scale reads eg 1 .. 10000 in real numbers
            // that would make internal LINEAR scale 0 .. 4 (1, 10, 100, 1000, 10000) in nice equal steps
            // user clicks 75% up the axis, 75% on our internal linear scale is 3
            // 3 is the logarithm of the number we clicked on == 1000
            // ie what number gives a logarithm of 3? we work out 10^3
            // so after getting the same old linear code below, do 10^realVal
            double logStart, logEnd;
            if (axis == Axis.X)
            {
                logStart = Math.Log10(_axisData[(int)AxisData.XStart].Value);
                logEnd = Math.Log10(_axisData[(int)AxisData.XEnd].Value);
            }
            else
            {
                logStart = Math.Log10(_axisData[(int)AxisData.YStart].Value);
                logEnd = Math.Log10(_axisData[(int)AxisData.YEnd].Value);
            }
            double axisLength = logEnd - logStart;
            double logVal = logStart + (axisLength * percent);
            double realVal = Math.Pow(10, logVal);

            return realVal;
        }

        private void Save(object sender, EventArgs e)
        {
            if (_currentSaveFile == "")
                return;

            StreamWriter writer = new StreamWriter(_currentSaveFile);
            foreach (DataPoint point in _dataPoints)
                writer.WriteLine(point.X.ToString() + "," + point.Y.ToString());

            writer.Close();
        }

        private void dgvDataPoints_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // Delete the equivalent entry in _visPoints.
            // This depends on the 2 lists being kept in the same order
            _visPoints.RemoveAt(e.Row.Index);
            graphImage.Invalidate();
        }

        private void chkXLog_CheckedChanged(object sender, EventArgs e)
        {
            _xLog = !_xLog;
        }

        private void chkYLog_CheckedChanged(object sender, EventArgs e)
        {
            _yLog = !_yLog;
        }

        private void ValidateAxisTextBox(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            double val;
            int index = (int)((AxisData)Enum.Parse(typeof(AxisData), txtBox.Tag.ToString()));
            if (!double.TryParse(txtBox.Text, out val))
            {
                txtBox.BackColor = Color.Red;
                _axisData[index] = null;
            }
            else
            {
                txtBox.BackColor = SystemColors.Window;
                _axisData[index] = val;
            }
        }
    }
}
