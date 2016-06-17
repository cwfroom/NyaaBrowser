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
            this.titleBox = new System.Windows.Forms.ComboBox();
            this.providerEditButton = new System.Windows.Forms.Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.filterGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sukebeiCheck
            // 
            this.sukebeiCheck.AutoSize = true;
            this.sukebeiCheck.Location = new System.Drawing.Point(43, 19);
            this.sukebeiCheck.Name = "sukebeiCheck";
            this.sukebeiCheck.Size = new System.Drawing.Size(65, 17);
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
            this.filterGroupBox.Controls.Add(this.providerLabel);
            this.filterGroupBox.Controls.Add(this.providerBox);
            this.filterGroupBox.Controls.Add(this.sukebeiCheck);
            this.filterGroupBox.Location = new System.Drawing.Point(12, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(760, 100);
            this.filterGroupBox.TabIndex = 2;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Filters";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(637, 45);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(55, 42);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // customizeText
            // 
            this.customizeText.Enabled = false;
            this.customizeText.Location = new System.Drawing.Point(205, 67);
            this.customizeText.Name = "customizeText";
            this.customizeText.Size = new System.Drawing.Size(425, 20);
            this.customizeText.TabIndex = 13;
            // 
            // customizeBox
            // 
            this.customizeBox.AutoSize = true;
            this.customizeBox.Location = new System.Drawing.Point(81, 70);
            this.customizeBox.Name = "customizeBox";
            this.customizeBox.Size = new System.Drawing.Size(118, 17);
            this.customizeBox.TabIndex = 12;
            this.customizeBox.Text = "Customize Keyword";
            this.customizeBox.UseVisualStyleBackColor = true;
            this.customizeBox.CheckedChanged += new System.EventHandler(this.customizeBox_CheckedChanged);
            // 
            // timeLabelAfter
            // 
            this.timeLabelAfter.AutoSize = true;
            this.timeLabelAfter.Location = new System.Drawing.Point(508, 45);
            this.timeLabelAfter.Name = "timeLabelAfter";
            this.timeLabelAfter.Size = new System.Drawing.Size(117, 13);
            this.timeLabelAfter.TabIndex = 11;
            this.timeLabelAfter.Text = "days (0 for unrestricted)";
            // 
            // timeText
            // 
            this.timeText.Location = new System.Drawing.Point(478, 41);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(27, 20);
            this.timeText.TabIndex = 10;
            this.timeText.Text = "0";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(441, 45);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(33, 13);
            this.timeLabel.TabIndex = 9;
            this.timeLabel.Text = "Time:";
            // 
            // titleEditButton
            // 
            this.titleEditButton.Location = new System.Drawing.Point(376, 40);
            this.titleEditButton.Name = "titleEditButton";
            this.titleEditButton.Size = new System.Drawing.Size(56, 21);
            this.titleEditButton.TabIndex = 8;
            this.titleEditButton.Text = "Edit";
            this.titleEditButton.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(78, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Title:";
            // 
            // titleBox
            // 
            this.titleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.titleBox.FormattingEnabled = true;
            this.titleBox.Location = new System.Drawing.Point(111, 40);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(259, 21);
            this.titleBox.TabIndex = 6;
            // 
            // providerEditButton
            // 
            this.providerEditButton.Location = new System.Drawing.Point(637, 15);
            this.providerEditButton.Name = "providerEditButton";
            this.providerEditButton.Size = new System.Drawing.Size(55, 21);
            this.providerEditButton.TabIndex = 5;
            this.providerEditButton.Text = "Edit";
            this.providerEditButton.UseVisualStyleBackColor = true;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(112, 20);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 4;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryBox
            // 
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(164, 15);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(250, 21);
            this.categoryBox.TabIndex = 3;
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(425, 20);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(49, 13);
            this.providerLabel.TabIndex = 2;
            this.providerLabel.Text = "Provider:";
            // 
            // providerBox
            // 
            this.providerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(478, 15);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(150, 21);
            this.providerBox.TabIndex = 1;
            // 
            // MainScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.Button providerEditButton;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Button titleEditButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox titleBox;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLabelAfter;
        private System.Windows.Forms.TextBox customizeText;
        private System.Windows.Forms.CheckBox customizeBox;
        private System.Windows.Forms.Button searchButton;
    }
}

