using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System;
using System.Diagnostics;
using OpenQA.Selenium;
using System.Threading;

namespace Bruno_sanSpamApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            var appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability("app", @"C:\Windows\System32\notepad.exe");
            var Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), appiumOptions);
            
            string bandeira = "?";
            Thread.Sleep(4000);

            for (int i=0; i< 50000; i++)
            {
                Driver.Keyboard.SendKeys(bandeira);
                Driver.Keyboard.SendKeys(Keys.Enter);
                bandeira = bandeira + "?";
            }            
        }
    }
}
