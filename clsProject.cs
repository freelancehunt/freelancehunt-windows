using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    public class clsProject
    {
        #region данные класса
        public clsFrom from { get; private set; }
        
        public Int64 id { get; private set; }
        public string name { get; private set; }
        public string description { get; private set; }
        public string description_text { get; private set; }
        public string description_html { get; private set; }

        public int status_id { get; private set; }
        public string status_name { get; private set; }
        public int bid_count { get; private set; }

        public string start_time { get; private set; }
        public string publication_time { get; private set; }
        public string expire_time { get; private set; }

        public string budget_amount { get; private set; }
        public string budget_currency_code { get; private set; }
       
        public string url { get; private set; }
        public string url_api { get; private set; }

        /// <summary>
        /// постоянная работа
        /// </summary>
        public bool is_job { get; private set; }

        /// <summary>
        /// премиум проект
        /// </summary>
        public bool is_featured { get; private set; }

        /// <summary>
        /// личность заказчика проверена
        /// </summary>
        public bool is_identity_verified { get; private set; }


        /// <summary>
        /// через Сейф
        /// </summary>
        public bool is_safe_project { get; private set; }

        /// <summary>
        /// ставка на проект уже добавлена
        /// </summary>
        public bool is_bid_added { get; private set; }

        public Dictionary<int, string> skills { get; private set; }
        
        #endregion

        public clsProject(clsJSON json)
        {
            string[] strFrom = new string[] 
            { 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty, 
                string.Empty 
            };

            #region обработка данных для этого класса

            foreach (string[] param in json.data)
            {
                if (param[0].ToLower().CompareTo("project_id") == 0)
                {
                    Int64 _i = 0;

                    if (Int64.TryParse(param[1], out _i))
                        this.id = _i;
                }

                if (param[0].ToLower().CompareTo("name") == 0) this.name = param[1];
                if (param[0].ToLower().CompareTo("url") == 0) this.url = param[1];
                if (param[0].ToLower().CompareTo("url_api") == 0) this.url_api = param[1];
                if (param[0].ToLower().CompareTo("description") == 0) { 
                    //this.description = param[1].Replace("rn", "\r\n");
                    this.description = param[1].Replace("\r\n","\n");
                    string n = "null";
                    if (this.description.Trim().Equals(n)) { this.description = ""; }
                }

                if (param[0].ToLower().CompareTo("description_html") == 0) {
                    this.description_html = param[1].Replace("\r\n", "\n");
                    string n = "null";
                    if (this.description_html.Trim().Equals(n)) { this.description_html = ""; }
                }

                if (param[0].ToLower().CompareTo("description_text") == 0)
                {
                    //this.description_text = param[1].Replace("rn", "\r\n");
                    this.description_text = param[1].Replace("\r\n", "\n");
                    string n = "null";
                    if (this.description_text.Trim().Equals(n)) { this.description_text = ""; }
                }

                if (param[0].ToLower().CompareTo("budget_amount") == 0) this.budget_amount = param[1];
                if (param[0].ToLower().CompareTo("budget_currency_code") == 0) this.budget_currency_code = param[1];

                
                if (param[0].ToLower().CompareTo("status_id") == 0)
                {
                    int _i = 0;

                    if (int.TryParse(param[1], out _i))
                        this.status_id = _i;
                }

                if (param[0].ToLower().CompareTo("status_name") == 0) this.status_name = param[1];

                if (param[0].ToLower().CompareTo("bid_count") == 0)
                {
                    int _i = 0;

                    if (int.TryParse(param[1], out _i))
                        this.bid_count = _i;
                }

                if (param[0].ToLower().CompareTo("start_time") == 0) this.start_time = param[1];
               
                if (param[0].ToLower().CompareTo("publication_time") == 0) this.publication_time = param[1];

                if (param[0].ToLower().CompareTo("expire_time") == 0) this.expire_time = param[1];

                if (param[0].ToLower().CompareTo("is_job") == 0)
                    this.is_job = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_featured") == 0)
                    this.is_featured = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_identity_verified") == 0)
                    this.is_identity_verified = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_safe_project") == 0)
                    this.is_safe_project = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

                if (param[0].ToLower().CompareTo("is_bid_added") == 0)
                    this.is_bid_added = param[1].CompareTo("1") == 0 || param[1].ToLower().CompareTo("true") == 0;

            }

            #endregion

            #region skills

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("skills") == 0);

                if (block != null)
                {
                    this.skills = new Dictionary<int, string>();

                    foreach (string[] param in block.data)
                    {
                        int _i = 0;

                        if (!int.TryParse(param[0], out _i)) continue;

                        this.skills.Add(_i, param[1]);
                    }
                }
            }

            #endregion

            #region from

            if (json.bloks != null)
            {
                clsJSON_block block = json.bloks.FirstOrDefault(b => b.name.ToLower().CompareTo("from") == 0);

                if (block != null)
                {
                    foreach (string[] param in block.data)
                    {
                        if (param[0].ToLower().CompareTo("profile_id") == 0) strFrom[0] = param[1];
                        if (param[0].ToLower().CompareTo("login") == 0) strFrom[1] = param[1];
                        if (param[0].ToLower().CompareTo("url") == 0) strFrom[2] = param[1];
                        if (param[0].ToLower().CompareTo("avatar") == 0) strFrom[3] = param[1];
                        if (param[0].ToLower().CompareTo("fname") == 0) strFrom[4] = param[1];
                        if (param[0].ToLower().CompareTo("sname") == 0) strFrom[5] = param[1];
                    }
                }
            }
            
            #endregion

            this.from = new clsFrom(strFrom);
        }
    }
}
