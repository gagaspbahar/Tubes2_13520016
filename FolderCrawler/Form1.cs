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
        bool findAll = false;
        string methodUsed;
        bool DFSalive = true;
        public void wait(int milliseconds)
        {
            //fungsi wait biar graph dibuatnya ga instan, biar bisa "munculin satu - satu (bonus)"
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

        public void colorGraph(string entry, Microsoft.Msagl.Drawing.Graph graph)
        {
            //fungsi buat warnain semua node yang menuju file ketemu
            Microsoft.Msagl.Drawing.Node currentNode = null;
            Microsoft.Msagl.Drawing.Color nodeColor = Microsoft.Msagl.Drawing.Color.PaleGreen;
            Microsoft.Msagl.Drawing.Color edgeColor = Microsoft.Msagl.Drawing.Color.Green;

            for (int i = 0; i < entry.Length; i++)
            {
                if (entry[i] == Path.DirectorySeparatorChar)
                {

                    string sliced = entry.Substring(0, i);
                    currentNode = graph.FindNode(sliced);

                    if (currentNode != null)
                    {
                        foreach (Microsoft.Msagl.Drawing.Edge edge in currentNode.InEdges)
                        {
                            edge.Attr.Color = edgeColor;
                        }
                        currentNode.Attr.FillColor = nodeColor;
                    }
                }
            }
            currentNode = graph.FindNode(entry);
            currentNode.Attr.FillColor = nodeColor;
            IEnumerable<Microsoft.Msagl.Drawing.Edge> edges = currentNode.InEdges;
            edges.ElementAt(0).Attr.Color = edgeColor;
        }

        public void showGraph(Microsoft.Msagl.GraphViewerGdi.GViewer viewer, Microsoft.Msagl.Drawing.Graph graph)
        {
            //fungsi buat nunjukin/update graph
            viewer.Graph = graph;
            panel1.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }

        public  void BFS(string root, string fileName, bool SearchAll)
        {
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            Microsoft.Msagl.Drawing.Color redColor = Microsoft.Msagl.Drawing.Color.Red;
            Microsoft.Msagl.Drawing.Color roseColor = Microsoft.Msagl.Drawing.Color.MistyRose;

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
                    graph.AddEdge(queueHead, subDirectory).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                    Microsoft.Msagl.Drawing.Node parent = graph.FindNode(queueHead);
                    Microsoft.Msagl.Drawing.Node child = graph.FindNode(subDirectory);

                    parent.LabelText = dirName;
                    child.LabelText = subDirectoryName;
                    parent.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                    child.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

                    DirectoryQueue.Enqueue(subDirectory);
                    showGraph(viewer,graph);
                }
                foreach (string entry in fileEntries)
                {
                    wait(100); 

                    string fileLastName = new DirectoryInfo(entry).Name;
                    graph.AddEdge(queueHead, entry).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                    Microsoft.Msagl.Drawing.Node parent = graph.FindNode(queueHead);
                    Microsoft.Msagl.Drawing.Node child = graph.FindNode(entry);

                    //ganti nama node dari directory jadi nama file/directornya doang
                    parent.LabelText = dirName;
                    child.LabelText = fileLastName;
                    parent.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                    child.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

                    showGraph(viewer, graph);
                    if (entry.Contains(fileName))
                    {

                        colorGraph(entry, graph);
                        if (!SearchAll)
                        {
                            return;
                        }
                    }

                }  
            }
        }

        public void DFS(Microsoft.Msagl.GraphViewerGdi.GViewer viewer, Microsoft.Msagl.Drawing.Graph graph, string root, string fileName, bool SearchAll)
        {

            string[] files = Directory.GetFiles(root);
            string[] subDirectories = Directory.GetDirectories(root);

            foreach (string subDirectory in subDirectories)
            {
                if (!DFSalive)
                {
                    return;
                }
                wait(100);
                var subDirectoryName = new DirectoryInfo(subDirectory).Name;
                graph.AddEdge(root, subDirectory).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                Microsoft.Msagl.Drawing.Node parent = graph.FindNode(root);
                Microsoft.Msagl.Drawing.Node child = graph.FindNode(subDirectory);
                if (parent.Attr.FillColor != Microsoft.Msagl.Drawing.Color.PaleGreen)
                {
                    parent.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                }
                
                child.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

                var dirName = new DirectoryInfo(root).Name;
                parent.LabelText = dirName;
                child.LabelText = subDirectoryName;

                showGraph(viewer, graph);
                // REKURSIF
                DFS(viewer, graph, subDirectory, fileName, SearchAll);
            }


            foreach (string file in files)
            {
                if (!DFSalive)
                {
                    return;
                }
                wait(100);
                var fileLastName = new DirectoryInfo(file).Name;
                graph.AddEdge(root, file).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;

                Microsoft.Msagl.Drawing.Node parent = graph.FindNode(root);
                Microsoft.Msagl.Drawing.Node child = graph.FindNode(file);

                var dirName = new DirectoryInfo(root).Name;
                parent.LabelText = dirName;
                child.LabelText = fileLastName;
                if(parent.Attr.FillColor != Microsoft.Msagl.Drawing.Color.PaleGreen)
                {
                    parent.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;
                }
                child.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MistyRose;

                showGraph(viewer, graph);
                if (file.Contains(fileName))
                {
                    Console.WriteLine(SearchAll);
                    colorGraph(file,graph);
                    if (!SearchAll)
                    {
                        DFSalive = false;
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
                DFSalive = true;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
