using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab1Geometry
{
    static class LinkedListExtensions
    {
        public static void AddToLinkedList(this LinkedList<Tuple<Point, int, Point>> closestSegments, 
            Tuple<Point, int, Point> newSegment,
            IntersectionFinder intersectionFinder)
        {
            var currSegment = closestSegments.Last;
            var curr = intersectionFinder.FindIntersection(newSegment.Item1.X, currSegment.Value.Item1, currSegment.Value.Item3);
            while (currSegment != null && curr.Y < newSegment.Item1.Y)
            {
                currSegment = currSegment.Previous;
                if (currSegment != null)
                    curr = intersectionFinder.FindIntersection(newSegment.Item1.X, currSegment.Value.Item1, currSegment.Value.Item3);
            }
            if (currSegment == null)
                closestSegments.AddFirst(newSegment);
            else
                closestSegments.AddAfter(currSegment, newSegment);
        }
    }
}
