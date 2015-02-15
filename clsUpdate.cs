using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Drawing;


namespace freelancehunt
{
    [Flags]
    public enum getInfoType
    { 
        /// <summary>
        /// переписка
        /// </summary>
        messagesFrom,

        projectsF,
        /// <summary>
        /// сообщения
        /// </summary>
        messages,// = 0,
        
        /// <summary>
        /// профайлы
        /// </summary>
        profiles,
        //profileList,

        /// <summary>
        /// лента
        /// </summary>
        feed,

        /// <summary>
        /// проекты
        /// </summary>
        projects,
        /// <summary>
        /// переписка
        /// </summary>
        messagesFrom1,
    }

    class clsUpdate
    {
        #region событие обновления
        
        public delegate void evRefreshHandle(getInfoType type, string text);
        public static event evRefreshHandle evRefresh;

        public delegate void evRefreshStartHandle(getInfoType type);
        public static event evRefreshStartHandle evRefreshStart;

        public delegate void evRefreshEndHandle(getInfoType type);
        public static event evRefreshEndHandle evRefreshEnd;

        #endregion

        /// <summary>
        /// искомый логин профиля
        /// </summary>
        public static string proFile = "me";

        public static bool Pause = true;

        #region данные для обновлений
        /// <summary>
        /// thread переписки
        /// </summary>
        public static string thrdUri = string.Empty;
        public static string thrdUriToSend = string.Empty;
        public static string fromLogin = string.Empty;

        public static string messPage = "1";
        public static int mess_per_page = 15;

        /// <summary>
        /// страница проектов
        /// </summary>
        public static string ProjPage = "1";

        public static bool ProjFirst = false;

        /// <summary>
        /// идентификатор
        /// </summary>
        public static string id = string.Empty;

        /// <summary>
        /// пароль
        /// </summary>
        public static string pass = string.Empty;

        /// <summary>
        /// для остановки основного потока
        /// </summary>
        public static bool isStop = false;

        static object lockFiles = new object();

        /// <summary>
        /// выполнить запрос
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        #endregion

        static string cmdExecWithWait(string command)
        {
            //string bat = Application.StartupPath + @"\req.bat";
            //string reqRez = Application.StartupPath + @"\msgs.txt";

            string output = string.Empty;

            lock (lockFiles)
            {
                /*File.Delete(bat);
                File.Delete(reqRez);

                using (StreamWriter wr = new StreamWriter(bat, false, Encoding.GetEncoding(1251)))
                {
                    wr.WriteLine("chcp 1251>nul");
                    wr.WriteLine(command + " >> msgs.txt");
                    //wr.WriteLine(command);
                    wr.Flush();
                    wr.Close();
                }*/

                Process p = new Process();
                
                //p.StartInfo = new ProcessStartInfo(bat)
                p.StartInfo = new ProcessStartInfo("cmd", "/c " + command)
                {
                    RedirectStandardOutput = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\commands.txt", true, Encoding.GetEncoding(1251)))
                {
                    wr.WriteLine(command);
                    wr.Flush();
                    wr.Close();
                }*/

                p.Start();

                output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();

                /*output = string.Empty;

                if (File.Exists(reqRez))
                {
                    using (StreamReader rd = new StreamReader(reqRez, Encoding.UTF8))
                    {
                        output = rd.ReadToEnd();
                        rd.Close();
                    }
                }*/
            }

            #region преобразование

            /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\output.txt", true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(output);
                wr.WriteLine("\r\n\r\n");
                wr.Flush();
                wr.Close();
            }*/

            output = output.Replace("\r\n", "|");

            output = output.Replace("\\", "");

            output = output.Replace("[", "[\r\n");
            output = output.Replace("]", "\r\n]");

            output = output.Replace("\",", "\",\r\n");
            output = output.Replace("},", "},\r\n");

            output = output.Replace("{", "\r\n{\r\n");
            output = output.Replace("}", "\r\n}\r\n");

            output = output.Replace("false,", "false,\r\n");
            output = output.Replace("true,", "true,\r\n");
            output = output.Replace("null,", "null,\r\n");
            output = output.Replace(" ,", " ,\r\n");

            output = output.Replace("0,", "0,\r\n");
            output = output.Replace("1,", "1,\r\n");
            output = output.Replace("2,", "2,\r\n");
            output = output.Replace("2,", "3,\r\n");
            output = output.Replace("4,", "4,\r\n");
            output = output.Replace("5,", "5,\r\n");
            output = output.Replace("6,", "6,\r\n");
            output = output.Replace("7,", "7,\r\n");
            output = output.Replace("8,", "8,\r\n");
            output = output.Replace("9,", "9,\r\n");

            output = output.Replace("|", "\r\n");

            #endregion

            /*using (StreamWriter wr = new StreamWriter(Application.StartupPath + @"\output.txt", true, Encoding.GetEncoding(1251)))
            {
                wr.WriteLine(output);
                wr.WriteLine("");
                wr.WriteLine("");
                wr.Flush();
                wr.Close();
            }*/

            return output;
        }

