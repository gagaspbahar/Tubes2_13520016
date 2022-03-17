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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.chosenFile = new System.Windows.Forms.Label();
            this.inputFilename = new System.Windows.Forms.TextBox();
            this.allOccurence = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BFSRadioButton
            // 
            this.BFSRadioButton.AutoSize = true;
            this.BFSRadioButton.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSRadioButton.Location = new System.Drawing.Point(51, 288);
            this.BFSRadioButton.Name = "BFSRadioButton";
            this.BFSRadioButton.Size = new System.Drawing.Size(48, 21);
            this.BFSRadioButton.TabIndex = 6;
            this.BFSRadioButton.TabStop = true;
            this.BFSRadioButton.Text = "BFS";
            this.BFSRadioButton.UseVisualStyleBackColor = true;
            this.BFSRadioButton.CheckedChanged += new System.EventHandler(this.BFSRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Folder Crawler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Choose Starting Directory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Input File Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Input Metode Pencarian";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(51, 315);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DFS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(51, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.chooseFolder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chooseFolder.Location = new System.Drawing.Point(53, 124);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(96, 27);
            this.chooseFolder.TabIndex = 15;
            this.chooseFolder.Text = "Choose Folder...";
            this.chooseFolder.UseVisualStyleBackColor = false;
            // 
            // chosenFile
            // 
            this.chosenFile.AutoSize = true;
            this.chosenFile.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenFile.Location = new System.Drawing.Point(155, 130);
            this.chosenFile.Name = "chosenFile";
            this.chosenFile.Size = new System.Drawing.Size(86, 15);
            this.chosenFile.TabIndex = 16;
            this.chosenFile.Text = "No File Chosen";
            // 
            // inputFilename
            // 
            this.inputFilename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFilename.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFilename.Location = new System.Drawing.Point(51, 193);
            this.inputFilename.Name = "inputFilename";
            this.inputFilename.Size = new System.Drawing.Size(198, 22);
            this.inputFilename.TabIndex = 17;
            this.inputFilename.Text = "e.g. \"word.pdf\"";
            // 
            // allOccurence
            // 
            this.allOccurence.AutoSize = true;
            this.allOccurence.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOccurence.Location = new System.Drawing.Point(51, 221);
            this.allOccurence.Name = "allOccurence";
            this.allOccurence.Size = new System.Drawing.Size(120, 19);
            this.allOccurence.TabIndex = 19;
            this.allOccurence.Text = "Find all occurence";
            this.allOccurence.UseVisualStyleBackColor = true;
            // 
            // FolderCrawlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 479);
            this.Controls.Add(this.allOccurence);
            this.Controls.Add(this.inputFilename);
            this.Controls.Add(this.chosenFile);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BFSRadioButton);
            this.Name = "FolderCrawlerForm";
            this.Text = "Form1";
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Label chosenFile;
        private System.Windows.Forms.TextBox inputFilename;
        private System.Windows.Forms.CheckBox allOccurence;
    }
}

