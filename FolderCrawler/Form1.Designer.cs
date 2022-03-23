namespace FolderCrawler
{
    partial class FolderCrawlerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BFSRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.inputFilename = new System.Windows.Forms.TextBox();
            this.allOccurence = new System.Windows.Forms.CheckBox();
            this.chosenFile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeTakenLabel = new System.Windows.Forms.Label();
            this.hyperlinkListBox = new System.Windows.Forms.ListBox();
            this.hyperlinks = new System.Windows.Forms.Label();
            this.errorNoFolder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BFSRadioButton
            // 
            this.BFSRadioButton.AutoSize = true;
            this.BFSRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.BFSRadioButton.Font = new System.Drawing.Font("Open Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSRadioButton.Location = new System.Drawing.Point(413, 125);
            this.BFSRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.BFSRadioButton.Name = "BFSRadioButton";
            this.BFSRadioButton.Size = new System.Drawing.Size(54, 28);
            this.BFSRadioButton.TabIndex = 6;
            this.BFSRadioButton.TabStop = true;
            this.BFSRadioButton.Text = "BFS";
            this.BFSRadioButton.UseVisualStyleBackColor = false;
            this.BFSRadioButton.CheckedChanged += new System.EventHandler(this.BFSRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Cool Story Folder Crawler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.BackColor = System.Drawing.Color.Transparent;
            this.DFSButton.Font = new System.Drawing.Font("Open Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSButton.Location = new System.Drawing.Point(507, 125);
            this.DFSButton.Margin = new System.Windows.Forms.Padding(4);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(55, 28);
            this.DFSButton.TabIndex = 13;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = false;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Open Sans Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(789, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chooseFolder.Font = new System.Drawing.Font("Open Sans Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFolder.Location = new System.Drawing.Point(788, 81);
            this.chooseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(131, 35);
            this.chooseFolder.TabIndex = 15;
            this.chooseFolder.Text = "Choose Folder...";
            this.chooseFolder.UseVisualStyleBackColor = false;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // inputFilename
            // 
            this.inputFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilename.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilename.Location = new System.Drawing.Point(28, 126);
            this.inputFilename.Margin = new System.Windows.Forms.Padding(4);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(359, 28);
            this.inputFilename.TabIndex = 17;
            this.inputFilename.Text = "e.g. \"word.pdf\"";
            this.inputFilename.TextChanged += new System.EventHandler(this.inputFilename_TextChanged);
            // 
            // allOccurence
            // 
            this.allOccurence.AutoSize = true;
            this.allOccurence.BackColor = System.Drawing.Color.Transparent;
            this.allOccurence.Font = new System.Drawing.Font("Open Sans Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOccurence.Location = new System.Drawing.Point(595, 126);
            this.allOccurence.Margin = new System.Windows.Forms.Padding(4);
            this.allOccurence.Name = "allOccurence";
            this.allOccurence.Size = new System.Drawing.Size(152, 28);
            this.allOccurence.TabIndex = 19;
            this.allOccurence.Text = "Find all occurence";
            this.allOccurence.UseVisualStyleBackColor = false;
            this.allOccurence.CheckedChanged += new System.EventHandler(this.allOccurence_CheckedChanged);
            // 
            // chosenFile
            // 
            this.chosenFile.AutoEllipsis = true;
            this.chosenFile.BackColor = System.Drawing.Color.Transparent;
            this.chosenFile.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenFile.Location = new System.Drawing.Point(28, 90);
            this.chosenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chosenFile.Name = "chosenFile";
            this.chosenFile.Size = new System.Drawing.Size(738, 26);
            this.chosenFile.TabIndex = 16;
            this.chosenFile.Text = "No Folder Chosen";
            this.chosenFile.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(28, 186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 350);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTakenLabel.Location = new System.Drawing.Point(27, 540);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(109, 28);
            this.timeTakenLabel.TabIndex = 21;
            this.timeTakenLabel.Text = "Time Taken: ";
            // 
            // hyperlinkListBox
            // 
            this.hyperlinkListBox.Font = new System.Drawing.Font("Open Sans Condensed", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hyperlinkListBox.FormattingEnabled = true;
            this.hyperlinkListBox.ItemHeight = 22;
            this.hyperlinkListBox.Location = new System.Drawing.Point(28, 619);
            this.hyperlinkListBox.Margin = new System.Windows.Forms.Padding(4);
            this.hyperlinkListBox.Name = "hyperlinkListBox";
            this.hyperlinkListBox.Size = new System.Drawing.Size(888, 70);
            this.hyperlinkListBox.TabIndex = 22;
            this.hyperlinkListBox.SelectedIndexChanged += new System.EventHandler(this.hyperlinkListBox_SelectedIndexChanged);
            // 
            // hyperlinks
            // 
            this.hyperlinks.AutoSize = true;
            this.hyperlinks.BackColor = System.Drawing.Color.Transparent;
            this.hyperlinks.Font = new System.Drawing.Font("Open Sans Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinks.Location = new System.Drawing.Point(28, 574);
            this.hyperlinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperlinks.Name = "hyperlinks";
            this.hyperlinks.Size = new System.Drawing.Size(101, 28);
            this.hyperlinks.TabIndex = 23;
            this.hyperlinks.Text = "Found files:";
            // 
            // errorNoFolder
            // 
            this.errorNoFolder.AutoSize = true;
            this.errorNoFolder.BackColor = System.Drawing.Color.Transparent;
            this.errorNoFolder.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNoFolder.ForeColor = System.Drawing.Color.Red;
            this.errorNoFolder.Location = new System.Drawing.Point(31, 160);
            this.errorNoFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorNoFolder.Name = "errorNoFolder";
            this.errorNoFolder.Size = new System.Drawing.Size(17, 20);
            this.errorNoFolder.TabIndex = 24;
            this.errorNoFolder.Text = "  ";
            this.errorNoFolder.Click += new System.EventHandler(this.errorNoFolder_Click);
            // 
            // FolderCrawlerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 713);
            this.Controls.Add(this.hyperlinkListBox);
            this.Controls.Add(this.errorNoFolder);
            this.Controls.Add(this.hyperlinks);
            this.Controls.Add(this.timeTakenLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allOccurence);
            this.Controls.Add(this.inputFilename);
            this.Controls.Add(this.chosenFile);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFSRadioButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FolderCrawlerForm";
            this.Text = "CSFC - CoolStory Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton BFSRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton DFSButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.TextBox inputFilename;
        private System.Windows.Forms.CheckBox allOccurence;
        private System.Windows.Forms.Label chosenFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeTakenLabel;
        private System.Windows.Forms.ListBox hyperlinkListBox;
        private System.Windows.Forms.Label hyperlinks;
        private System.Windows.Forms.Label errorNoFolder;
    }
}

