using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace LabTask2_BCS23020011
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
