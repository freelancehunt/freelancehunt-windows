using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    /// <summary>
    /// блок входящий в состав структуры
    /// </summary>
    public class clsJSON_block
    {
        /// <summary>
        /// название блока
        /// </summary>
        public string name { get; private set; }

        /// <summary>
        /// данные блока
        /// </summary>
        public List<string[]> data { get; private set; }

        public clsJSON_block(string name)
        {
            this.data = new List<string[]>();
            this.name = name;
        }

        public void addData(string[] data)
        {
            this.data.Add(data);
        }

    }

    /// <summary>
    /// еденичная структура
    /// </summary>
    public class clsJSON
    {
        /// <summary>
        /// данные структуры
        /// </summary>
        public List<string[]> data { get; private set; }

        /// <summary>
        /// блоки структуры
        /// </summary>
        public List<clsJSON_block> bloks { get; private set; }

        public clsJSON(List<string[]> data, List<clsJSON_block> bloks)
        {
            this.bloks = bloks;
            this.data = data;
        }

        public static List<clsJSON> parceProj(string text)
        {
            List<clsJSON> rezult = new List<clsJSON>();

            //string text2 = text.Replace("[", "[\r\n");
            //text2 = text2.Replace("{", "\r\n{\r\n");
            //text2 = text2.Replace("}", "\r\n}\r\n");

            string text2 = text.Replace("[", "[\n");
            text2 = text2.Replace("{", "\n{\n");
            text2 = text2.Replace("}", "\n}\n");


            List<string[]> data = new List<string[]>();
            List<clsJSON_block> bloks = null;
            clsJSON_block blok = null;

            bool inBlock = false;
            string blockName = string.Empty;
            int brckNum = 0;

            string[] lines = text2.Split(new char[] { '\r', '\n' });
            int i = -1;
            foreach (string line in lines)
            {
                i++;
                if (string.IsNullOrEmpty(line)) continue;
                if (line.CompareTo("[") == 0) continue;
                if (line.CompareTo("]") == 0) continue;

                if (line.CompareTo("{") == 0)
                {
                    brckNum++;
                    continue;
                }

                if (line.CompareTo("}") == 0)
                {
                    brckNum--;

                    if (brckNum == 0)
                    {
                        // закончили JSON
                        rezult.Add(new clsJSON(data, bloks));

                        data = new List<string[]>();
                        bloks = null;
                        blok = null;

                        inBlock = false;
                        blockName = string.Empty;
                    }
                    else
                    {
                        // закончили блок
                        if (blok != null)
                            bloks.Add(blok);

                        blok = null;
                        inBlock = false;
                        blockName = string.Empty;
                    }

                    continue;
                }

                string[] param = line.Split(':');

                if (param.Count() == 1) continue;

                param[0] = param[0].Replace("\"", "");

                #region название блока

                if (string.IsNullOrEmpty(param[1]))
                {
                    inBlock = true;

                    blok = new clsJSON_block(param[0]);

                    if (bloks == null)
                        bloks = new List<clsJSON_block>();

                    continue;
                }

                #endregion


                string tmpParam1 = line.Substring(line.IndexOf(":") + 1);
                //string tmpParam1 = line.Substring(line.IndexOf(":") + 1).Replace("\"", "").Replace(",", "");

                #region если текст разделен, то его надо соединить

                if (param[0] == "name" || param[0] == "description_text" || param[0] == "description_html")
                {

                    int n = 1;
                    bool r = true;
                    while (r)
                    {
                        while (lines[i + n].Trim().Length < 1) { n++; }


                        if (!lines[i + n].Contains("\":\""))
                        {
                            tmpParam1 = tmpParam1 + lines[i + n];
                            n++;
                        }
                        else { r = false; }
                    }
                }

                #endregion
                
                param[1] = remЕxEndsStarts(tmpParam1);//.Replace("\"", "").Replace(",", "");

                if (inBlock)
                    blok.addData(new string[] { param[0], param[1] });
                else
                    data.Add(new string[] { param[0], param[1] });
            }

            return rezult;
        }

        public static List<clsJSON> parce(string text)
        {
            List<clsJSON> rezult = new List<clsJSON>();

            string text2 = text.Replace("[", "[\r\n");
            text2 = text2.Replace("{", "\r\n{\r\n");
            text2 = text2.Replace("}", "\r\n}\r\n");

            List<string[]> data = new List<string[]>();
            List<clsJSON_block> bloks = null;
            clsJSON_block blok = null;

            bool inBlock = false;
            string blockName = string.Empty;
            int brckNum = 0;

            string[] lines = text2.Split(new char[] { '\r', '\n' });
            int i = -1;
            foreach (string line in lines)
            {
                i++;
                if (string.IsNullOrEmpty(line)) continue;
                if (line.CompareTo("[") == 0) continue;
                if (line.CompareTo("]") == 0) continue;

                if (line.CompareTo("{") == 0)
                {
                    brckNum++;
                    continue;
                }

                if (line.CompareTo("}") == 0)
                {
                    brckNum--;

                    if (brckNum == 0)
                    {
                        // закончили JSON
                        rezult.Add(new clsJSON(data, bloks));

                        data = new List<string[]>();
                        bloks = null;
                        blok = null;

                        inBlock = false;
                        blockName = string.Empty;
                    }
                    else
                    { 
                        // закончили блок
                        if (blok != null)
                            bloks.Add(blok);

                        blok = null;
                        inBlock = false;
                        blockName = string.Empty;
                    }

                    continue;
                }

                string[] param = line.Split(':');

                if (param.Count() == 1) continue;

                param[0] = param[0].Replace("\"", "");

                #region название блока
                
                if (string.IsNullOrEmpty(param[1]))
                {
                    inBlock = true;

                    blok = new clsJSON_block(param[0]);

                    if (bloks == null)
                        bloks = new List<clsJSON_block>();

                    continue;
                } 

                #endregion


                param[1] = line.Substring(line.IndexOf(":") + 1).Replace("\"", "").Replace(",", "");

                if (inBlock)
                    blok.addData(new string[] { param[0], param[1] });
                else
                    data.Add(new string[] { param[0], param[1] });
            }

            

            return rezult;
        }

        public static List<clsJSON> parceMessage(string text)
        {
            List<clsJSON> rezult = new List<clsJSON>();

            string text2 = text.Replace("[", "[\n");
            text2 = text2.Replace("{", "\n{\n");
            text2 = text2.Replace("}", "\n}\n");

            //string text2 = text;

            List<string[]> data = new List<string[]>();
            List<clsJSON_block> bloks = null;
            clsJSON_block blok = null;

            bool inBlock = false;
            string blockName = string.Empty;
            int brckNum = 0;

            string[] lines = text2.Split(new char[] { '\r', '\n' });
            
            int i = -1;

            
            foreach (string line in lines)
            {
                i++;
                
                if (string.IsNullOrEmpty(line)) continue;
                if (line.CompareTo("[") == 0) continue;
                if (line.CompareTo("]") == 0) continue;

                if (line.CompareTo("{") == 0)
                {
                    brckNum++;
                    continue;
                }

                if (line.CompareTo("}") == 0)
                {
                    brckNum--;

                    if (brckNum == 0)
                    {
                        // закончили JSON
                        rezult.Add(new clsJSON(data, bloks));

                        data = new List<string[]>();
                        bloks = null;
                        blok = null;

                        inBlock = false;
                        blockName = string.Empty;
                    }
                    else
                    {
                        // закончили блок
                        if (blok != null)
                            bloks.Add(blok);

                        blok = null;
                        inBlock = false;
                        blockName = string.Empty;
                    }

                    continue;
                }

                string[] param = line.Split(':');

                if (param.Count() == 1) continue;

                param[0] = param[0].Replace("\"", "");

                #region название блока

                if (string.IsNullOrEmpty(param[1]))
                {
                    inBlock = true;

                    blok = new clsJSON_block(param[0]);

                    if (bloks == null)
                        bloks = new List<clsJSON_block>();

                    continue;
                }

                #endregion
                

                string tmpParam1 = line.Substring(line.IndexOf(":") + 1);

                #region если сообщение разделено, то его надо соединить

                if (param[0] == "message_html" || param[0] == "message_text")
                {
                    int n = 1;
                    bool r = true;
                    while (r)
                    {
                        while (lines[i + n].Trim().Length < 1) { n++; }


                        if (!lines[i + n].Contains("\":\""))
                        {
                            tmpParam1 = tmpParam1 + lines[i + n];
                            n++;
                        }
                        else { r = false; }
                    }
                }
                
                #endregion

                param[1] = remЕxEndsStarts(tmpParam1);//tmpParam1.Replace( "rn","\n"); ;//line.Substring(line.IndexOf(":") + 1).Replace("\"", "").Replace(",", "");



                if (inBlock)
                    blok.addData(new string[] { param[0], param[1] });
                else
                    data.Add(new string[] { param[0], param[1] });
            }

            return rezult;
        }

        private static string remЕxEndsStarts(string tmpParam1) 
        {

            while (tmpParam1.TrimStart().StartsWith("\"") || tmpParam1.TrimStart().StartsWith(",") || tmpParam1.TrimEnd().EndsWith("\"") || tmpParam1.TrimEnd().EndsWith(",") || tmpParam1.TrimEnd().EndsWith("\"\n") || tmpParam1.TrimEnd().EndsWith(",\n"))
            {
                if (tmpParam1.TrimStart().StartsWith("\"") || tmpParam1.TrimStart().StartsWith(","))
                { tmpParam1 = tmpParam1.TrimStart().Substring(1); }
                if (tmpParam1.TrimEnd().EndsWith("\"") || tmpParam1.TrimEnd().EndsWith(","))
                { tmpParam1 = tmpParam1.Substring(0, tmpParam1.Length - 1); }
                if (tmpParam1.TrimEnd().EndsWith("\"\n") || tmpParam1.TrimEnd().EndsWith(",\n"))
                { tmpParam1 = tmpParam1.Substring(0, tmpParam1.Length - 3) + "\n"; }

            }

            return tmpParam1;
        }

    }
}
