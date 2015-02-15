using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// пост в ленте
    /// </summary>
    public class clsFeed
    {
        #region данные класса
        DateTime dtBase = new DateTime(1970, 1, 1);

        public DateTime date { get; private set; }

        public string message { get; private set; }
        public string link { get; private set; }
        public string linkVK { get; private set; }
        public string linkFB { get; private set; }
        public string linkTW { get; private set; }
        public string linkGP { get; private set; }

        public string linkBtn1 { get; private set; }
        public string linkBtn2 { get; private set; }
        public string linkBtn3 { get; private set; }
        public string linkBtn4 { get; private set; }

        public string Btn1Text { get; private set; }
        public string Btn2Text { get; private set; }
        public string Btn3Text { get; private set; }
        public string Btn4Text { get; private set; }

        public string justMessage { get; private set; }

        public bool is_new { get; private set; }
        public Int64 time_millis { get; private set; }
        #endregion
       
        public clsFrom from { get; private set; }



        public void mesDivider(String msg)
        {
            if (msg.Contains("&mdash;")) { msg = msg.Replace("&mdash;", "—"); }

            if (msg.Contains("&#8372;")) { msg = msg.Replace("&#8372;", "₴"); }

            if (msg.Contains("&#8364;")) { msg = msg.Replace("&#8372;", "€"); }

            if (msg.Contains("&#8381;")) { msg = msg.Replace("&#8372;", "₽"); }

            string[] dd = msg.Split(new char[] { '<', '>' });

            this.justMessage = string.Empty;
            this.link = string.Empty;
            this.linkVK = string.Empty;
            this.linkFB = string.Empty;
            this.linkTW = string.Empty;
            this.linkGP = string.Empty;

            this.linkBtn1 = string.Empty;
            this.linkBtn2 = string.Empty;
            this.linkBtn3 = string.Empty;
            this.linkBtn4 = string.Empty;

            this.Btn1Text = string.Empty;
            this.Btn2Text = string.Empty;
            this.Btn3Text = string.Empty;
            this.Btn4Text = string.Empty;
            
            string at = "/a";
            string it = "/i";
            string st = "/span";

            bool btn = false;
            int btnNum = 0;

            foreach (string s in dd)
            {
                if (s.Trim().Equals(at) || s.Trim().Equals(it) || s.Trim().Equals(st) || String.IsNullOrEmpty(s.Trim())) continue;
                if (s.LastIndexOf("img")  > -1) continue;
                if (s.LastIndexOf("i class") > -1) continue;
                if (s.LastIndexOf("span class") > -1) continue;
                if (s.LastIndexOf("href") > -1)
                {
                    if (s.Split('=')[1].StartsWith("http"))
                    {
                        #region соцсети
                        if (String.IsNullOrEmpty(this.linkVK) && (s.Split('=')[1].StartsWith("https://vk.com/") || s.Split('=')[1].StartsWith("http://vk.com/"))) 
                        {
                            for (int i = 1; i < s.Split('=').Count(); i++)
                            { this.linkVK += "=" + @s.Split('=')[i]; }
                            this.linkVK = this.linkVK.Split(' ')[0];
                            this.linkVK = this.linkVK.Substring(1);
                        }
                        else if (String.IsNullOrEmpty(this.linkFB) && (s.Split('=')[1].StartsWith("https://www.facebook.com") || s.Split('=')[1].StartsWith("http://www.facebook.com"))) 
                        {
                            for (int i = 1; i < s.Split('=').Count(); i++)
                            { this.linkFB += "=" + @s.Split('=')[i]; }
                            this.linkFB = this.linkFB.Split(' ')[0];
                            this.linkFB = this.linkFB.Substring(1);

                        }
                        else if (String.IsNullOrEmpty(this.linkTW) && (s.Split('=')[1].StartsWith("https://twitter.com/") || s.Split('=')[1].StartsWith("http://twitter.com/"))) 
                        {
                            for (int i = 1; i < s.Split('=').Count(); i++)
                            { this.linkTW += "=" + @s.Split('=')[i]; }
                            this.linkTW = this.linkTW.Split(' ')[0];
                            this.linkTW = this.linkTW.Substring(1);
                        }
                        else if (String.IsNullOrEmpty(this.linkGP) && (s.Split('=')[1].StartsWith("https://plus.google.com") || s.Split('=')[1].StartsWith("http://plus.google.com")))
                        {
                            for (int i = 1; i < s.Split('=').Count(); i++)
                            { this.linkGP += "=" + @s.Split('=')[i]; }
                            this.linkGP = this.linkGP.Split(' ')[0];
                            this.linkGP = this.linkGP.Substring(1);
                        }
                        #endregion
                        
                        else if (String.IsNullOrEmpty(this.link))
                        {
                            #region ссылка для кнопки
                            if (s.Contains("class=\"btn ") || s.Contains("class=btn "))
                            {
                                btn = true;
                                btnNum++;

                                string btl = "";

                                for (int i = 1; i < s.Split('=').Count(); )
                                {
                                    btl += "=" + @s.Split('=')[i];
                                    i++;
                                }
                                btl = btl.Split(' ')[0];
                                if (btl.StartsWith("="))
                                {
                                    btl = btl.Substring(1);
                                }

                                if (btnNum == 1)
                                {
                                    linkBtn1 = btl.Trim();
                                }
                                else if (btnNum == 2)
                                {
                                    linkBtn2 = btl.Trim();
                                }
                                else if (btnNum == 3)
                                {
                                    linkBtn3 = btl.Trim();
                                }
                                else if (btnNum == 4)
                                {
                                    linkBtn4 = btl.Trim();
                                }

                            }
                            #endregion
                            else
                            {
                                for (int i = 1; i < s.Split('=').Count(); )
                                {
                                    this.link += "=" + @s.Split('=')[i];
                                    i++;
                                }
                                this.link = this.link.Split(' ')[0];
                                if (this.link.StartsWith("="))
                                {
                                    this.link = this.link.Substring(1);
                                }
                            }
                        }
                    }
                    else {
                        if (String.IsNullOrEmpty(this.link))
                        {
                            this.link = @"http://freelancehunt.com" + s.Split('=')[1];
                        }
                        else
                        {
                            #region ссылка для кнопки
                            if (s.Contains("class=\"btn ") || s.Contains("class=btn "))
                            {
                                btn = true;
                                btnNum++;

                                string btl = "";
                                string btli = "";

                                for (int i = 0; i < s.Split(' ').Count(); )
                                {
                                    if (@s.Split(' ')[i].StartsWith("href="))
                                    {
                                        btli = @s.Split(' ')[i];
                                    }
                                    i++;
                                }

                                for (int ii = 1; ii < btli.Split('=').Count(); )
                                {
                                    btl += "=" + btli.Split('=')[ii];
                                    ii++;
                                }
                                btl = btl.Split(' ')[0];
                                if (btl.StartsWith("="))
                                {
                                    btl = btl.Substring(1);
                                }


                                if (btl.StartsWith("/"))
                                {
                                    btl = @"http://freelancehunt.com" + btl;
                                }
                                else if (btl.StartsWith("http"))
                                { }


                                if (btnNum == 1)
                                {
                                    linkBtn1 = btl.Trim();
                                }
                                else if (btnNum == 2)
                                {
                                    linkBtn2 = btl.Trim();
                                }
                                else if (btnNum == 3)
                                {
                                    linkBtn3 = btl.Trim();
                                }
                                else if (btnNum == 4)
                                {
                                    linkBtn4 = btl.Trim();
                                }

                            }
                            #endregion
                        }

                    
                    }
                } 
                else {
                    if (!btn)
                    {
                        this.justMessage += s.Trim() + " ";
                    }
                    else
                    {
                        #region текст кнопки
                        btn = false;
                        if (btnNum == 1) 
                        {
                            Btn1Text = s.Trim();
                        } 
                        else if (btnNum == 2)
                        {
                            Btn2Text = s.Trim();
                        } 
                        else if (btnNum == 3)
                        {
                            Btn3Text = s.Trim();
                        }
                        else if (btnNum == 4)
                        {
                            Btn4Text = s.Trim();
                        }
                        #endregion
                    }


                }
            }
            if (this.justMessage.EndsWith(" и ")) { 
                this.justMessage = this.justMessage.Remove(this.justMessage.Length - 3);
            }
            
            while (this.justMessage.TrimEnd().EndsWith(","))
            {
                this.justMessage = this.justMessage.TrimEnd();
                this.justMessage = this.justMessage.Remove(this.justMessage.Length - 1);
                this.justMessage = this.justMessage.TrimEnd();
            }
        }

        public clsFeed(clsJSON json)
        {
            string[] strFrom = new string[]
            {
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
            };

            #region обработка данных для этого класса

            foreach (string[] line in json.data)
            {
                if (line[0].ToLower().CompareTo("time") == 0) this.date = clsTimeConvert.dtFrom8061(line[1]);
                if (line[0].ToLower().CompareTo("message") == 0)
                {
                    this.message = line[1];
                    mesDivider(this.message);
                    
                }

                if (line[0].ToLower().CompareTo("is_new") == 0) this.is_new = line[1].ToLower().CompareTo("true") == 0;
                if (line[0].ToLower().CompareTo("time_millis") == 0)
                {
                    if (!line[1].Contains("message"))
                    {
                        Int64 date = 0;
                        if (Int64.TryParse(line[1], out date)) { time_millis = date; }
                    } else {
                        Int64 date = 0;
                        if (Int64.TryParse(line[1].Split('m')[0], out date)) { time_millis = date; }

                        String ms = line[1].Split(':')[1];
                        if (String.IsNullOrEmpty(this.message)) { 
                            this.message = ms;
                            mesDivider(this.message);
                        }

                    }
                }

            } 

            #endregion

            #region от кого
            
            clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

            if (block != null)
            {
                foreach (string[] line in block.data)
                {
                    if (line[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = line[1];
                    if (line[0].ToLower().CompareTo("login") == 0) strFrom[1] = line[1];
                    if (line[0].ToLower().CompareTo("url") == 0) strFrom[2] = line[1];
                    if (line[0].ToLower().CompareTo("avatar") == 0) strFrom[3] = line[1];
                    if (line[0].ToLower().CompareTo("fname") == 0) strFrom[4] = line[1];
                    if (line[0].ToLower().CompareTo("sname") == 0) strFrom[5] = line[1];
                }
            }

            this.from = new clsFrom(strFrom);

            #endregion

            
        }
    }
}
