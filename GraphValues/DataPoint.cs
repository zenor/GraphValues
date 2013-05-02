using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphValues
{
    class DataPoint
    {
        public double X { private set; get; }
        public double Y { private set; get; }

        public DataPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        override public string ToString()
        {
            return "{X=" + X + ",Y=" + Y + "}";
        }
    }
}
