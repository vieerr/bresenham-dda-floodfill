using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Algoritmos
{
    public static class DDA
    {
        public static List<Point> GetPoints(int x0, int y0, int x1, int y1)
        {
            List<Point> points = new List<Point>();

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int steps = Math.Max(dx, dy);

            if (steps == 0)
            {
                points.Add(new Point(x0, y0));
                return points;
            }

            float xIncrement = (float)(x1 - x0) / steps;
            float yIncrement = (float)(y1 - y0) / steps;

            float x = x0;
            float y = y0;

            for (int i = 0; i <= steps; i++)
            {
                points.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xIncrement;
                y += yIncrement;
            }

            return points;
        }
    }


}
