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
    public partial class EditScr : Form
    {
        Client c;
        private string[] columns;
        
        public enum EditDic {
            Uploaders,
            Titles
        }
        private EditDic currentDicType;

        public EditScr(Client c, string[] columns, EditDic type)
        {
            this.c = c;
            this.columns = columns;
            InitializeComponent();
            this.valueView.Columns.Add(columns[0], 277);
            this.valueView.Columns.Add(columns[1], 277);
            currentDicType = type;
            LoadValues(currentDicType);
        }

        public void LoadValues(EditDic type)
        {
            valueView.Items.Clear();
            editButton.Enabled = false;
            deleteButton.Enabled = false;

            switch (type){
                case EditDic.Uploaders:
                    if (!this.sukebeiCheck.Checked)
                    {
                        AddListItems(c.data.normalUploaderDic);
                    }else
                    {
                        AddListItems(c.data.sukebeiUploaderDic);
                    }
                    break;

                case EditDic.Titles:
                    if (!this.sukebeiCheck.Checked)
                    {
                        AddListItems(c.data.normalTitlesDic);
                    }
                    else
                    {
                        AddListItems(c.data.sukebeiTitlesDic);
                    }

                    break;
            }
            
        }

        public void AddListItems(Dictionary<string,string> dic)
        {
            for (int i = 0; i < dic.Count; i++)
            {
                string[] itemStr = new string[2];
                itemStr[0] = dic.ElementAt(i).Key;
                itemStr[1] = dic.ElementAt(i).Value;
                ListViewItem item = new ListViewItem(itemStr);
                valueView.Items.Add(item);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            //save to file

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditScr_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Changes will be not saved to file!", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void sukebeiCheck_CheckedChanged(object sender, EventArgs e)
        {
            LoadValues(currentDicType);
        }

        private void valueView_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            EditDiag editdiag = new EditDiag(this, columns);
            editdiag.ShowDialog();
        }

        private void editButton_Click(object sernder, EventArgs e)
        {
            string[] data = new string[2];
            data[0] = valueView.SelectedItems[0].SubItems[0].Text;
            data[1] = valueView.SelectedItems[0].SubItems[1].Text;
            EditDiag editdiag = new EditDiag(this, columns,data);
            editdiag.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            switch (currentDicType)
            {
                //because there's no way to return by referenece have to use bulky switch inline
                case EditDic.Uploaders:
                    if (!this.sukebeiCheck.Checked)
                    {
                        c.data.normalUploaderDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                    }
                    else
                    {
                        c.data.sukebeiUploaderDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                        }
                    break;

                case EditDic.Titles:
                    if (!this.sukebeiCheck.Checked)
                    {
                        c.data.normalTitlesDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                    }
                    else
                    {
                        c.data.sukebeiTitlesDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                    }

                    break;
            }
            LoadValues(currentDicType);
        }

        public void updateEntry(string[] values, bool edit)
        {
            //update list
            bool keyChanged = false;
            if (!edit)
            {
                ListViewItem nItem = new ListViewItem(values);
                valueView.Items.Add(nItem);
                //keychange remains false when adding new item
            }else
            {
                keyChanged = (valueView.SelectedItems[0].SubItems[0].Text != values[0]);
                valueView.SelectedItems[0].SubItems[0].Text = values[0];
                valueView.SelectedItems[0].SubItems[1].Text = values[1];
            }
            
            //update the actual dictionary
            //because there's no way to return by referenece have to use bulky switch inline
            switch (currentDicType)
            {
                case EditDic.Uploaders:
                    if (!this.sukebeiCheck.Checked)
                    {
                        if (keyChanged) c.data.normalUploaderDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                        UpdateOrAddtoDic(ref c.data.normalUploaderDic, values);
                    }
                    else
                    {
                        if (keyChanged) c.data.sukebeiUploaderDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                        UpdateOrAddtoDic(ref c.data.sukebeiUploaderDic, values);
                    }
                    break;

                case EditDic.Titles:
                    if (!this.sukebeiCheck.Checked)
                    {
                        if (keyChanged) c.data.normalTitlesDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                        UpdateOrAddtoDic(ref c.data.normalTitlesDic, values);
                    }
                    else
                    {
                        if (keyChanged) c.data.sukebeiTitlesDic.Remove(valueView.SelectedItems[0].SubItems[0].Text);
                        UpdateOrAddtoDic(ref c.data.sukebeiTitlesDic, values);
                    }

                    break;
            }
        }

        //private void removeEntry(ref Dictionary<string, string> dic, string[] values)

        private void UpdateOrAddtoDic(ref Dictionary<string,string> dic, string[] values)
        {
            if (dic.ContainsKey(values[0])){
                dic[values[0]] = values[1];
            }else
            {
                dic.Add(values[0], values[1]);
            }
            
        }
    }
}
