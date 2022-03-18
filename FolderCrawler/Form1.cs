using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCrawler
{
    
    public partial class FolderCrawlerForm : Form
    {
        string filename;
        string root;
        bool findAll;
        string methodUsed;

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
                Algo.BFS(root, filename, findAll);
            }
            else if(methodUsed == "DFS")
            {
                Algo.DFS(root, filename, findAll);
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                methodUsed = "DFS";
            }
        }
    }
}