        public static string CreateToken(string message)
        {
            //secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(pass);
            byte[] messageBytes = encoding.GetBytes(message + "GET");
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        public static string cmdReq(getInfoType type)
        {
            string url = string.Empty;
            switch (type)
            {
                case getInfoType.messagesFrom:
                case getInfoType.messagesFrom1:
                    if (!string.IsNullOrEmpty(thrdUri))
                    {
                        url = @"" + thrdUri;
                        thrdUri = string.Empty;
                    }
                    break;

                case getInfoType.profiles:
                    if (!string.IsNullOrEmpty(proFile))
                    {
                        url = @"https://api.freelancehunt.com/profiles/" + proFile;
                        proFile = string.Empty;
                    }
                    break;

                case getInfoType.feed:
                    url = @"https://api.freelancehunt.com/my/feed";
                    break;

                case getInfoType.messages:

                    if (Convert.ToInt32(messPage) < 2) { url = @"https://api.freelancehunt.com/threads"; }
                    else { url = @"https://api.freelancehunt.com/threads?page=" + messPage; }
                    
                    break;

                case getInfoType.projectsF:
                    if (ProjFirst) 
                    {
                        if (Convert.ToInt32(ProjPage) < 2) { url = @"https://api.freelancehunt.com/projects/"; }
                        else { url = @"https://api.freelancehunt.com/projects?page=" + ProjPage; }
                    }
                    break; 
                case getInfoType.projects:
                    if (!ProjFirst)
                    {
                        if (Convert.ToInt32(ProjPage) < 1) {
                            ProjPage = "1";
                        }
                        url = @"https://api.freelancehunt.com/projects?page=" + ProjPage;
                        
                    } else {
                        ProjFirst = false;
                    }
                    break;
            }

            if (string.IsNullOrEmpty(url)) { return string.Empty; }

            string ret = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;

            if(type == getInfoType.profiles)
                return ret;

            return ret;
        }

        public static string getData(getInfoType type)
        {
            string exe = cmdReq(type);

            if (evRefreshStart != null)
                evRefreshStart(type);

            string rez = cmdExecWithWait(exe);

            if (evRefreshEnd != null)
                evRefreshEnd(type);

            return rez;
        }

        public static string getProjectFullInfo(Int64 projectID)
        {
            string url = @"https://api.freelancehunt.com/projects/" + projectID;
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;
            return cmdExecWithWait(exe);
        }

        public static string getProgectes(string skills, int pageNum)
        {
            string url = @"https://api.freelancehunt.com/projects?page=" + pageNum + "&" + skills + "&per_page=20";
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + "\"" + url + "\"";
            return cmdExecWithWait(exe);
        }

        public static string CreateTokenPOST(string url, string msg)
        {
            //secret = secret ?? "";
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(pass);
            byte[] messageBytes = encoding.GetBytes(url + "POST" + msg);// 
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return Convert.ToBase64String(hashmessage);
            }
        }

        public static string sendMess(string msg) 
        {
            msg = encode(msg);
            
            string msgs = "{\\\"message\\\":\\\"" + msg + "\\\"}";
            string msgt = "{\"message\":\"" + msg + "\"}";

            string header = "\"Content-Type:application/json;\"";//', 'Content-Length: " + msgt.Length + "'\"";

            string url = thrdUriToSend;

            string exe = @"curl -u " + id + ":" + CreateTokenPOST(url, msgt) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " +
                " -H  " + header + " -d " + "\"" + msgs + "\" --trace-ascii debugMsg.txt " + url + " ";

            string ret = cmdExecWithWait(exe);

            return ret;
        }

