using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1Geometry
{
    static class PointsDrawingClass
    {
        public static void DrawPoints(MouseEventArgs e, bool drawSegments, List<Point> points, Graphics graphics)
        {
            if (drawSegments)
            {
                PerpendicularDrawingClass.DrawPerpendicular(e.Location, graphics, new Pen(Color.Black, 1));
                points.Add(e.Location);
                var count = points.Count;
                if (count % 2 == 0)
                    graphics.DrawLine(new Pen(Color.Blue, 3), points[count - 1], points[count - 2]);
            }
        }
    }
}
