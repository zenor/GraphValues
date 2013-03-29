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
        public float X { private set; get; }
        public float Y { private set; get; }

        public DataPoint(float x, float y)
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
