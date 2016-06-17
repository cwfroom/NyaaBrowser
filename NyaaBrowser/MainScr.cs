using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyaaBrowser
{

    public partial class MainScr : Form
    {
        private Client c;

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
        }

        private void sukebeiCheck_CheckedChanged(object sender, EventArgs e)
        {
            //switch content of combo boxes
            this.categoryBox.Items.Clear();
            this.uploaderBox.Items.Clear();

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
            string[] parameters = new string[1];
            parameters[0] = "h";
            List<string> results = c.webFetch.fetch(parameters);

            for (int i = 0; i < results.Count; i+=3)
            {
                string[] itemStr = new string[2];
                itemStr[0] = results[i];
                itemStr[1] = results[i + 2];
                ListViewItem item = new ListViewItem(itemStr);
                resultsView.Items.Add(item);
            }

           
        }
    }
}
