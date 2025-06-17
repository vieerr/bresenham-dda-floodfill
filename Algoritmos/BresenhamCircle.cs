using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algoritmos
{
    using System.Collections.Generic;
    using System.Drawing;

    public static class BresenhamCircle
    {
        public static List<Point> GetPoints(int centerX, int centerY, int radius)
        {
            List<Point> points = new List<Point>();

            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;

            while (x <= y)
            {
                // Add all 8 octants
                AddCirclePoints(points, centerX, centerY, x, y);

                if (d < 0)
                {
                    d = d + 4 * x + 6;
                }
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            return points;
        }

        private static void AddCirclePoints(List<Point> points, int centerX, int centerY, int x, int y)
        {
            points.Add(new Point(centerX + x, centerY + y));
            points.Add(new Point(centerX - x, centerY + y));
            points.Add(new Point(centerX + x, centerY - y));
            points.Add(new Point(centerX - x, centerY - y));
            points.Add(new Point(centerX + y, centerY + x));
            points.Add(new Point(centerX - y, centerY + x));
            points.Add(new Point(centerX + y, centerY - x));
            points.Add(new Point(centerX - y, centerY - x));
        }
    }
}
