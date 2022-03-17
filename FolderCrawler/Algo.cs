using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FolderCrawler
{
    public class Algo
    {
        public static void BFS(string root, string fileName, bool singleSearch)
        {
            Queue<string> DirectoryQueue = new Queue<string>();
            DirectoryQueue.Enqueue(root);
            while(DirectoryQueue.Count > 0)
            {
                string queueHead = DirectoryQueue.Dequeue();
                Console.WriteLine("NOW SEARCHING IN DIRECTORY : {0}", queueHead);
                string[] fileEntries = Directory.GetFiles(queueHead);
                string[] subDirectories = Directory.GetDirectories(queueHead);

                foreach (string subDirectory in subDirectories)
                {
                    DirectoryQueue.Enqueue(subDirectory);
                }

                foreach(string entry in fileEntries)
                {
                    if(entry.Contains(fileName))
                    {
                        Console.WriteLine("FILE FOUND ! Directory = {0}", entry);
                        Console.WriteLine("--------------------------------------");
                        if (singleSearch)
                        {
                            return;
                        }
                    }
                }
            }
        }
        public static void DFS(string root, string fileName, bool singleSearch)
        {
            string[] files = Directory.GetFiles(root);
            string[] subDirectories = Directory.GetDirectories(root);

            foreach(string subDirectory in subDirectories)
            {
                Console.WriteLine("NOW SEARCHING IN DIRECTORY : {0}", subDirectory);
                DFS(subDirectory, fileName, singleSearch);
            }

            foreach(string file in files)
            {
                if (file.Contains(fileName))
                {
                    Console.WriteLine("FILE FOUND ! Directory = {0}", root);
                    Console.WriteLine("--------------------------------------");
                    if (singleSearch)
                    {
                        return;
                    }
                }
            }
        }
    }
}
