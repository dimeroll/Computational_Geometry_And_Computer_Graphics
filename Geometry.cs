using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1Geometry
{
    public class Geometry
    {
        private OXaxisDrawer oxAxisDrawer = new OXaxisDrawer();
        private PointsDrawer pointsDrawer = new PointsDrawer();

        public void DrawOXaxis(Graphics graphics) => oxAxisDrawer.DrawOXaxis(graphics);
        public void DrawPoints(MouseEventArgs e, bool drawSegments, List<Point> points, Graphics graphics) => 
            pointsDrawer.DrawPoints(e, drawSegments, points, graphics);
    }
}
