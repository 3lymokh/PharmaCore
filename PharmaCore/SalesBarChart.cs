using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PharmaCore
{
    
    public class SalesBarChart : Control
    {
        private string[] _labels = new string[0];
        private decimal[] _values = new decimal[0];
        private int _hover = -1;

        private const int PadLeft = 56, PadRight = 16, PadTop = 44, PadBottom = 34;

        public string Title { get; set; } = "Sales per day";

        public SalesBarChart()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 9f);
            MinimumSize = new Size(320, 220);
        }

        public void SetData(string[] labels, decimal[] values)
        {
            _labels = labels ?? new string[0];
            _values = values ?? new decimal[0];
            _hover = -1;
            Invalidate();
        }

        private Rectangle Plot
        {
            get { return new Rectangle(PadLeft, PadTop, Math.Max(10, Width - PadLeft - PadRight), Math.Max(10, Height - PadTop - PadBottom)); }
        }

        
        private static decimal NiceCeil(decimal max)
        {
            if (max <= 0) return 1;
            double mag = Math.Pow(10, Math.Floor(Math.Log10((double)max)));
            double n = (double)max / mag;
            double nice = n <= 1 ? 1 : n <= 2 ? 2 : n <= 5 ? 5 : 10;
            return (decimal)(nice * mag);
        }

        private static GraphicsPath TopRounded(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            float d = Math.Min(radius * 2f, r.Width);
            d = Math.Min(d, r.Height * 2f);
            if (d < 1f) { p.AddRectangle(r); return p; }
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddLine(r.Right, r.Y + d / 2f, r.Right, r.Bottom);
            p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(BackColor);

            Rectangle plot = Plot;
            int n = _values.Length;

            decimal max = 0;
            foreach (decimal v in _values) if (v > max) max = v;
            bool empty = max <= 0;
            decimal top = empty ? 100 : NiceCeil(max);

            using (var dark = new SolidBrush(Color.FromArgb(15, 23, 42)))
            using (var gray = new SolidBrush(Color.FromArgb(71, 85, 105)))
            using (var titleFont = new Font("Segoe UI", 11f, FontStyle.Bold))
            {
                g.DrawString(Title, titleFont, dark, 12f, 10f);

                const int lines = 4;
                var farFmt = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
                using (var grid = new Pen(Color.FromArgb(226, 232, 240)))
                {
                    for (int i = 0; i <= lines; i++)
                    {
                        float y = plot.Bottom - plot.Height * i / (float)lines;
                        g.DrawLine(grid, plot.Left, y, plot.Right, y);
                        decimal val = top * i / lines;
                        g.DrawString("$" + val.ToString("N0"), Font, gray, new RectangleF(0, y - 10, PadLeft - 8, 20), farFmt);
                    }
                }

                if (n > 0)
                {
                    float slot = plot.Width / (float)n;
                    float barW = Math.Min(48f, slot * 0.55f);
                    var centerFmt = new StringFormat { Alignment = StringAlignment.Center };

                    for (int i = 0; i < n; i++)
                    {
                        float cx = plot.Left + slot * i + slot / 2f;
                        string label = i < _labels.Length ? _labels[i] : "";
                        g.DrawString(label, Font, gray, cx, plot.Bottom + 8f, centerFmt);

                        if (_values[i] <= 0) continue;

                        float h = (float)(_values[i] / top) * plot.Height;
                        var rect = new RectangleF(cx - barW / 2f, plot.Bottom - h, barW, h);
                        Color c = i == _hover ? Color.FromArgb(29, 78, 216) : Color.FromArgb(37, 99, 235);
                        using (var path = TopRounded(rect, 6f))
                        using (var fill = new SolidBrush(c))
                            g.FillPath(fill, path);

                        if (i == _hover || n <= 8)
                            g.DrawString("$" + _values[i].ToString("N0"), Font, dark, cx, rect.Top - 18f, centerFmt);
                    }
                }

                if (empty)
                {
                    using (var dash = new Pen(Color.FromArgb(22, 163, 74), 2f) { DashStyle = DashStyle.Dash })
                        g.DrawLine(dash, plot.Left, plot.Bottom, plot.Right, plot.Bottom);

                    var mid = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    using (var f = new Font("Segoe UI", 11f, FontStyle.Bold))
                    {
                        g.DrawString("No sales recorded yet", f, dark, plot.Left + plot.Width / 2f, plot.Top + plot.Height / 2f - 10f, mid);
                        g.DrawString("Completed sales will appear here", Font, gray, plot.Left + plot.Width / 2f, plot.Top + plot.Height / 2f + 12f, mid);
                    }
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            int found = -1;
            Rectangle plot = Plot;
            if (_values.Length > 0 && plot.Contains(e.Location))
            {
                float slot = plot.Width / (float)_values.Length;
                int i = (int)((e.X - plot.Left) / slot);
                if (i >= 0 && i < _values.Length && _values[i] > 0) found = i;
            }
            if (found != _hover) { _hover = found; Cursor = found >= 0 ? Cursors.Hand : Cursors.Default; Invalidate(); }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (_hover != -1) { _hover = -1; Invalidate(); }
        }
    }
}