        public static string addBid(int dtd, int am, string currcode, bool safeproj, string cmnt, string url)
        {
            int days_to_deliver = dtd;   //время выполнения работы, целое положительное число не более 180
            int amount = am;             //желаемая оплата за проект, целое положительное число
            string currency_code = currcode;    //валюта, также доступны значения 'USD', 'RUB', 'UAH'
            int is_safe_project = safeproj ? 1 : 0;  //1 если фрилансер желает резервировать оплату в Сейфе, иначе 0.
            string comment = encode(cmnt);   //текст ставки


            string msgs = "{\\\"days_to_deliver\\\":" + days_to_deliver + ",\\\"amount\\\":" + amount + ",\\\"currency_code\\\":\\\"" + currency_code + "\\\",\\\"is_safe_project\\\":" + is_safe_project + ",\\\"comment\\\":\\\"" + comment + "\\\"}";
            string msgt =   "{\"days_to_deliver\":"   + days_to_deliver +   ",\"amount\":"   + amount +   ",\"currency_code\":\""     + currency_code +     "\",\"is_safe_project\":"   + is_safe_project +   ",\"comment\":\""     + comment +   "\"}";

            

            string header = "\"Content-Type:application/json;\"";
            
            string exe = @"curl -u " + id + ":" + CreateTokenPOST(url, msgt) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " +
                " -H  " + header + " -d " + "\"" + msgs + "\" --trace-ascii debugAddBid.txt " + url + " ";

            #region пример
            //{"days_to_deliver":11,
            //"amount":300,
            //"currency_code":"UAH",
            //"is_safe_project":1,
            //"comment":"\u041f\u0440\u0435\u0434\u043b\u0430\u0433\u0430\u044e \u0441\u0432\u043e\u0438 \u0443\u0441\u043b\u0443\u0433\u0438"}
            #endregion

            string ret = cmdExecWithWait(exe);

            return ret;
        }

        private static string encode(string str)
        {
            string ret = "";
            foreach (char x in str)
                ret += (charConv(x));

            return ret;
        }

        private static string charConv(char x)
        {
            string ret = "";
            if (x == ' ') { return " "; }
            ret = String.Format("{0:X}", Convert.ToInt32(x));
            if (ret.Length < 4)
            {
                ret = ret.PadLeft(4, '0');
            }
            ret = "\\u" + ret;

            return ret;
        }

        public static clsJSON getProfileFullInfo(string login)
        {
            string url = @"https://api.freelancehunt.com/profiles/" + login;
            string exe = @"curl -u " + id + ":" + CreateToken(url) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + url;
            string req = cmdExecWithWait(exe);

            List<clsJSON> jsones = clsJSON.parce(req);

            if (jsones == null) return null;
            if (jsones.Count != 1) return null;
            //if (jsones[0].bloks == null) return null;
            //if (jsones[0].bloks.Count == 0) return null;

            return jsones[0];
        }

        /// <summary>
        /// автообновление записей
        /// </summary>
        public static void autoRefresh()
        {
            int num = 0;
            int max = Enum.GetNames(typeof(getInfoType)).Length;

            while (!isStop)
            {
                while (!clsPing.isConnect)
                    Thread.Sleep(100);

                string data = getData((getInfoType)num);

                if (evRefresh != null)
                    if (!string.IsNullOrEmpty(data))
                        evRefresh((getInfoType)num, data);

                num++;
                if (num == max)
                {
                    num = 0;

                    Pause = true;

                    DateTime dtEnd;
                    if (clsConfig.UpdateFreq < 1) { dtEnd = DateTime.Now.AddMinutes(1); }
                    else { dtEnd = DateTime.Now.AddMinutes(clsConfig.UpdateFreq); }

                    while (Pause && dtEnd >= DateTime.Now)
                    {
                        if (isStop) return;
                        Thread.Sleep(100);
                    }
                }

                Thread.Sleep(250);
            }
        }
    }
}