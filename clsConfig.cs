using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace freelancehunt
{
    class clsConfig
    {
        public static bool AutoRun;     //Запускать вместе с Windows?
        public static bool AutoLogin;   //Оставлять логин при выходе?
        public static bool StartHidden; //Запускать свернутым?
        public static bool NotifyInterestProjOnly; //Уведомлять только о проектах из выбранных категорий
        public static bool ShowUpdateWindow;     //Показывать всплывающее окно?
        public static bool AutoHideUpdateWindow; //убирать или оставлять всплывающее окно?

        public static bool ShowInterestProjOnly; //Показывать только проекты из выбранных категорий

        //public static bool SoundNotification; //Звуковое уведомление

        public static int HideUpdateWindowTime;  //Время отображения frmUpdateInfo
        public static int UpdateFreq; // частота обновления

       


        public static void loadConfig()
        {
            string exMes = null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(Directory.GetCurrentDirectory() + "\\Config.conf");

                string AtRn = sr.ReadLine().Trim();  //Запускать вместе с Windows?
                if (AtRn == "True") { clsConfig.AutoRun = true; } //Да
                else { clsConfig.AutoRun = false; } //нет

                string AtLgn = sr.ReadLine().Trim();  //Оставлять логин при выходе?
                if (AtLgn == "True") { clsConfig.AutoLogin = true; } //Да
                else { clsConfig.AutoLogin = false; } //нет

                string StrtHdn = sr.ReadLine().Trim();  //Запускать свернутым?
                if (StrtHdn == "True") { clsConfig.StartHidden = true; } //Да
                else { clsConfig.StartHidden = false; } //нет

                string NtfIntrstPrj = sr.ReadLine().Trim();  //Уведомлять только о проектах из выбранных категорий
                if (NtfIntrstPrj == "True") { clsConfig.NotifyInterestProjOnly = true; } //Да
                else { clsConfig.NotifyInterestProjOnly = false; } //Уведомлять о всех проектах

                string ShwUpdWindow = sr.ReadLine().Trim();  //показывать всплывающее окно?
                if (ShwUpdWindow == "True") { clsConfig.ShowUpdateWindow = true; } //Да
                else { clsConfig.ShowUpdateWindow = false; } //нет

                string AutoHideUpdWindow = sr.ReadLine().Trim();  //убирать или оставлять всплывающее окно?
                if (AutoHideUpdWindow == "True") { clsConfig.AutoHideUpdateWindow = true; } //Да
                else { clsConfig.AutoHideUpdateWindow = false; } //нет

                string ShwIntrstPrj = sr.ReadLine().Trim();  //Показывать только проекты из выбранных категорий
                if (ShwIntrstPrj == "True") { clsConfig.ShowInterestProjOnly = true; } //Да
                else { clsConfig.ShowInterestProjOnly = false; } //Показывать все проекты

                //string SndNtf = sr.ReadLine().Trim();  //Звуковое уведомление
                //if (SndNtf == "True") { clsConfig.SoundNotification = true; } //Да
                //else { clsConfig.SoundNotification = false; } //нет
                                
                clsConfig.HideUpdateWindowTime = Convert.ToInt16(sr.ReadLine().Trim()); //Время отображения frmUpdateInfo
                
                clsConfig.UpdateFreq = Convert.ToInt16(sr.ReadLine().Trim());           // частота обновления
                
                sr.Close();
                
            }
            catch (Exception ex) { exMes = ex.Message; }
            if (exMes != null)
            {
                if (sr != null) { sr.Close(); }
                CreateDefaultConfig();
            }
        }

        public static void saveConfig() {
            StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + "\\Config.conf");

            //Запускать вместе с Windows?
            if (AutoRun) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Оставлять логин при выходе?
            if (AutoLogin) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Запускать свернутым?
            if (StartHidden) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Уведомлять только о проектах из выбранных категорий
            if (NotifyInterestProjOnly) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Показывать всплывающее окно?
            if (ShowUpdateWindow) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //убирать или оставлять всплывающее окно?
            if (AutoHideUpdateWindow) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Показывать только проекты из выбранных категорий
            if (ShowInterestProjOnly) { sr.WriteLine("True"); } //Да
            else { sr.WriteLine("False"); } //нет

            //Звуковое уведомление
            //if (SoundNotification) { sr.WriteLine("True"); } //Да
            //else { sr.WriteLine("False"); } //нет

            sr.WriteLine(clsConfig.HideUpdateWindowTime.ToString());   //Время скрытия frmUpdateInfo (сек)
            sr.WriteLine(clsConfig.UpdateFreq.ToString());    // частота обновления (мин)



            sr.Close();
        }



        private static void CreateDefaultConfig() //создание нового файла конфигурации с параметрами по умолчанию
        {
            StreamWriter sr = new StreamWriter(Directory.GetCurrentDirectory() + "\\Config.conf");

            sr.WriteLine("False"); //Запускать вместе с Windows?
            sr.WriteLine("True");  //Оставлять логин при выходе?
            sr.WriteLine("True");  //Запускать свернутым?
            sr.WriteLine("True"); //Уведомлять только о проектах из выбранных категорий
            sr.WriteLine("True");  //Показывать всплывающее окно?
            sr.WriteLine("True");  //Убирать всплывающее окно?
            sr.WriteLine("True"); //Показывать только проекты из выбранных категорий
            //sr.WriteLine("False"); //Звуковое уведомление
            sr.WriteLine("10");    //Время скрытия frmUpdateInfo (сек)
            sr.WriteLine("1");     //Частота обновления (мин)
            
            sr.Close();
                        
            loadConfig();
        }


    }
}
