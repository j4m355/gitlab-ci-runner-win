﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using gitlab_ci_runner.conf;
using gitlab_ci_runner.runner;
using gitlab_ci_runner.setup;

namespace gitlab_ci_runner
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.DefaultConnectionLimit = 999;
            Console.WriteLine("Starting Gitlab CI Runner for Windows");
            Config.loadConfig();
            if (Config.isConfigured())
            {
                // Load the runner
                Runner.run();
            }
            else
            {
                // Load the setup
                Setup.run();
            }
            Console.WriteLine();
            Console.WriteLine("Runner quit. Press any key to exit!");
            Console.ReadLine();
        }
    }
}
