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
            this.BFSRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSRadioButton.Location = new System.Drawing.Point(308, 102);
            this.BFSRadioButton.Name = "BFSRadioButton";
            this.BFSRadioButton.Size = new System.Drawing.Size(55, 21);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Cool Story Folder Crawler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.BackColor = System.Drawing.Color.Transparent;
            this.DFSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSButton.Location = new System.Drawing.Point(375, 102);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(56, 21);
            this.DFSButton.TabIndex = 13;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = false;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(592, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFolder.Location = new System.Drawing.Point(591, 66);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(98, 28);
            this.chooseFolder.TabIndex = 15;
            this.chooseFolder.Text = "Choose Folder...";
            this.chooseFolder.UseVisualStyleBackColor = false;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // inputFilename
            // 
            this.inputFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilename.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilename.Location = new System.Drawing.Point(21, 102);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(270, 24);
            this.inputFilename.TabIndex = 17;
            this.inputFilename.Text = "e.g. \"word.pdf\"";
            this.inputFilename.TextChanged += new System.EventHandler(this.inputFilename_TextChanged);
            // 
            // allOccurence
            // 
            this.allOccurence.AutoSize = true;
            this.allOccurence.BackColor = System.Drawing.Color.Transparent;
            this.allOccurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOccurence.Location = new System.Drawing.Point(437, 106);
            this.allOccurence.Name = "allOccurence";
            this.allOccurence.Size = new System.Drawing.Size(131, 17);
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
            this.chosenFile.Location = new System.Drawing.Point(21, 73);
            this.chosenFile.Name = "chosenFile";
            this.chosenFile.Size = new System.Drawing.Size(554, 21);
            this.chosenFile.TabIndex = 16;
            this.chosenFile.Text = "No Folder Chosen";
            this.chosenFile.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(21, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 284);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTakenLabel.Location = new System.Drawing.Point(20, 439);
            this.timeTakenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(111, 20);
            this.timeTakenLabel.TabIndex = 21;
            this.timeTakenLabel.Text = "Time Taken: ";
            // 
            // hyperlinkListBox
            // 
            this.hyperlinkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hyperlinkListBox.FormattingEnabled = true;
            this.hyperlinkListBox.ItemHeight = 15;
            this.hyperlinkListBox.Location = new System.Drawing.Point(21, 503);
            this.hyperlinkListBox.Name = "hyperlinkListBox";
            this.hyperlinkListBox.Size = new System.Drawing.Size(667, 49);
            this.hyperlinkListBox.TabIndex = 22;
            this.hyperlinkListBox.SelectedIndexChanged += new System.EventHandler(this.hyperlinkListBox_SelectedIndexChanged);
            // 
            // hyperlinks
            // 
            this.hyperlinks.AutoSize = true;
            this.hyperlinks.BackColor = System.Drawing.Color.Transparent;
            this.hyperlinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinks.Location = new System.Drawing.Point(21, 466);
            this.hyperlinks.Name = "hyperlinks";
            this.hyperlinks.Size = new System.Drawing.Size(103, 20);
            this.hyperlinks.TabIndex = 23;
            this.hyperlinks.Text = "Found files:";
            // 
            // errorNoFolder
            // 
            this.errorNoFolder.AutoSize = true;
            this.errorNoFolder.BackColor = System.Drawing.Color.Transparent;
            this.errorNoFolder.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNoFolder.ForeColor = System.Drawing.Color.Red;
            this.errorNoFolder.Location = new System.Drawing.Point(23, 130);
            this.errorNoFolder.Name = "errorNoFolder";
            this.errorNoFolder.Size = new System.Drawing.Size(14, 17);
            this.errorNoFolder.TabIndex = 24;
            this.errorNoFolder.Text = "  ";
            this.errorNoFolder.Click += new System.EventHandler(this.errorNoFolder_Click);
            // 
            // FolderCrawlerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 579);
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

