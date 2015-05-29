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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sukebeiCheck_CheckedChanged(object sender, EventArgs e)
        {
            
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

    }
}
