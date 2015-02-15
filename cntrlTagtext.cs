using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace freelancehunt
{
    public partial class cntrlTagtext : UserControl
    {
        string text = string.Empty;
        StringFormat format = new StringFormat();
 
        SizeF MeasureString(string s, Font font)
        {
            SizeF result;
            using (var image = new Bitmap(1, 1))
            {
                using (var g = Graphics.FromImage(image))
                {
                    result = g.MeasureString(s, font);
                }
            }

            return result;
        }

        public cntrlTagtext(string Url)
        {
            this.text = Url;

            int i = Url.LastIndexOf('/', Url.Length - 1 , Url.Length - 42);
            string UrlName = Url.Substring(i + 1, Url.Length - i - 1);
            UrlName = parseCyrilic(UrlName);

            InitializeComponent();
            lblFileName.Text = UrlName;
            
        }

        string[] symb = new string[] { " ", "?", "№", "І", "і", "Ё", "ё", "Й", "Ц", "У", "К", "Е", "Н", "Г", "Ш", "Щ", "З", "Х", "Ъ", "Ф", "Ы", "В", "А", "П", "Р", "О", "Л", "Д", "Ж", "Э", "Я", "Ч", "С", "М", "И", "Т", "Ь", "Б", "Ю", "й", "ц", "у", "к", "е", "н", "г", "ш", "щ", "з", "х", "ъ", "ф", "ы", "в", "а", "п", "р", "о", "л", "д", "ж", "э", "я", "ч", "с", "м", "и", "т", "ь", "б", "ю", "!", "\"", "(", ")", "*", "?", ":", "%", ";", "=", "+", "@", "#", "$", "^", "&", "`"};
        string[] code = new string[] { "+", "%E2%82%B4", "%E2%84%96", "%D0%86", "%D1%96", "%D0%81", "%D1%91", "%D0%99", "%D0%A6", "%D0%A3", "%D0%9A", "%D0%95", "%D0%9D", "%D0%93", "%D0%A8", "%D0%A9", "%D0%97", "%D0%A5", "%D0%AA", "%D0%A4", "%D0%AB", "%D0%92", "%D0%90", "%D0%9F", "%D0%A0", "%D0%9E", "%D0%9B", "%D0%94", "%D0%96", "%D0%AD", "%D0%AF", "%D0%A7", "%D0%A1", "%D0%9C", "%D0%98", "%D0%A2", "%D0%AC", "%D0%91", "%D0%AE", "%D0%B9", "%D1%86", "%D1%83", "%D0%BA", "%D0%B5", "%D0%BD", "%D0%B3", "%D1%88", "%D1%89", "%D0%B7", "%D1%85", "%D1%8A", "%D1%84", "%D1%8B", "%D0%B2", "%D0%B0", "%D0%BF", "%D1%80", "%D0%BE", "%D0%BB", "%D0%B4", "%D0%B6", "%D1%8D", "%D1%8F", "%D1%87", "%D1%81", "%D0%BC", "%D0%B8", "%D1%82", "%D1%8C", "%D0%B1", "%D1%8E", "%21", "%22", "%28", "%29", "%2A", "%3F", "%3A", "%25", "%3B", "%3D", "%2B", "%40", "%23", "%24", "%5E", "%26", "%60" };

        private string parseCyrilic(string str) {
            string retStr = str;

            if (retStr.Contains("+") || retStr.Contains("%"))
            {
                int i = 0;
                while (i < code.Length)
                {
                    retStr = retStr.Replace(code[i], symb[i]);
                    i++;
                }
            }

            return retStr;
        }
        
        private void lblFileName_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.text))
            {
                try { System.Diagnostics.Process.Start(this.text); }
                catch (Exception) { }
            }
        }

        private void cntrlTagtext_Paint(object sender, PaintEventArgs e)
        {
            //Size size = this.Size;

            //size.Height -= 4;
            //size.Width -= 4;

            //LinearGradientBrush linGrBrush = new LinearGradientBrush(
            //                                 new Point(0, 0),
            //                                 new Point(0, size.Height),
            //                                 Color.White,
            //                                 Color.White);

            //Rectangle rect = new Rectangle(new Point(1, 2), size);

            //e.Graphics.FillRectangle(linGrBrush, rect);

           // #region окантовка

            //rect.Height--;
            //rect.Width--;
            //GraphicsPath gp = clsColors.GetBarShape(rect, size.Height / 4);
            //e.Graphics.DrawPath(clsColors.borderPenIncl, gp);

           //s #endregion
        }

    }
}
