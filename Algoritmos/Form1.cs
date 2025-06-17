using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        private List<Point> pointsToDraw = new List<Point>();
        private Bitmap drawingBitmap;
        private int currentPointIndex = 0;
        private Timer animationTimer;
        private Color fillColor = Color.Red;
        public Form1()
        {
            InitializeComponent();
             this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PicCanvas_MouseClick);

            InitializeBitmap();
            InitializeTimer();
        }

        private void InitializeBitmap()
        {
            drawingBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            using (Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.Clear(picCanvas.BackColor);
            }
        }

        private void InitializeTimer()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 1; // Faster for flood fill
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (currentPointIndex < pointsToDraw.Count)
            {
                Point point = pointsToDraw[currentPointIndex];
                drawingBitmap.SetPixel(point.X, point.Y, fillColor);
                picCanvas.Invalidate();
                currentPointIndex++;
            }
            else
            {
                animationTimer.Stop();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0);
        }

        private void StartDrawing()
        {
            // Reset animation
            currentPointIndex = 0;
            animationTimer.Start();
        }

        private void BtnLineDDA_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(TxtX0.Text);
            int y0 = int.Parse(TxtY0.Text);
            int x1 = int.Parse(TxtX1.Text);
            int y1 = int.Parse(TxtY1.Text);

            pointsToDraw = DDA.GetPoints(x0, y0, x1, y1);
            StartDrawing();
        }

        private void BtnLineBre_Click(object sender, EventArgs e)
        {
            int x0 = int.Parse(TxtX0.Text);
            int y0 = int.Parse(TxtY0.Text);
            int x1 = int.Parse(TxtX1.Text);
            int y1 = int.Parse(TxtY1.Text);

            pointsToDraw = BresenhamLine.GetPoints(x0, y0, x1, y1);
            StartDrawing();
        }

        private void BtnCircleBres_Click(object sender, EventArgs e)
        {
            int xc = picCanvas.Width / 2;
            int yc = picCanvas.Height / 2;
            int radius = int.Parse(TxtRadius.Text);

            pointsToDraw = BresenhamCircle.GetPoints(xc, yc, radius);
            StartDrawing();
        }

        private void PicCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point startPoint = e.Location;
                Color targetColor = drawingBitmap.GetPixel(startPoint.X, startPoint.Y);

                if (targetColor.ToArgb() != fillColor.ToArgb())
                {
                    pointsToDraw.Clear();

                    Queue<Point> queue = new Queue<Point>();
                    queue.Enqueue(startPoint);

                    bool[,] visited = new bool[drawingBitmap.Width, drawingBitmap.Height];

                    while (queue.Count > 0)
                    {
                        Point p = queue.Dequeue();

                        if (p.X < 0 || p.X >= drawingBitmap.Width || p.Y < 0 || p.Y >= drawingBitmap.Height)
                            continue;

                        if (visited[p.X, p.Y])
                            continue;

                        Color currentColor = drawingBitmap.GetPixel(p.X, p.Y);
                        if (currentColor.ToArgb() != targetColor.ToArgb())
                            continue;

                        visited[p.X, p.Y] = true;
                        pointsToDraw.Add(p);

                        queue.Enqueue(new Point(p.X, p.Y - 1)); // North
                        queue.Enqueue(new Point(p.X - 1, p.Y));   // West
                        queue.Enqueue(new Point(p.X, p.Y + 1));   // South
                        queue.Enqueue(new Point(p.X + 1, p.Y));   // East
                    }

                    StartDrawing();
                }
            }
        }

    }
}