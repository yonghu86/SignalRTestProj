0061:TemporaryGeneratedFile_5937a670-0e60-4077-877b-f7221da3dda1.cs:00:1:14=5D50BAA4:16=47d21313:0061:TemporaryGeneratedFile_E7A71F73-0F8D-4B9B-B56E-8E70B10BC5D3.cs:00:1:14=5D50BAA4:16=47d21313:0030:TempPE:000000000:2:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0023:.:0:3:14=48041e4b:16=47d21313:0034:packages.config:0421:1:14=5D50BAA4:16=47d21313:﻿<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Microsoft.AspNet.Cors" version="5.0.0" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.Core" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.AspNet.SignalR.SelfHost" version="2.4.1" targetFramework="net45" />
  <package id="Microsoft.Owin" version="4.0.1" targetFramework="net45" />
  <package id="Microsoft.Owin.Cors" version="4.0.1" targetFramework="net45" />
  <package id="Microsoft.Owin.Diagnostics" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Host.HttpListener" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Hosting" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.Security" version="2.1.0" targetFramework="net45" />
  <package id="Microsoft.Owin.SelfHost" version="2.1.0" targetFramework="net45" />
  <package id="Newtonsoft.Json" version="6.0.4" targetFramework="net45" />
  <package id="Owin" version="1.0" targetFramework="net45" />
</packages>002F:Program.cs:067D:1:14=5D50BAA4:16=47d21313:﻿using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace SignalRSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will *ONLY* bind to localhost, if you want to bind to all addresses
            // use http://*:8080 to bind to all addresses. 
            // See http://msdn.microsoft.com/en-us/library/system.net.httplistener.aspx 
            // for more information.
            string url = "http://localhost:8077";
            using (WebApp.Start(url))
            {
                Console.WriteLine("SignalR Server running on {0}", url);
                Console.ReadLine();
            }
        }
    }

    /// <summary>
    /// 该类含有SignalR服务端的配置(该教程使用的唯一的配置是用来调用UseCors), 
    /// MapSignalR为所有形式的Hub对象创建了路由规则
    /// </summary>
    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR();
        }
    }

    /// <summary>
    /// SignalR的Hub 类是程序要提供给客户端的
    /// 该类就一个方法,Send:客户端可以用来发送消息给其他客户端
    /// </summary>
    public class MyHub : Hub
    {
        //服务端的方