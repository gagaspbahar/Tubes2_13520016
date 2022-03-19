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

        public void colorGraph(string directory, Microsoft.Msagl.Drawing.Graph graph)
        {
            //TODO
        }

        public  void BFS(string root, string fileName, bool SearchAll)
        {
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
                foreach (string entry in fileEntries)
                {
                    wait(100); //Biar bisa munculin satu - satu galangsung semua

                    string fileLastName = new DirectoryInfo(entry).Name;
                    graph.AddEdge(queueHead, entry);

                    //4 line kebawah ini buat ngakalin soalnya kalo diambil nama akhirnya doang
                    //pas di add edge malah ke node yang sama soalnya namanya sama
                    //jadi awalnya addedgenya pake nama full directorynya terus labeltextnya diganti abis itu
                    Microsoft.Msagl.Drawing.Node parent = graph.FindNode(queueHead);
                    Microsoft.Msagl.Drawing.Node child = graph.FindNode(entry);

                    parent.LabelText = dirName;
                    child.LabelText = fileLastName;

                    if (entry.Contains(fileName))
                    {
                        string[] directories = entry.Split(Path.DirectorySeparatorChar);
                        foreach (string d in directories)
                        {
                            Console.WriteLine(d);
                            Microsoft.Msagl.Drawing.Node currentNode = graph.FindNode(d);
                            if (currentNode != null)
                            {
                                currentNode.Attr.FillColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
                            }

                        }
                        //Console.WriteLine("FILE FOUND ! Directory = {0}", entry);
                        //Console.WriteLine("--------------------------------------");
                        if (!SearchAll)
                        {
                            return;
                        }
                    }

                    // Buat munculin ato update graph
                    viewer.Graph = graph;
                    panel1.SuspendLayout();
                    viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                    panel1.Controls.Add(viewer);
                    panel1.ResumeLayout();

                } 
            }
        }

        public void DFS(Microsoft.Msagl.GraphViewerGdi.GViewer viewer, Microsoft.Msagl.Drawing.Graph graph, string root, string fileName, bool SearchAll)
        {
            string[] files = Directory.GetFiles(root);
            string[] subDirectories = Directory.GetDirectories(root);

            foreach (string subDirectory in subDirectories)
            {
                wait(100);
                var subDirectoryName = new DirectoryInfo(subDirectory).Name;
                graph.AddEdge(root, subDirectory);

                Microsoft.Msagl.Drawing.Node parent = graph.FindNode(root);
                Microsoft.Msagl.Drawing.Node child = graph.FindNode(subDirectory);

                var dirName = new DirectoryInfo(root).Name;
                parent.LabelText = dirName;
                child.LabelText = subDirectoryName;
                
                viewer.Graph = graph;
                panel1.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(viewer);
                panel1.ResumeLayout();
                // REKURSIF
                DFS(viewer, graph, subDirectory, fileName, SearchAll);
            }

            foreach (string file in files)
            {
                wait(100);
                var fileLastName = new DirectoryInfo(file).Name;
                graph.AddEdge(root, file);

                Microsoft.Msagl.Drawing.Node parent = graph.FindNode(root);
                Microsoft.Msagl.Drawing.Node child = graph.FindNode(file);

                var dirName = new DirectoryInfo(root).Name;
                parent.LabelText = dirName;
                child.LabelText = fileLastName;

                viewer.Graph = graph;
                panel1.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                panel1.Controls.Add(viewer);
                panel1.ResumeLayout();
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
            panel1.Controls.Clear();
            if (methodUsed == "BFS")
            {
                BFS(root, filename, findAll);
            }
            else if(methodUsed == "DFS")
            {
                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                DFS(viewer, graph, root, filename, findAll);
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

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
