using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Lab1Geometry
{
    static class ListExtensions
    {
        private static void ChangeSegmentsEnds(this List<Point> points)
        {
            for (int i = 0; i < points.Count; i += 2)
            {
                if (points[i].X > points[i + 1].X)
                {
                    Point p = points[i];
                    points[i] = points[i + 1];
                    points[i + 1] = p;
                }
            }
        }

        public static List<Tuple<Point, int, Point>> SortPoints(this List<Point> points)
        {
            Func<int, Point> findSegmentBeginOrEnd = (int index) => {
                if (index % 2 == 1) return points[index - 1];
                return points[index + 1];
            };

            points.ChangeSegmentsEnds();
            return points.Select((p, index) => new Tuple<Point, int, Point>(p, index % 2, findSegmentBeginOrEnd(index)))
                         .OrderBy(t => t.Item1.X)
                         .ToList();
        }
    }
}
