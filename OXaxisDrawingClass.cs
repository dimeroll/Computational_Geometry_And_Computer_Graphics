using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1Geometry
{
    static class OXaxisDrawingClass
    {
        public static void DrawOXaxis(Graphics graphics)
        {
            graphics.DrawLine(new Pen(Color.Black, 7), new Point(-1000, 0), new Point(3000, 0));
        }

        public static void Status() { }
    }
}
