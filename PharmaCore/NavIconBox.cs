using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace PharmaCore
{
    public enum NavIconType
    {
        Overview,
        Medicines,
        Sales,
        Customers,
        Suppliers,
        Reports,
        Settings
    }

    public class NavIconBox : Control
    {
        private NavIconType _iconType = NavIconType.Overview;

        public NavIconType IconType
        {
            get => _iconType;
            set { _iconType = value; Invalidate(); }
        }

        public Color IconColor { get; set; } = Color.White;

        public NavIconBox()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            Size = new Size(24, 24);
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            float cx = Width / 2f;
            float cy = Height / 2f;
            float s = Math.Min(Width, Height);

            using (var pen = new Pen(IconColor, Math.Max(1.8f, s * 0.08f))
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            })
            using (var brush = new SolidBrush(IconColor))
            {
                switch (_iconType)
                {
                    case NavIconType.Overview: //home
                        float hw = s * 0.34f;
                        float hh = s * 0.28f;
                        float top = cy - s * 0.34f;
                        float mid = cy - s * 0.06f;
                        float bot = cy + s * 0.30f;

                        g.DrawLine(pen, cx, top, cx - hw - s * 0.05f, mid);
                        g.DrawLine(pen, cx, top, cx + hw + s * 0.05f, mid);
                        g.DrawLine(pen, cx - hw, mid - s * 0.02f, cx - hw, bot);
                        g.DrawLine(pen, cx + hw, mid - s * 0.02f, cx + hw, bot);
                        g.DrawLine(pen, cx - hw, bot, cx + hw, bot);
                        break;

                    case NavIconType.Medicines: // كبسولة مائلة
                        var state = g.Save();
                        g.TranslateTransform(cx, cy);
                        g.RotateTransform(-45f);
                        float cw = s * 0.56f;
                        float ch = s * 0.26f;
                        g.DrawRectangle(pen, -cw / 2f, -ch / 2f, cw, ch);
                        g.DrawLine(pen, 0f, -ch / 2f, 0f, ch / 2f);
                        g.FillRectangle(brush, -cw / 2f, -ch / 2f, cw / 2f, ch);
                        g.Restore(state);
                        break;

                    case NavIconType.Sales: // بطاقه
                        float rw = s * 0.58f;
                        float rh = s * 0.52f;
                        float rx = cx - rw / 2f;
                        float ry = cy - rh / 2f;
                        g.DrawRectangle(pen, rx, ry, rw, rh);
                        g.DrawLine(pen, rx + s * 0.12f, ry + rh * 0.38f, rx + rw - s * 0.12f, ry + rh * 0.38f);
                        g.DrawLine(pen, rx + s * 0.12f, ry + rh * 0.65f, rx + rw * 0.65f, ry + rh * 0.65f);
                        break;

                    case NavIconType.Customers: // شخصين
                        float r1 = s * 0.12f;
                        g.DrawEllipse(pen, cx - s * 0.14f - r1, cy - s * 0.24f - r1, r1 * 2f, r1 * 2f);
                        g.DrawArc(pen, cx - s * 0.34f, cy - s * 0.02f, s * 0.40f, s * 0.34f, 180f, 180f);

                        float r2 = s * 0.095f;
                        g.DrawEllipse(pen, cx + s * 0.16f - r2, cy - s * 0.18f - r2, r2 * 2f, r2 * 2f);
                        g.DrawArc(pen, cx + s * 0.03f, cy + s * 0.03f, s * 0.30f, s * 0.26f, 200f, 140f);
                        break;

                    case NavIconType.Suppliers: // مبنى/موردين
                        float baseLine = cy + s * 0.30f;
                        g.DrawLine(pen, cx - s * 0.32f, baseLine, cx + s * 0.32f, baseLine);
                        g.DrawRectangle(pen, cx - s * 0.24f, cy - s * 0.26f, s * 0.22f, s * 0.56f);
                        g.DrawRectangle(pen, cx - s * 0.02f, cy - s * 0.04f, s * 0.24f, s * 0.34f);
                        break;

                    case NavIconType.Reports: // تقارير (بطاقات وأسطر)
                        g.DrawRectangle(pen, cx - s * 0.30f, cy - s * 0.28f, s * 0.22f, s * 0.22f);
                        g.DrawRectangle(pen, cx - s * 0.30f, cy + s * 0.04f, s * 0.22f, s * 0.24f);
                        g.DrawLine(pen, cx + s * 0.02f, cy - s * 0.22f, cx + s * 0.30f, cy - s * 0.22f);
                        g.DrawLine(pen, cx + s * 0.02f, cy - s * 0.08f, cx + s * 0.24f, cy - s * 0.08f);
                        g.DrawLine(pen, cx + s * 0.02f, cy + s * 0.10f, cx + s * 0.30f, cy + s * 0.10f);
                        g.DrawLine(pen, cx + s * 0.02f, cy + s * 0.24f, cx + s * 0.22f, cy + s * 0.24f);
                        break;

                    case NavIconType.Settings: // ترس
                        float outerR = s * 0.25f;
                        float innerR = s * 0.10f;
                        g.DrawEllipse(pen, cx - outerR, cy - outerR, outerR * 2f, outerR * 2f);
                        g.DrawEllipse(pen, cx - innerR, cy - innerR, innerR * 2f, innerR * 2f);
                        for (int i = 0; i < 6; i++)
                        {
                            double ang = i * Math.PI / 3.0;
                            float x1 = cx + (float)Math.Cos(ang) * (outerR - s * 0.02f);
                            float y1 = cy + (float)Math.Sin(ang) * (outerR - s * 0.02f);
                            float x2 = cx + (float)Math.Cos(ang) * (outerR + s * 0.10f);
                            float y2 = cy + (float)Math.Sin(ang) * (outerR + s * 0.10f);
                            g.DrawLine(pen, x1, y1, x2, y2);
                        }
                        break;
                }
            }
        }
    }
}