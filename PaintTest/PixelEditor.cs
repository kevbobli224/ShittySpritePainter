using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public class PixelEditor : Panel
    {
        public Color DrawColor { get; set; }
        public Color GridColor { get; set; }
        public Bitmap drawingBitmap { get; set; }
        public PictureBox targetDisplay { get; set; }
        Point lastPoint = Point.Empty;
        public Graphics g;
        public SolidBrush brush = new SolidBrush(Color.Green);
        public List<Tuple<Rectangle, Color>> rectangles = new List<Tuple<Rectangle, Color>>();
        private Color placeHolder = Color.White;

        int pixelSize = 16;

        public int PixelSize
        {   get
            {
                return pixelSize;
            }
            set
            {
                pixelSize = value;
                Invalidate();
            }
        }
        //This stands for instanciation, I assume
        public PixelEditor()
        {
            DoubleBuffered = true;
            BackColor = Color.Beige;
            GridColor = Color.DimGray;
            DrawColor = Color.Red;
            drawingBitmap = new Bitmap(pixelSize, pixelSize);
            MouseClick += PixelEditor_MouseClick;
            MouseMove += PixelEditor_MouseMove;
            Paint += PixelEditor_Paint;
        }

        private void PixelEditor_Paint(object sender, PaintEventArgs e)
        {
            if (DesignMode)
                return;
            g = e.Graphics;
            
            int cols = pixelSize;
            int rows = pixelSize;
            float multiplierX = ClientSize.Width / pixelSize;
            float multiplierY = ClientSize.Height / pixelSize;
            
            if (rectangles.Count == 0)
            {
                for (int x = 0; x < cols; x++)
                {
                    for (int y = 0; y < rows; y++)
                    {
                        int x1 = Convert.ToInt32(x * multiplierX);
                        int y1 = Convert.ToInt32(y * multiplierY);

                        using (Pen p = new Pen(GridColor))
                        {
                            Rectangle rect = new Rectangle(x1, y1, Convert.ToInt32(multiplierX), Convert.ToInt32(multiplierY));
                            g.FillRectangle(new SolidBrush(Color.White), rect);
                            g.DrawRectangle(p, rect);
                            rectangles.Add(Tuple.Create(rect, Color.White));
                        }
                    }
                }
            }
            if (lastPoint.X >= 0 && lastPoint.Y >= 0 && lastPoint.X < ClientSize.Width && lastPoint.Y < ClientSize.Height)
            {
                if (rectangles.Count != 0 && lastPoint != Point.Empty)
                {
                    Tuple<Rectangle, Color> placeHolderTup = Tuple.Create(new Rectangle(), new Color());
                    foreach (var tup in rectangles)
                    {
                        int rectX = tup.Item1.X;
                        int rectY = tup.Item1.Y;
                        if (tup.Item1.Contains(lastPoint))
                        {
                            Rectangle updateRect = new Rectangle(rectX, rectY, Convert.ToInt32(multiplierX), Convert.ToInt32(multiplierY));
                            //int index = rectangles.IndexOf(tup);
                            //temp brush color
                            brush.Color = DrawColor;
                            g.FillRectangle(brush, updateRect);
                            placeHolderTup = Tuple.Create(updateRect, brush.Color);
                        }
                        else
                        {
                            using (Pen p = new Pen(GridColor))
                            {
                                g.FillRectangle(new SolidBrush(tup.Item2), tup.Item1);
                                g.DrawRectangle(p, tup.Item1);
                            }
                        }
                    }
                    if (placeHolderTup != null)
                    {
                        var i = (rectangles.Find(u => u.Item1 == placeHolderTup.Item1));
                        int j = rectangles.IndexOf(i);
                        rectangles[j] = placeHolderTup;

                    }
                    for (int index = 0; index < rectangles.Count; index++)
                    {
                        int x = Convert.ToInt16(rectangles[index].Item1.X / multiplierX);
                        int y = Convert.ToInt16(rectangles[index].Item1.Y / multiplierY);
                        Color c = rectangles[index].Item2;
                        drawingBitmap.SetPixel(x, y, c);
                    }
                }
                //if(targetDisplay.Image == null)
                //{
                //    targetDisplay.Image = drawingBitmap;
                //    Size sz = drawingBitmap.Size;
                //    targetDisplay.Image = new Bitmap((int)(sz.Width * 8), (int)(sz.Height * 8));
                //    targetDisplay.Size = new Size(drawingBitmap.Size.Width * 4, drawingBitmap.Size.Height * 4);
                //}
                //using (Graphics pgraphics = Graphics.FromImage(targetDisplay.Image))
                //{
                //    Size sz = drawingBitmap.Size;

                //    pgraphics.InterpolationMode = Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                //    targetDisplay.Size = new Size(drawingBitmap.Size.Width*4, drawingBitmap.Size.Height*4);
                //    pgraphics.DrawImage(drawingBitmap, new Rectangle(Point.Empty, targetDisplay.Size));     
                //}
                targetDisplay.Image = drawingBitmap;
            }
            
        }

        private void PixelEditor_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Color originalColor = DrawColor;
            bool act = false;
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(x, y);
                act = true;
            }   
            if (e.X < 0 && e.Y < 0) return;
            if (e.Button == MouseButtons.Right) return;
            if (act)
            {
                act = false;
                Invalidate();
            }
        }

        private void PixelEditor_MouseClick(object sender, MouseEventArgs e)
        {
            
            int x = e.X;
            int y = e.Y;
            bool act = false;
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(x, y);
                act = true;
            }
            if (e.Button == MouseButtons.Right)
            {
                
                DrawColor = placeHolder;
                lastPoint = new Point(x, y);
                act = true;
            }
            if(act)
            {
                act = false;
                Invalidate();
            }
        }
    }
}

