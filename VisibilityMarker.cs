using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab1Geometry
{
    static class VisibilityMarker
    { 
        public static void MarkVisibleSegments(List<Tuple<Point, int, Point>> sortedPoints, Graphics graphics)
        {
            LinkedList<Tuple<Point, int, Point>> closestSegments = new LinkedList<Tuple<Point, int, Point>>();
            closestSegments.AddLast(sortedPoints[0]);

            for (int i = 1; i < sortedPoints.Count; i++)
            {
                if (closestSegments.Count == 0)
                {
                    closestSegments.AddLast(sortedPoints[i]);
                    continue;
                }

                var currClosestSegment = closestSegments.Last.Value;

                Point beginP = Geometry.FindIntersection(sortedPoints[i - 1].Item1.X, currClosestSegment.Item1, currClosestSegment.Item3);
                Point endP = Geometry.FindIntersection(sortedPoints[i].Item1.X, currClosestSegment.Item1, currClosestSegment.Item3);

                graphics.DrawLine(new Pen(Color.LightGreen, 4), beginP, endP);

                CheckSegment(closestSegments, sortedPoints[i], endP);
            }
        }

        private static void CheckSegment(LinkedList<Tuple<Point, int, Point>> closestSegments, Tuple<Point, int, Point> segment, Point endP)
        {
            if (segment.Item2 == 0)
            {
                if (segment.Item1.Y < endP.Y)
                    closestSegments.AddLast(segment);
                else closestSegments.AddToLinkedList(segment);
            }
            else
            {
                var segmentToRemove = new Tuple<Point, int, Point>(segment.Item3, 0, segment.Item1);
                closestSegments.Remove(segmentToRemove);
            }
        }
    }
}
