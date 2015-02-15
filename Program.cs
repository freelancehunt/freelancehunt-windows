using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;



namespace freelancehunt
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hwnd, WinStyle style);
        [DllImport("user32.dll")]
        static extern void SwitchToThisWindow(IntPtr hwnd, bool fAltTab);


        // _In_  HWND hWnd,
        // _In_  BOOL fAltTab

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(string lpClassName, string lpWindowName);

        //[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        //static extern IntPtr 

        enum WinStyle
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            SW_SHOW = 5,
            ShowRESTORE = 9
        }

        static Mutex mutex = new Mutex(false, "freelancehunt");
        [STAThread]
        static void Main()
        {
            #region Обновление версии
            //try
            //{
                

            //    string fn = @"..\..\..\Properties\AssemblyInfo.cs";

            //    if (File.Exists(fn))
            //    {
            //        StreamReader rd = new StreamReader(fn, System.Text.Encoding.Unicode);
            //        string[] lines = rd.ReadToEnd().Split(new char[] { '\r', '\n' });
            //        rd.Close();
            //        rd.Dispose();

            //        StreamWriter wr = new StreamWriter(fn, false, System.Text.Encoding.Unicode);

            //        foreach (string l in lines)
            //        {
            //            if (string.IsNullOrEmpty(l)) continue;

            //            if (l.StartsWith(@"[assembly: AssemblyVersion("))
            //            {
            //                #region выбор и подсчет новой версии

            //                string[] param_1 = l.Split('"');
            //                string[] num_str = param_1[1].Split('.');

            //                int[] num = new int[4];

            //                int.TryParse(num_str[0], out num[0]);
            //                int.TryParse(num_str[1], out num[1]);
            //                int.TryParse(num_str[2], out num[2]);
            //                int.TryParse(num_str[3], out num[3]);

            //                num[3]++;

            //                if (num[3] > 99)
            //                {
            //                    num[3] = 0;
            //                    num[2]++;

            //                    if (num[2] > 99)
            //                    {
            //                        num[2] = 0;
            //                        num[1]++;

            //                        if (num[1] > 99)
            //                        {
            //                            num[1] = 0;
            //                            num[0]++;
            //                        }
            //                    }
            //                }

            //                #endregion

            //                wr.WriteLine("[assembly: AssemblyVersion(\"" + num[0].ToString() + "." + num[1].ToString() + "." + num[2].ToString() + "." + num[3].ToString() + "\")]");
            //                wr.WriteLine("[assembly: AssemblyFileVersion(\"" + num[0].ToString() + "." + num[1].ToString() + "." + num[2].ToString() + "." + num[3].ToString() + "\")]");
            //            }
            //            else
            //            {
            //                if (l.StartsWith("[assembly: AssemblyFileVersion(")) continue;
            //                wr.WriteLine(l);
            //            }

            //            wr.Flush();
            //        }

            //        wr.Flush();
            //        wr.Close();
            //        wr.Dispose();
            //    }

                
            //}
            //catch { }
            #endregion
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!mutex.WaitOne(500, false))
            {

                IntPtr wndHandle = FindWindowByCaption(null, "Freelancehunt Monitor");
                //MessageBox.Show("wndHandle\n" + wndHandle.ToString());
                
                if (wndHandle == IntPtr.Zero)
                {
                    #region если окно запущенной программы не найдено
                    DialogResult dr = MessageBox.Show("Программа уже запущена. \nЗапустить еще раз?", "Программа запущена", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);// + Process.GetProcessesByName(pr).Length);
                    switch (dr)
                    {
                        case DialogResult.Yes: { break; }
                        case DialogResult.No:
                            {
                                //Process.GetCurrentProcess().Kill();
                                return;
                                //break;
                            }
                    }
                    #endregion
                } 
                else 
                {
                    ShowWindow(wndHandle, WinStyle.SW_SHOW);
                    ShowWindow(wndHandle, WinStyle.ShowMaximized);
                    //SwitchToThisWindow(wndHandle, true);//true
                    //SwitchToThisWindow(wndHandle, false);//true
                    return;
                }
            }
            Application.Run(new Form1());
        }



        /*static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            

         
            //******************************************************************************************************************
            //bool onlyInstance;

            //Mutex mtx = new Mutex(true, Process.GetCurrentProcess().ProcessName, out onlyInstance); // используйте имя вашего приложения

            //// Если другие процессы не владеют мьютексом, то
            //// приложение запущено в единственном экземпляре
            //if (onlyInstance)
            //{
            //    Application.Run(new Form1());
            //}
            //else
            //{
            //    MessageBox.Show(
            //       "Приложение уже запущено",
            //       "Сообщение",
            //       MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //}
            //*********************************************************************************************************************
        }*/


    }
}
