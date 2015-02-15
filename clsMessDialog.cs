using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// переписка
    /// </summary>
    public class clsMessDialog
    {
        #region данные класса
        public string url { get; private set; }
      //  public string url_api { get; private set; }

        public List<string> url_Attachments { get; private set; }

        public bool have_attach { get; private set; }
        public DateTime last_post_time { get; private set; }
        public DateTime post_time { get; private set; }
      //  public int unread_count { get; private set; }

        public string message_html { get; private set; }
        public string message_text { get; private set; }

        public clsFrom from { get; private set; }
        public clsFrom to { get; private set; }

        #endregion

        public clsMessDialog(clsJSON json)
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
            string[] strTo = new string[]
            {
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
                string.Empty,
            };

            have_attach = false;
            url_Attachments = new List<string>();

            #region обработка данных класса

            foreach (string[] line in json.data)
            {
                if (line[0].ToLower().CompareTo("message_html") == 0)   this.message_html = line[1];
                if (line[0].ToLower().CompareTo("message_text") == 0)   this.message_text = line[1];
                
                if (line[0].ToLower().CompareTo("post_time") == 0)
                    this.post_time = DateTime.Parse(line[1]);//clsTimeConvert.dtFrom8061(line[1]);

                if (line[0].ToLower().CompareTo("attachments") == 0) have_attach = true;

                if (line[0].ToLower().CompareTo("url") == 0)
                    if (have_attach)
                    {
                        string turl = line[1];
                        string s = "//content.freelancehunt.com/message/";
                        if (turl.Remove(s.Length) == s)
                        {
                            turl = "https:" + turl;
                            url_Attachments.Add(turl);
                        }
                    }
                    else {
                        this.url = line[1];
                    }
            } 
            #endregion
            
            #region приложения
            /*
            if (json.block.attachments != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("attachments") == 0);

                if (block != null)
                {
                    this.url_Attachments = new List<string>();
                    foreach (string[] param in block.data)
                    {
                        if (param[0].ToLower().CompareTo("url") == 0) { this.url_Attachments.Add("https:" + param[1]); }
                    }
                }
            }
            */
            #endregion

            #region от кого

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

                if (block != null)
                {
                    foreach (string[] line in block.data)
                    {
                        if (line[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = line[1];
                        if (line[0].ToLower().CompareTo("login") == 0)      strFrom[1] = line[1];
                        if (line[0].ToLower().CompareTo("url") == 0)        strFrom[2] = line[1];
                        if (line[0].ToLower().CompareTo("avatar") == 0)     strFrom[3] = line[1];
                        if (line[0].ToLower().CompareTo("fname") == 0) strFrom[4] = line[1];
                        if (line[0].ToLower().CompareTo("sname") == 0) strFrom[5] = line[1];
                    }
                }
            }

            this.from = new clsFrom(strFrom); 

            #endregion

            #region кому

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("to") == 0);

                if (block != null)
                {
                    foreach (string[] line in block.data)
                    {
                        if (line[0].ToLower().CompareTo("profile_id") == 0) strTo[0] = line[1];
                        if (line[0].ToLower().CompareTo("login") == 0) strTo[1] = line[1];
                        if (line[0].ToLower().CompareTo("url") == 0) strTo[2] = line[1];
                        if (line[0].ToLower().CompareTo("avatar") == 0) strTo[3] = line[1];
                        if (line[0].ToLower().CompareTo("fname") == 0) strFrom[4] = line[1];
                        if (line[0].ToLower().CompareTo("sname") == 0) strFrom[5] = line[1];
                    }
                }
            }

            this.to = new clsFrom(strTo);

            #endregion
            

        }
    }
}
