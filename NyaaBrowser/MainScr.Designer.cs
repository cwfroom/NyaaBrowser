namespace NyaaBrowser
{
    partial class MainScr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScr));
            this.sukebeiCheck = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.customizeText = new System.Windows.Forms.TextBox();
            this.customizeBox = new System.Windows.Forms.CheckBox();
            this.timeLabelAfter = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.titleEditButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.providerEditButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.uploaderLabel = new System.Windows.Forms.Label();
            this.uploaderBox = new System.Windows.Forms.TextBox();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.resultsView = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sukebeiCheck
            // 
            this.sukebeiCheck.AutoSize = true;
            this.sukebeiCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sukebeiCheck.Location = new System.Drawing.Point(15, 19);
            this.sukebeiCheck.Name = "sukebeiCheck";
            this.sukebeiCheck.Size = new System.Drawing.Size(77, 20);
            this.sukebeiCheck.TabIndex = 0;
            this.sukebeiCheck.Text = "Sukebei";
            this.sukebeiCheck.UseVisualStyleBackColor = true;
            this.sukebeiCheck.CheckedChanged += new System.EventHandler(this.sukebeiCheck_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.preferenceToolStripMenuItem.Text = "Preference";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.searchButton);
            this.filterGroupBox.Controls.Add(this.customizeText);
            this.filterGroupBox.Controls.Add(this.customizeBox);
            this.filterGroupBox.Controls.Add(this.timeLabelAfter);
            this.filterGroupBox.Controls.Add(this.timeText);
            this.filterGroupBox.Controls.Add(this.timeLabel);
            this.filterGroupBox.Controls.Add(this.titleEditButton);
            this.filterGroupBox.Controls.Add(this.titleLabel);
            this.filterGroupBox.Controls.Add(this.titleBox);
            this.filterGroupBox.Controls.Add(this.providerEditButton);
            this.filterGroupBox.Controls.Add(this.categoryLabel);
            this.filterGroupBox.Controls.Add(this.categoryBox);
            this.filterGroupBox.Controls.Add(this.uploaderLabel);
            this.filterGroupBox.Controls.Add(this.uploaderBox);
            this.filterGroupBox.Controls.Add(this.sukebeiCheck);
            this.filterGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterGroupBox.Location = new System.Drawing.Point(12, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(760, 118);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(647, 75);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(67, 32);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customizeText
            // 
            this.customizeText.Enabled = false;
            this.customizeText.Location = new System.Drawing.Point(161, 80);
            this.customizeText.Name = "customizeText";
            this.customizeText.Size = new System.Drawing.Size(480, 22);
            this.customizeText.TabIndex = 13;
            // 
            // customizeBox
            // 
            this.customizeBox.AutoSize = true;
            this.customizeBox.Location = new System.Drawing.Point(15, 82);
            this.customizeBox.Name = "customizeBox";
            this.customizeBox.Size = new System.Drawing.Size(144, 20);
            this.customizeBox.TabIndex = 12;
            this.customizeBox.Text = "Customize Keyword";
            this.customizeBox.UseVisualStyleBackColor = true;
            this.customizeBox.CheckedChanged += new System.EventHandler(this.customizeBox_CheckedChanged);
            // 
            // timeLabelAfter
            // 
            this.timeLabelAfter.AutoSize = true;
            this.timeLabelAfter.Location = new System.Drawing.Point(608, 54);
            this.timeLabelAfter.Name = "timeLabelAfter";
            this.timeLabelAfter.Size = new System.Drawing.Size(146, 16);
            this.timeLabelAfter.TabIndex = 11;
            this.timeLabelAfter.Text = "days (0 for unrestricted)";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(575, 51);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(27, 22);
            this.timeText.TabIndex = 10;
            this.timeText.Text = "0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(527, 53);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(42, 16);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time:";
            // 
            // titleEditButton
            // 
            this.titleEditButton.Location = new System.Drawing.Point(456, 46);
            this.titleEditButton.Name = "titleEditButton";
            this.titleEditButton.Size = new System.Drawing.Size(65, 26);
            this.titleEditButton.TabIndex = 8;
            this.titleEditButton.Text = "Edit";
            this.titleEditButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(37, 16);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Gochuumon wa Usagi Desu ka"});
            this.titleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.titleBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.titleBox.Location = new System.Drawing.Point(55, 48);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(395, 22);
            this.titleBox.TabIndex = 6;
            // 
            // providerEditButton
            // 
            this.providerEditButton.Location = new System.Drawing.Point(687, 15);
            this.providerEditButton.Name = "providerEditButton";
            this.providerEditButton.Size = new System.Drawing.Size(67, 26);
            this.providerEditButton.TabIndex = 5;
            this.providerEditButton.Text = "Edit";
            this.providerEditButton.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(89, 20);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(66, 16);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(161, 15);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(311, 24);
            this.categoryBox.TabIndex = 3;
            // 
            // uploaderLabel
            // 
            this.uploaderLabel.AutoSize = true;
            this.uploaderLabel.Location = new System.Drawing.Point(478, 19);
            this.uploaderLabel.Name = "uploaderLabel";
            this.uploaderLabel.Size = new System.Drawing.Size(68, 16);
            this.uploaderLabel.TabIndex = 2;
            this.uploaderLabel.Text = "Uploader:";
            // 
            // uploaderBox
            // 
            this.uploaderBox.AutoCompleteCustomSource.AddRange(new string[] {
            "ohys"});
            this.uploaderBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uploaderBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uploaderBox.Location = new System.Drawing.Point(552, 15);
            this.uploaderBox.Name = "uploaderBox";
            this.uploaderBox.Size = new System.Drawing.Size(129, 22);
            this.uploaderBox.TabIndex = 1;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.downloadButton);
            this.resultsGroupBox.Controls.Add(this.resultsView);
            this.resultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 151);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(760, 398);
            this.resultsGroupBox.TabIndex = 3;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // resultsView
            // 
            this.resultsView.CheckBoxes = true;
            this.resultsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.fileSize});
            this.resultsView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsView.FullRowSelect = true;
            this.resultsView.GridLines = true;
            this.resultsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.resultsView.Location = new System.Drawing.Point(6, 19);
            this.resultsView.Name = "resultsView";
            this.resultsView.Size = new System.Drawing.Size(748, 342);
            this.resultsView.TabIndex = 1;
            this.resultsView.UseCompatibleStateImageBehavior = false;
            this.resultsView.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 650;
            // 
            // fileSize
            // 
            this.fileSize.Text = "File Size";
            this.fileSize.Width = 90;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(313, 367);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(86, 23);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // MainScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainScr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nyaa Browser";
            this.Load += new System.EventHandler(this.MainSrc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.CheckBox sukebeiCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label uploaderLabel;
        private System.Windows.Forms.TextBox uploaderBox;
        private System.Windows.Forms.Button providerEditButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button titleEditButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLabelAfter;
        private System.Windows.Forms.TextBox customizeText;
        private System.Windows.Forms.CheckBox customizeBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.ListView resultsView;
        private System.Windows.Forms.ColumnHeader fileName;
        protected internal System.Windows.Forms.ColumnHeader fileSize;
        private System.Windows.Forms.Button downloadButton;
    }
}

