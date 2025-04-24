0030:TempPE:000000000:2:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0033:packages.config:0EA:1:14=5D4D12EF:16=47d21313:﻿<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Microsoft.AspNet.SignalR.Client" version="2.4.1" targetFramework="net45" />
  <package id="Newtonsoft.Json" version="6.0.4" targetFramework="net45" />
</packages>002F:Program.cs:0228:1:14=5D4D12EF:16=47d21313:﻿using Microsoft.AspNet.SignalR.Client;
using static System.Console;

namespace ClientWithSignalRDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new Connection("http://localhost:65309/Connections/ChatConnection");

            connection.Received += WriteLine;
            connection.Start().Wait();

            string line;
            while ((line = ReadLine()) != null)
            {
                connection.Send(line).Wait();
            }
        }
    }
}
0034:Properties:000000000:2:14=48041e4b:16=47d21313:0034:AssemblyInfo.cs:05E5:1:14=5D4D1620:16=47d21313:﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("ClientWithSignalRDemo")]
[assembly: AssemblyDescription("史上最全面的SignalR系列教程实例代码 QQ:406590790")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("海南国思软件科技有限公司")]
[assembly: AssemblyProduct("ClientWithSignalRDemo")]
[assembly: AssemblyCopyright("Copyright © 海南国思软件科技有限公司 2010～2020")]
[assembly: AssemblyTrademark("http://www.rdiframework.net/")]
[assembly: AssemblyCulture("")]

// 将 ComVisible 设置为 false 会使此程序集中的类型
//对 COM 组件不可见。如果需要从 COM 访问此程序集中的类型
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("43a4b704-2d9a-4057-8205-6e7793f4537d")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
// 可以指定所有值，也可以使用以下所示的 "*" 预置版本号和修订号
// 方法是按如下所示使用“*”: :
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0032:packages:000000000:2:14=48041e4b:16=47d21313: