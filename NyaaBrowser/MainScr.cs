using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NyaaBrowser
{

    public partial class MainScr : Form
    {
        private Client c;
        private List<string> results;


        public MainScr(Client c)
        {
            this.c = c;
            InitializeComponent();
        }

        private void MainSrc_Load(object sender, EventArgs e)
        {
            //load data to combo box
            this.categoryBox.Items.AddRange(c.data.normalCategories);
            this.categoryBox.SelectedIndex = 0;

            this.downloadPathLabel.Text = c.data.downloadPath;
            UpdateUploaderAutoComplete();
            UpdateTitleAutoComplete();

        }

        private void UpdateUploaderAutoComplete() {
            c.data.UpdateSingleStr(ref c.data.normalUploaderDic, ref c.data.normalUploaderStr);
            c.data.UpdateSingleStr(ref c.data.sukebeiUploaderDic, ref c.data.sukebeiUploaderStr);
            if (!sukebeiCheck.Checked)
            {
                uploaderBox.AutoCompleteCustomSource.Clear();
                uploaderBox.AutoCompleteCustomSource.AddRange(c.data.normalUploaderStr);
            }
            else
            {
                uploaderBox.AutoCompleteCustomSource.Clear();
                uploaderBox.AutoCompleteCustomSource.AddRange(c.data.sukebeiUploaderStr);
            }
        }

        private void UpdateTitleAutoComplete()
        {
            c.data.UpdateSingleStr(ref c.data.normalTitlesDic, ref c.data.normalTitlesStr);
            c.data.UpdateSingleStr(ref c.data.sukebeiTitlesDic, ref c.data.sukebeiTitlesStr);
            if (!sukebeiCheck.Checked)
            {
                titleBox.AutoCompleteCustomSource.Clear();
                titleBox.AutoCompleteCustomSource.AddRange(c.data.normalTitlesStr);
            }
            else
            {
                titleBox.AutoCompleteCustomSource.Clear();
                titleBox.AutoCompleteCustomSource.AddRange(c.data.sukebeiTitlesStr);
            }
        }


        private void sukebeiCheck_CheckedChanged(object sender, EventArgs e)
        {
            //switch content of combo boxes
            this.categoryBox.Items.Clear();
            this.titleBox.Clear();
            this.uploaderBox.Clear();
            this.resultsView.Items.Clear();

            if (!sukebeiCheck.Checked)
            {
                this.categoryBox.Items.AddRange(c.data.normalCategories);
                this.categoryBox.SelectedIndex = 0;
            }
            else
            {
                this.categoryBox.Items.AddRange(c.data.sukebeiCategories);
                this.categoryBox.SelectedIndex = 0;
            }

            UpdateUploaderAutoComplete();
            UpdateTitleAutoComplete();
        }

        private void customizeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customizeBox.Checked)
            {
                customizeText.Enabled = true;
                titleBox.Enabled = false;

            }
            else
            {
                customizeText.Enabled = false;
                titleBox.Enabled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //clear previous result
            resultsView.Items.Clear();

            string[] filters = new string[3];
            //catagory
            filters[0] = c.data.GetCategoryCode(categoryBox.SelectedItem.ToString());
            //uploader
            if (uploaderBox.Text.Length != 0)
            {
                filters[1] = c.data.GetUploaderID(uploaderBox.Text, sukebeiCheck.Checked);
            }
            
            //title
            filters[2] = titleBox.Text;
             
            results = c.webFetch.fetch(filters,sukebeiCheck.Checked);

            for (int i = 0; i < results.Count; i+=3)
            {
                string[] itemStr = new string[2];
                itemStr[0] = results[i];
                itemStr[1] = results[i + 2];
                ListViewItem item = new ListViewItem(itemStr);
                resultsView.Items.Add(item);
            }

           
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            if (results!= null && results.Count == 0)
            {
                return;
            }

            string downloadPath = c.data.downloadPath;
            int[] tid = new int[resultsView.CheckedIndices.Count];
            for (int i=0;i<resultsView.CheckedIndices.Count;i++)
            {
                tid[i] = resultsView.CheckedIndices.IndexOf(i);
            }
            c.webFetch.DownloadTorrent(downloadPath, tid, sukebeiCheck.Checked);
            
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult folderResult = fbd.ShowDialog();

            if (folderResult == DialogResult.OK)
            {
               c.data.downloadPath = fbd.SelectedPath;
                this.downloadPathLabel.Text = fbd.SelectedPath;
            }
        }

        private void downloadPathLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(c.data.downloadPath);
        }

        private void uploaderEditButton_Click(object sender, EventArgs e)
        {
            string[] uploaderTitles = new string[2]{ "Uploader", "ID" };
            EditScr uploaderEdit = new EditScr(c, uploaderTitles, NyaaBrowser.EditScr.EditDic.Uploaders);
            uploaderEdit.ShowDialog();
            UpdateUploaderAutoComplete();
        }

        private void titleEditButton_Click(object sender, EventArgs e)
        {
            string[] titleTitles = new string[2] { "Title EN", "Title JP" };
            EditScr titleEdit = new EditScr(c, titleTitles, NyaaBrowser.EditScr.EditDic.Titles);
            titleEdit.ShowDialog();
            UpdateTitleAutoComplete();
            
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(this, msg,"Error", MessageBoxButtons.OK);
        }


    }
}
