using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Windows
{
    public partial class StartForm : Form
    {
        ShowDataUtil showData;

        Dictionary<string, string> tableList;

        public StartForm()
        {
            InitializeComponent();
            showData = new ShowDataUtil();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableList = showData.ShowTableObjects();
            foreach (var item in tableList)
            {
                this.tableListBox.Items.Add(item.Key);
            }
        }

        private void tableListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tableListBox.SelectedIndex != -1)
            {
                this.tableObjectsListView.Visible = true;
                ShowTableObjects(this.tableListBox.Text);
            }
        }

        private void ShowTableObjects(string tableName)
        {
            tableName = tableList[tableName];
            Dictionary<string, string> tableTitle = showData.findTableTitle(tableName);
            this.tableObjectsListView.Columns.Clear();
            foreach (var item in tableTitle)
            {
                this.tableObjectsListView.Columns.Add(item.Key, item.Value);
                if (!item.Key.Equals("Id"))
                {
                    this.tableObjectsListView.Columns[item.Key].Width = 120;
                }
            }
            this.tableObjectsListView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            this.tableObjectsListView.Items.Clear();
            foreach (List<string> data in showData.FindTableObjects(tableName))
            {
                ListViewItem lvi = new ListViewItem();
                if(data.Count > 0)
                {
                    lvi.Text = data[0];
                    for (int i = 1; i < data.Count; i++)
                    {
                        lvi.SubItems.Add(data[i]);
                    }
                }
                this.tableObjectsListView.Items.Add(lvi);
            }
            this.tableObjectsListView.EndUpdate();  //结束数据处理，UI界面一次性绘制。
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
