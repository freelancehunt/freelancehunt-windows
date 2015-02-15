using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;

namespace freelancehunt
{
    class clsPing
    {
        #region событие изменения состояния коннекта
        
        public delegate void evInternetConnectChangeHandle (bool connect);
        public static event  evInternetConnectChangeHandle evInternetConnectChange; 
        
        #endregion

        public static bool isConnect {get; private set;}

        static void thRefresh()
        {
            Ping ping = new Ping();
            PingReply rep = null;

            int ok = 0;
            int bad = 5;

            string url = @"google.com";

            while (!clsUpdate.isStop)
            {
                try
                {
                    rep = ping.Send(url, 1000);
                }
                catch (Exception) { rep = null; }

                if (rep == null ||
                    rep.Status != IPStatus.Success)
                {
                    bad++;

                    if (bad >= 5)
                    {
                        bad = 5;

                        if (ok == 5)
                        {
                            if (evInternetConnectChange != null)
                                evInternetConnectChange(false);

                            Thread.Sleep(10);

                            ok = 0;

                            isConnect = false;
                        }
                    }
                }
                else
                {
                    ok++;

                    if (ok >= 5)
                    {
                        ok = 5;

                        if (bad == 5)
                        {
                            if (evInternetConnectChange != null)
                                evInternetConnectChange(true);

                            Thread.Sleep(10);

                            bad = 0;

                            isConnect = true;
                        }
                    }
                }

                //isConnect = ok == 5;

                Thread.Sleep(1000);
            }
        }

        static clsPing()
        {
            isConnect = false;

            Thread thPing = new Thread(thRefresh);
            thPing.Start();
        }
    }
}
