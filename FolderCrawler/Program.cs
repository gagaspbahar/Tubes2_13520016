using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCrawler
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
            // Console.WriteLine("Enter root dir :");
            // string root = Console.ReadLine();
            // Console.WriteLine("Enter filename :");
            // string filename = Console.ReadLine();
            // Console.WriteLine("DO YOU WANT ALL OR NO ?");
            // string boolenak = Console.ReadLine();
            // bool myBool = bool.Parse(boolenak);
            // Algo.BFS(root, filename, myBool);
            // Console.ReadKey();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FolderCrawlerForm());
        }
  }
}
