using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1Geometry
{
    public class OXaxisDrawer
    {
        public void DrawOXaxis(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color.Black, 7), new Point(-1000, 0), new Point(3000, 0));
        }
    }
}
