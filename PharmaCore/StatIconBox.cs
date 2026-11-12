using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PharmaCore
{
    public enum StatIconType
    {
        Sales,
        Expired,
        LowStock,
        ExpiringSoon
    }

    public class StatIconBox : Control
    {
        private StatIconType _iconType = StatIconType.Sales;

        public StatIconType IconType
        {
            get => _iconType;
            set { _iconType = value; Invalidate(); }
        }

        public float CornerRadius { get; set; } = 12f;

        public StatIconBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(48, 48);
            BackColor = Color.White;
        }

        private static GraphicsPath RoundedRect(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            float d = Math.Min(radius * 2f, Math.Min(r.Width, r.Height));
            if (d < 1f) { p.AddRectangle(r); return p; }
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(BackColor);
            var boxRect = new RectangleF(1f, 1f, Width - 2f, Height - 2f);
            Color bg, fg;

            switch (_iconType)
            {
                case StatIconType.Expired:
                    bg = Color.FromArgb(254, 226, 226); // أحمر فاتح
                    fg = Color.FromArgb(220, 38, 38);  // أحمر
                    break;
                case StatIconType.LowStock:
                    bg = Color.FromArgb(254, 243, 199); // أصفر/برتقالي فاتح
                    fg = Color.FromArgb(217, 119, 6);  // كهرماني/بني دافئ
                    break;
                case StatIconType.ExpiringSoon:
                    bg = Color.FromArgb(204, 251, 241); // سماوي/فيروزي فاتح
                    fg = Color.FromArgb(13, 148, 136); // فيروزي
                    break;
                default: // Sales
                    bg = Color.FromArgb(219, 234, 254); // أزرق فاتح
                    fg = Color.FromArgb(37, 99, 235);  // أزرق
                    break;
            }

            using (var path = RoundedRect(boxRect, CornerRadius))
            using (var bgBrush = new SolidBrush(bg))
            {
                g.FillPath(bgBrush, path);
            }

            float cx = Width / 2f;
            float cy = Height / 2f;
            float s = Math.Min(Width, Height);

            using (var pen = new Pen(fg, Math.Max(2f, s * 0.055f))
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            })
            using (var brush = new SolidBrush(fg))
            {
                switch (_iconType)
                {
                    case StatIconType.Sales:
                        float w1 = s * 0.11f;
                        float gap = s * 0.05f;
                        float totalW = w1 * 3f + gap * 2f;
                        float startX = cx - totalW / 2f;
                        float baseY = cy + s * 0.22f;

                        float h1 = s * 0.18f;
                        float h2 = s * 0.36f;
                        float h3 = s * 0.26f;

                        g.FillRectangle(brush, startX, baseY - h1, w1, h1);
                        g.FillRectangle(brush, startX + w1 + gap, baseY - h2, w1, h2);
                        g.FillRectangle(brush, startX + (w1 + gap) * 2f, baseY - h3, w1, h3);
                        break;

                    case StatIconType.Expired:
                        float topY = cy - s * 0.24f;
                        float lineLen = s * 0.28f;
                        g.DrawLine(pen, cx, topY, cx, topY + lineLen);
                        float dotR = Math.Max(2.2f, s * 0.042f);
                        g.FillEllipse(brush, cx - dotR, cy + s * 0.14f, dotR * 2f, dotR * 2f);
                        break;

                    case StatIconType.LowStock:
                        float bw = s * 0.44f;
                        float bh = s * 0.34f;
                        float bx = cx - bw / 2f;
                        float by = cy - bh / 2f + s * 0.03f;
                        g.DrawRectangle(pen, bx, by, bw, bh);
                        g.DrawLine(pen, bx - s * 0.03f, by, bx + bw + s * 0.03f, by);
                        g.DrawLine(pen, cx - s * 0.08f, by + bh * 0.45f, cx + s * 0.08f, by + bh * 0.45f);
                        break;

                    case StatIconType.ExpiringSoon:
                        float r = s * 0.23f;
                        g.DrawEllipse(pen, cx - r, cy - r + s * 0.03f, r * 2f, r * 2f);
                        g.DrawLine(pen, cx - r * 0.45f, cy - r * 1.18f + s * 0.03f, cx + r * 0.45f, cy - r * 1.18f + s * 0.03f);
                        g.DrawLine(pen, cx, cy + s * 0.03f, cx, cy - r * 0.55f + s * 0.03f);
                        g.DrawLine(pen, cx, cy + s * 0.03f, cx + r * 0.5f, cy + s * 0.1f + s * 0.03f);
                        break;
                }
            }
        }
    }
}