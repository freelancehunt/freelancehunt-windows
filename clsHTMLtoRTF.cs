using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    class clsHTMLtoRTF
    {
        public static string ConvertHtmlToText(string source)
        {
            if (String.IsNullOrEmpty(source)) { return String.Empty; }

            string result;

            // Remove HTML Development formatting
            // Replace line breaks with space
            // because browsers inserts space
            result = source.Replace("\r", " ");
            // Replace line breaks with space
            // because browsers inserts space
            result = result.Replace("\n", " ");
            // Remove step-formatting
            result = result.Replace("\t", string.Empty);
            // Remove repeating speces becuase browsers ignore them
            result = System.Text.RegularExpressions.Regex.Replace(result, @"( )+", " ");

            #region Remove the header (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*head([^>])*>", "<head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*head( )*>)", "</head>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<head>).*(</head>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion

            #region remove all scripts (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*script([^>])*>", "<script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*script( )*>)", "</script>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            //result = System.Text.RegularExpressions.Regex.Replace(result, 
            //         @"(<script>)([^(<script>\.</script>)])*(</script>)",
            //         string.Empty, 
            //         System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<script>).*(</script>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion

            #region remove all styles (prepare first by clearing attributes)
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*style([^>])*>", "<style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"(<( )*(/)( )*style( )*>)", "</style>",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     "(<style>).*(</style>)", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion
            
            #region цитата
            result = result.Replace("<blockquote>", "|blockquote|");
            result = result.Replace("</blockquote>", "|/blockquote|\n");
            #endregion

            // insert tabs in spaces of <td> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*td([^>])*>", "\t",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            #region insert line breaks in places of <BR> and <LI> tags
            result = result.Replace("<br />","\n");
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*br( )*>", "\n",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*li( )*>", "\n",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion

            #region insert line paragraphs (double line breaks) in place if <P>, <DIV> and <TR> tags
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*div([^>])*>", "\n\n",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*tr([^>])*>", "\n\n",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<( )*p([^>])*>", "\n\n",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion

            #region links
            if (result.Contains("href") || result.Contains("img src") )
            {
                result = links(result);
            }


            #endregion
            // Remove remaining tags like <a>, links, images,
            // comments etc - anything thats enclosed inside < >
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<[^>]*>", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            #region replace special characters:
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&nbsp;", " ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);

            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&bull;", " * ",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&lsaquo;", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&rsaquo;", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&trade;", "(tm)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&frasl;", "/",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"<", "<",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @">", ">",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&copy;", "(c)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&reg;", "(r)",
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            #endregion

            // Remove all others. More can be added, see
            // http://hotwired.lycos.com/webmonkey/reference/special_characters/
            result = System.Text.RegularExpressions.Regex.Replace(result,
                     @"&(.{2,6});", string.Empty,
                     System.Text.RegularExpressions.RegexOptions.IgnoreCase);


            // make line breaking consistent
            result = result.Replace("\r", "\n");

            #region Remove extra line breaks and tabs:
            // replace over 2 breaks with 2 and over 4 tabs with 4. 
            // Prepare first to remove any whitespaces inbetween
            // the escaped characters and remove redundant tabs inbetween linebreaks
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\r)( )+(\r)", "\r\r", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\t)( )+(\t)", "\t\t", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\t)( )+(\r)", "\t\r", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\r)( )+(\t)", "\r\t", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\n)( )+(\n)", "\n\n", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove redundant tabs
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\r)(\t)+(\r)", "\r\r", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Remove multible tabs followind a linebreak with just one tab
            result = System.Text.RegularExpressions.Regex.Replace(result, "(\r)(\t)+", "\r\t", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            // Initial replacement target string for linebreaks
            string breaks = "\r\r\r";
            // Initial replacement target string for tabs
            string tabs = "\t\t\t\t\t";
            string nss = "\n\n";

            

            for (int index = 0; index < result.Length; index++)
            {
                result = result.Replace(breaks, "\r\r");
                result = result.Replace(tabs, "\t\t\t\t");
                result = result.Replace(nss, "\n");
                breaks = breaks + "\r";
                tabs = tabs + "\t";
                nss = nss + "\n";
            }
            result = result.TrimStart();
            while (result.StartsWith("\n"))
            {
                result = result.Substring(1, result.Length - 1);
                result = result.TrimStart();
            }
            result = result.TrimEnd();
            while (result.EndsWith("\n"))
            {
                result = result.Remove(result.Length - 1);
                result = result.TrimEnd();
            }
            result = result.Replace("\n", "\n   ");
            #endregion


            return "   " + result;
        }

        public static string links(string inp) 
        {
            string res = "";

            string[] dd = inp.Split('<');

            string message = string.Empty;
            string link = string.Empty;
            
            bool f = false;
            if (inp.StartsWith("<")) { f = true; }
            else { f = false; }

            if (f) {
                for (int i = 0; i < dd.Count(); i++) { dd[i] = "<" + dd[i]; } 
            } else if (!f) {
                for (int i = 1; i < dd.Count(); i++) { dd[i] = "<" + dd[i]; }
            }
            

            for (int i =0; i < dd.Count(); i++)
            {
                string s = dd[i];

                if (s.StartsWith("<a href") || s.StartsWith("<img src")) //continue;
                //else //if (s.Contains("href"))
                {
                    int l = s.IndexOf("=");

                    link = @s.Remove(0, l + 1 );
                    link = link.Split(new char[] {' ','>'})[0];
                    link = link.Replace("\"", "");


                    message = s.Split('>')[1];


                    if (s.StartsWith("<a href") )
                    {
                        if (link.StartsWith(message.Substring(0, message.Length - 5)))
                        {
                            message = link;
                        }
                        else
                        {
                            message = message + " - " + link;
                        }
                    }
                    else if (s.StartsWith("<img src")) { 
                        message = link;
                        if (message.StartsWith("//")) {
                            message = "https:" + message;
                        }
                    }

                    string newDDi = s.Substring(0, s.IndexOf(">") + 1) + " " + message + " ";

                    if (newDDi.Contains("+") || newDDi.Contains("%"))
                    {
                        newDDi = parseCyrilic(newDDi);
                    }

                    dd[i] = newDDi;

                }
                #region
                //else if (s.StartsWith("<img src"))
                //{
                //    int l = s.IndexOf("=");

                //    link = @s.Remove(0, l + 1);
                //    link = link.Split(new char[] { ' ', '>' })[0];
                //    link = link.Replace("\"", "");

                //   

                //    string newDDi = s.Substring(0, s.IndexOf(">") + 1) + " " + message + " ";

                //    dd[i] = newDDi;

                //    //***!!!***!!!***!!!***!!!***!!!***!!!***!!!***!!!***!!!***!!!<<<
                //}
                #endregion
                else continue;

            }

            for (int i = 0; i < dd.Count(); i++)
            {
                res = res + dd[i];
            }
                        
            return res;
        }

        static string[] symb = new string[] { " ", "?", "№", "І", "і", "Ё", "ё", "Й", "Ц", "У", "К", "Е", "Н", "Г", "Ш", "Щ", "З", "Х", "Ъ", "Ф", "Ы", "В", "А", "П", "Р", "О", "Л", "Д", "Ж", "Э", "Я", "Ч", "С", "М", "И", "Т", "Ь", "Б", "Ю", "й", "ц", "у", "к", "е", "н", "г", "ш", "щ", "з", "х", "ъ", "ф", "ы", "в", "а", "п", "р", "о", "л", "д", "ж", "э", "я", "ч", "с", "м", "и", "т", "ь", "б", "ю", "!", "\"", "(", ")", "*", "?", ":", "%", ";", "=", "+", "@", "#", "$", "^", "&", "`" };
        static string[] code = new string[] { "+", "%E2%82%B4", "%E2%84%96", "%D0%86", "%D1%96", "%D0%81", "%D1%91", "%D0%99", "%D0%A6", "%D0%A3", "%D0%9A", "%D0%95", "%D0%9D", "%D0%93", "%D0%A8", "%D0%A9", "%D0%97", "%D0%A5", "%D0%AA", "%D0%A4", "%D0%AB", "%D0%92", "%D0%90", "%D0%9F", "%D0%A0", "%D0%9E", "%D0%9B", "%D0%94", "%D0%96", "%D0%AD", "%D0%AF", "%D0%A7", "%D0%A1", "%D0%9C", "%D0%98", "%D0%A2", "%D0%AC", "%D0%91", "%D0%AE", "%D0%B9", "%D1%86", "%D1%83", "%D0%BA", "%D0%B5", "%D0%BD", "%D0%B3", "%D1%88", "%D1%89", "%D0%B7", "%D1%85", "%D1%8A", "%D1%84", "%D1%8B", "%D0%B2", "%D0%B0", "%D0%BF", "%D1%80", "%D0%BE", "%D0%BB", "%D0%B4", "%D0%B6", "%D1%8D", "%D1%8F", "%D1%87", "%D1%81", "%D0%BC", "%D0%B8", "%D1%82", "%D1%8C", "%D0%B1", "%D1%8E", "%21", "%22", "%28", "%29", "%2A", "%3F", "%3A", "%25", "%3B", "%3D", "%2B", "%40", "%23", "%24", "%5E", "%26", "%60" };

        private static string parseCyrilic(string str)
        {
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



    }
}
