﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swebui;

namespace SwebuiDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SwebServer server = new SwebServer();
            server.StartUpForm = typeof(shopIndex);
            //端口修改
            //server.Setting.HttpServerPort = 2328; 
            server.SessionStart += new SwebSessionEventHandler(SwebGlobal.OnSessionStart);
            server.SessionStop += new SwebSessionEventHandler(SwebGlobal.OnSessionStop);
            server.SessionConnect += new SwebSessionEventHandler(SwebGlobal.OnSessionConnect);
            server.StartServer();
            SwebGlobal.OnServerStart(server);
            Console.WriteLine($"Swebui running at port {server.Setting.HttpServerPort}, any key to stop!");
            Console.ReadKey();
            SwebGlobal.OnServerStop(server);
        }
    }
}
