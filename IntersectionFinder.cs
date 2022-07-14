using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Lab1Geometry
{
    public class IntersectionFinder
    {
        public Point FindIntersection(int x0, Point p1, Point p2)
        {
            double y = (p2.Y - p1.Y) * (x0 - p1.X) / (p2.X - p1.X) + p1.Y;
            return new Point(x0, (int)y);
        }
    }
}
