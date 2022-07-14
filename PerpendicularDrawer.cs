using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1Geometry
{
    public class PerpendicularDrawer
    {
        public void DrawPerpendicular(Point p, Graphics graphics, Pen pen)
        {
            int segmentLength = 10;
            int y = p.Y;
            int x = p.X;
            while (y > segmentLength)
            {
                graphics.DrawLine(pen, new Point(x, y), new Point(x, y - segmentLength));
                y = y - 2 * segmentLength;
            }
        }
    }
}
