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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.BFSRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSRadioButton.Location = new System.Drawing.Point(67, 386);
            this.BFSRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BFSRadioButton.Name = "BFSRadioButton";
            this.BFSRadioButton.Size = new System.Drawing.Size(61, 22);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Cool Story Folder Crawler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(828, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose Starting Directory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Input File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Input Metode Pencarian";
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.BackColor = System.Drawing.Color.Transparent;
            this.DFSButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSButton.Location = new System.Drawing.Point(67, 420);
            this.DFSButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(62, 22);
            this.DFSButton.TabIndex = 13;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = false;
            this.DFSButton.CheckedChanged += new System.EventHandler(this.DFSButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(65, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFolder.Location = new System.Drawing.Point(65, 161);
            this.chooseFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(128, 33);
            this.chooseFolder.TabIndex = 15;
            this.chooseFolder.Text = "Choose Folder...";
            this.chooseFolder.UseVisualStyleBackColor = false;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // inputFilename
            // 
            this.inputFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilename.Location = new System.Drawing.Point(67, 268);
            this.inputFilename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(263, 23);
            this.inputFilename.TabIndex = 17;
            this.inputFilename.Text = "e.g. \"word.pdf\"";
            this.inputFilename.TextChanged += new System.EventHandler(this.inputFilename_TextChanged);
            // 
            // allOccurence
            // 
            this.allOccurence.AutoSize = true;
            this.allOccurence.BackColor = System.Drawing.Color.Transparent;
            this.allOccurence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOccurence.Location = new System.Drawing.Point(67, 303);
            this.allOccurence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allOccurence.Name = "allOccurence";
            this.allOccurence.Size = new System.Drawing.Size(163, 21);
            this.allOccurence.TabIndex = 19;
            this.allOccurence.Text = "Find all occurence";
            this.allOccurence.UseVisualStyleBackColor = false;
            this.allOccurence.CheckedChanged += new System.EventHandler(this.allOccurence_CheckedChanged);
            // 
            // chosenFile
            // 
            this.chosenFile.AutoEllipsis = true;
            this.chosenFile.BackColor = System.Drawing.Color.Transparent;
            this.chosenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenFile.Location = new System.Drawing.Point(201, 170);
            this.chosenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chosenFile.Name = "chosenFile";
            this.chosenFile.Size = new System.Drawing.Size(316, 16);
            this.chosenFile.TabIndex = 16;
            this.chosenFile.Text = "No File Chosen";
            this.chosenFile.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(565, 107);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 409);
            this.panel1.TabIndex = 20;
            // 
            // timeTakenLabel
            // 
            this.timeTakenLabel.AutoSize = true;
            this.timeTakenLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeTakenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTakenLabel.Location = new System.Drawing.Point(560, 530);
            this.timeTakenLabel.Name = "timeTakenLabel";
            this.timeTakenLabel.Size = new System.Drawing.Size(140, 25);
            this.timeTakenLabel.TabIndex = 21;
            this.timeTakenLabel.Text = "Time Taken: ";
            // 
            // hyperlinkListBox
            // 
            this.hyperlinkListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinkListBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.hyperlinkListBox.FormattingEnabled = true;
            this.hyperlinkListBox.ItemHeight = 17;
            this.hyperlinkListBox.Location = new System.Drawing.Point(565, 602);
            this.hyperlinkListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hyperlinkListBox.Name = "hyperlinkListBox";
            this.hyperlinkListBox.Size = new System.Drawing.Size(655, 55);
            this.hyperlinkListBox.TabIndex = 22;
            this.hyperlinkListBox.SelectedIndexChanged += new System.EventHandler(this.hyperlinkListBox_SelectedIndexChanged);
            // 
            // hyperlinks
            // 
            this.hyperlinks.AutoSize = true;
            this.hyperlinks.BackColor = System.Drawing.Color.Transparent;
            this.hyperlinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyperlinks.Location = new System.Drawing.Point(560, 571);
            this.hyperlinks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hyperlinks.Name = "hyperlinks";
            this.hyperlinks.Size = new System.Drawing.Size(125, 25);
            this.hyperlinks.TabIndex = 23;
            this.hyperlinks.Text = "Found files:";
            // 
            // errorNoFolder
            // 
            this.errorNoFolder.AutoSize = true;
            this.errorNoFolder.BackColor = System.Drawing.Color.Transparent;
            this.errorNoFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorNoFolder.ForeColor = System.Drawing.Color.Red;
            this.errorNoFolder.Location = new System.Drawing.Point(68, 198);
            this.errorNoFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorNoFolder.Name = "errorNoFolder";
            this.errorNoFolder.Size = new System.Drawing.Size(16, 17);
            this.errorNoFolder.TabIndex = 24;
            this.errorNoFolder.Text = "  ";
            // 
            // FolderCrawlerForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1237, 732);
            this.Controls.Add(this.errorNoFolder);
            this.Controls.Add(this.hyperlinks);
            this.Controls.Add(this.hyperlinkListBox);
            this.Controls.Add(this.timeTakenLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.allOccurence);
            this.Controls.Add(this.inputFilename);
            this.Controls.Add(this.chosenFile);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DFSButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFSRadioButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FolderCrawlerForm";
            this.Text = "CSFC - CoolStory Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton BFSRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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

