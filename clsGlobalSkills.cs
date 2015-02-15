using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    internal class clsGlobalSkills
    {
        [DefaultValue(null)]
        public static Dictionary<int, string> skills { get; private set; }

        private static string cmdExecWithWait(string command)
        {
            string str1 = string.Empty;
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardOutput = true,
                StandardOutputEncoding = Encoding.UTF8,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            process.Start();
            string str2 = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            return str2.Replace("\r\n", "|").Replace("\\", "").Replace("[", "[\r\n").Replace("]", "\r\n]").Replace("},", "},\r\n").Replace("}", "}\r\n").Replace("|", "\r\n");
        }

        public static void Refresh()
        {
            if (clsGlobalSkills.skills != null)
                return;
            clsGlobalSkills.skills = new Dictionary<int, string>();
            string message = "https://api.freelancehunt.com/skills";
            string str1 = clsGlobalSkills.cmdExecWithWait("curl -u " + clsUpdate.id + ":" + clsUpdate.CreateToken(message) + " -k --user-agent \"freelancehunt client (VERSION 1.0)\" " + message).Replace("{", string.Empty).Replace("}", string.Empty).Replace("} ,", string.Empty).Replace("},", string.Empty).Replace("[", string.Empty).Replace("]", string.Empty);
            char[] chArray = new char[2] { '\r', '\n' };
            foreach (string str2 in str1.Split(chArray))
            {
                if (!string.IsNullOrEmpty(str2) && str2.CompareTo(",") != 0)
                {
                    IEnumerable<string> source = Enumerable.Where<string>((IEnumerable<string>)str2.Split(new char[2] { '"', ':' }), 
                        (Func<string, bool>)(s => !string.IsNullOrEmpty(s)));
                    if (source != null)
                    {
                        string[] strArray = Enumerable.ToArray<string>(source);
                        if (Enumerable.Count<string>((IEnumerable<string>)strArray) == 5)
                        {
                            int result = 0;
                            if (int.TryParse(strArray[1], out result))
                                clsGlobalSkills.skills.Add(result, strArray[4].Replace("/", ",").Replace("&laquo;", "\"").Replace("&raquo;", "\""));
                        }
                    }
                }
            }
        }
    }
}
