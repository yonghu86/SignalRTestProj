0030:TempPE:000000000:2:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0033:packages.config:0EA:1:14=5D50BAA5:16=47d21313:﻿<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Microsoft.AspNet.SignalR.Client" version="2.4.1" targetFramework="net45" />
  <package id="Newtonsoft.Json" version="6.0.4" targetFramework="net45" />
</packages>002F:Program.cs:0237:1:14=5D50BAA5:16=47d21313:﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignalRSelfHostWinFormClient
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignalRSelfHostWinFormClientTest());
        }
    }
}
