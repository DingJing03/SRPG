using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Windows
{
    public partial class StartForm : Form
    {
        public ShowDataUtil showData;

        public Dictionary<string, string> tableList;

        public string currentTableName; //  当前选中的数据库表中文名

        public StartForm()
        {
            InitializeComponent();
            showData = new ShowDataUtil();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableList = showData.ShowTableObjects();
            this.tableListBox.ItemHeight = 80;
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
                currentTableName = this.tableListBox.Text;
                ShowTableObjects();
            }
        }

        private void ShowTableObjects()
        {
            string tableName = tableList[currentTableName];
            Dictionary<string, string> tableTitle = showData.FindTableTitle(tableName);
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
            List<List<string>> list = showData.FindTableObjects(tableName);
            foreach (List<string> data in list)
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

        public void SaveTableObject(Dictionary<string, string> tableObjects)
        {
            this.showData.AddTableObjects(tableObjects, tableList[currentTableName]);
            ShowTableObjects();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableObjectsForm objectsForm = new TableObjectsForm(this);
            objectsForm.Show();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.tableObjectsListView.SelectedItems != null && this.tableObjectsListView.SelectedItems.Count > 0)
            {
                string id = this.tableObjectsListView.SelectedItems[0].Text;
                Dictionary<string, string> tableObjects = showData.GetTableObjects(id, tableList[currentTableName]);
                TableObjectsForm objectsForm = new TableObjectsForm(this, tableObjects);
                objectsForm.Show();
            }
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.tableObjectsListView.SelectedItems != null && this.tableObjectsListView.SelectedItems.Count > 0)
            {
                string id = this.tableObjectsListView.SelectedItems[0].Text;
                DialogResult a = MessageBox.Show("确认删除选中项", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    showData.DelTableObjects(id, tableList[currentTableName]);
                    ShowTableObjects();
                }
            }
        }

        public Dictionary<string, string> FindTableName(string tableName)
        {
            return showData.FindTableName(tableName);
        }
    }
}
