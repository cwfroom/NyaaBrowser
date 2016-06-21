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
    public partial class EditDiag : Form
    {

        private string[] data;
        private EditScr parent;
        private bool editMode;

        public EditDiag(EditScr parent, string[] titles)
        {
            editMode = false;
            this.parent = parent;
            InitializeComponent();
            this.Text = "Add Entry";
            assignLabels(titles);
        }

        public EditDiag(EditScr parent, string[] titles, string[] data)
        {
            editMode = true;
            this.parent = parent;
            this.data = data;
            InitializeComponent();
            this.Text = "Edit Entry";
            assignLabels(titles);
            keyBox.Text = data[0];
            valueBox.Text = data[1];
        }


        private void assignLabels(string[] titles)
        {
            keyLabel.Text = titles[0];
            valueLabel.Text = titles[1];
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (keyBox.Text.Length == 0 || valueBox.Text.Length == 0)
            {
                MessageBox.Show(this,"Please fill out both values.", "Error", MessageBoxButtons.OK);
                return;
            }

            string[] lData = new string[2];
            lData[0] = keyBox.Text;
            lData[1] = valueBox.Text;
            
            parent.updateEntry(lData,editMode);
            
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
