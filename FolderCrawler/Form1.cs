using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FolderCrawler
{
    
    public partial class FolderCrawlerForm : Form
    {
        string filename;
        string root;
        bool findAll;
        string methodUsed;
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public  void BFS(string root, string fileName, bool SearchAll)
        {
            panel1.Controls.Clear();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");

            Queue<string> DirectoryQueue = new Queue<string>();
            DirectoryQueue.Enqueue(root);
            while (DirectoryQueue.Count > 0)
            {
                string queueHead = DirectoryQueue.Dequeue();
                Console.WriteLine("NOW SEARCHING IN DIRECTORY : {0}", queueHead);
                string[] fileEntries = Directory.GetFiles(queueHead);
                string[] subDirectories = Directory.GetDirectories(queueHead);
                var dirName = new DirectoryInfo(queueHead).Name;


                foreach (string entry in fileEntries)
                {
                    wait(100); //Biar bisa munculin satu - satu galangsung semua
                    var fileLastName = new DirectoryInfo(entry).Name; 

                    graph.AddEdge(queueHead, entry);

                    //4 line kebawah ini buat ngakalin soalnya kalo diambil nama akhirnya doang
                    //pas di add edge malah ke node yang sama soalnya namanya sama
                    //jadi awalnya addedgenya pake nama full directorynya terus labeltextnya diganti abis itu
                    Microsoft.Msagl.Drawing.Node parent = graph.FindNode(queueHead);
                    Microsoft.Msagl.Drawing.Node child = graph.FindNode(entry);

                    parent.LabelText = dirName;
                    child.LabelText = fileLastName;

                    // Buat munculin ato update graph
                    viewer.Graph = graph;
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();
                    if (entry.Contains(fileName))
                    {

                        Console.WriteLine("FILE FOUND ! Directory = {0}", entry);
                        Console.WriteLine("--------------------------------------");
                        if (!SearchAll)
                        {
                            return;
                        }
                    }
                }
                foreach (string subDirectory in subDirectories)
                {
                    wait(100);
                    var subDirectoryName = new DirectoryInfo(subDirectory).Name;
                    graph.AddEdge(queueHead, subDirectory);

                    Microsoft.Msagl.Drawing.Node parent = graph.FindNode(queueHead);
                    Microsoft.Msagl.Drawing.Node child = graph.FindNode(subDirectory);

                    parent.LabelText = dirName;
                    child.LabelText = subDirectoryName;

                    DirectoryQueue.Enqueue(subDirectory);
                    viewer.Graph = graph;
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();
                }
            }
            
 

        }

        public void DFS(string root, string fileName, bool SearchAll)
        {
            panel1.Controls.Clear();
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            string[] files = Directory.GetFiles(root);
            string[] subDirectories = Directory.GetDirectories(root);

            foreach (string subDirectory in subDirectories)
            {
                Console.WriteLine("NOW SEARCHING IN DIRECTORY : {0}", subDirectory);
                DFS(subDirectory, fileName, SearchAll);
            }

            foreach (string file in files)
            {
                if (file.Contains(fileName))
                {
                    Console.WriteLine("FILE FOUND ! Directory = {0}", root);
                    Console.WriteLine("--------------------------------------");
                    if (!SearchAll)
                    {
                        return;
                    }
                }
            }
        }
        public FolderCrawlerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BFSRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (BFSRadioButton.Checked)
            {
                methodUsed = "BFS";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (methodUsed == "BFS")
            {
                BFS(root, filename, findAll);
            }
            else if(methodUsed == "DFS")
            {
                DFS(root, filename, findAll);
            }
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                chosenFile.Text = folderBrowserDialog1.SelectedPath;
                root = folderBrowserDialog1.SelectedPath;
            }
        }

        private void inputFilename_TextChanged(object sender, EventArgs e)
        {
            filename = inputFilename.Text;
        }

        private void allOccurence_CheckedChanged(object sender, EventArgs e)
        {
            if (allOccurence.Checked)
            {
                  findAll = true;
            }
            else
            {
                findAll = false; 
            }
        }

        private void DFSButton_CheckedChanged(object sender, EventArgs e)
        {
            if(DFSButton.Checked)
            {
                methodUsed = "DFS";
            }
        }
    }
}
