using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing.Text;

namespace freelancehunt
{
    class clsColors
    {
        public static Color textColor = Color.FromArgb(255, 79, 115, 175);
        public static Color lnrColorTop = Color.FromArgb(255, 246, 246, 246);
        public static Color lnrColorBottom = Color.FromArgb(255, 255, 255, 255);

        public static Color textColor1 = Color.FromArgb(255, 255, 255, 255);
        public static Color textColor2 = Color.FromArgb(255, 34, 96, 34);

        public static Color lnrColorTop1 = Color.FromArgb(255, 79, 159, 79);
        public static Color lnrColorBottom1 = Color.FromArgb(255, 79, 159, 79);

        public static Pen borderPen = new Pen(Color.FromArgb(255, 229, 229, 229), 1);
        public static Pen borderPenB = new Pen(Color.FromArgb(255, 240, 240, 240), 4);
        public static Pen borderPenIncl = new Pen(Color.FromArgb(255, 229, 229, 229), 1);
        public static Pen borderPenFeatured = new Pen(Color.Silver, 1);
        public static Pen borderPenFeaturedB = new Pen(Color.Silver, 4);

        public static Color posiriveColor = Color.LightGreen;
        public static Color negativeColor = Color.LightPink;

        

        /// <summary>
        /// делает скругленные углы прямоугольнику rect с радиусом скругления cornerRad
        /// </summary>
        /// <param name="rect"></param> прямоугольник
        /// <param name="cornerRad"></param> радиус скругления
        /// <returns></returns>
        public static GraphicsPath GetBarShape(RectangleF rect, float cornerRad) 
        {
            float rad = cornerRad;
            float x = rect.X;
            float y = rect.Y;
            float width = rect.Width;
            float height = rect.Height;
            GraphicsPath path = new GraphicsPath();
            
            path.AddBezier(x, y + rad, x, y, x + rad, y, x + rad, y);
            path.AddLine(x + rad, y, (x + width) - rad, y);
            path.AddBezier((x + width) - rad, y, x + width, y, x + width, y + rad, x + width, y + rad);
            path.AddLine((x + width), (y + rad), (x + width), ((y + height) - rad));
            path.AddBezier((x + width), ((y + height) - rad), (x + width), (y + height), ((x + width) - rad), (y + height), ((x + width) - rad), (y + height));
            path.AddLine(((x + width) - rad), (y + height), (x + rad), (y + height));
            path.AddBezier(x + rad, y + height, x, y + height, x, (y + height) - rad, x, (y + height) - rad);
            path.AddLine(x, (y + height) - rad, x, y + rad);
            return path;
        }
    }
}
