using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Windows
{
    public partial class TableObjectsForm : Form
    {

        StartForm parent;

        Dictionary<string, object> fields = new Dictionary<string, object>();

        Dictionary<string, string> tableObjects;

        Dictionary<string, Dictionary<string, string>> comboTableObjects = new Dictionary<string, Dictionary<string, string>>();

        public TableObjectsForm(StartForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.Text = parent.currentTableName;
        }

        public TableObjectsForm(StartForm parent, Dictionary<string, string> tableObjects)
        {
            InitializeComponent();
            this.parent = parent;
            this.Text = parent.currentTableName;
            this.tableObjects = tableObjects;
        }

        private void TableObjectsForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> tableTitle = parent.showData.FindTableTitle(parent.tableList[parent.currentTableName]);

            this.fieldTableLayoutPanel.ColumnStyles.Clear();
            this.fieldTableLayoutPanel.RowStyles.Clear();
            this.fieldTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.fieldTableLayoutPanel.RowCount = tableTitle.Count;
            this.fieldTableLayoutPanel.ColumnCount = 2;
            this.fieldTableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
            this.fieldTableLayoutPanel.Dock = DockStyle.Fill;
            foreach (var item in tableTitle)
            {
                if (item.Key.Equals("Id"))
                {
                    continue;
                }
                this.fieldTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize, 60));
                Label lab = new Label();
                lab.Text = item.Value + "：";
                lab.AutoSize = true;
                lab.TextAlign = ContentAlignment.TopLeft;
                lab.Dock = DockStyle.Fill;
                lab.Margin = new Padding(3, 10, 3, 3);
                this.fieldTableLayoutPanel.Controls.Add(lab);
                if (item.Key.Contains("_"))
                {
                    ComboBox comboBox = new ComboBox();
                    Dictionary<string, string> tableNames = this.parent.FindTableName(Regex.Split(item.Key, "_")[0]);
                    comboTableObjects.Add(item.Key, tableNames);
                    foreach (var v in tableNames)
                    {
                        comboBox.Items.Add(v.Key);
                    }
                    fields.Add(item.Key, comboBox);
                    this.fieldTableLayoutPanel.Controls.Add(comboBox);
                }
                else
                {
                    TextBox textBox = new TextBox();
                    textBox.AutoSize = true;
                    textBox.Dock = DockStyle.Fill;
                    textBox.Margin = new Padding(3, 5, 3, 3);
                    fields.Add(item.Key, textBox);
                    this.fieldTableLayoutPanel.Controls.Add(textBox);
                }
            }
            if(this.tableObjects != null)
            {
                foreach(var item in fields)
                {
                    if (item.Key.Contains("_"))
                    {
                        ((ComboBox)item.Value).Text = this.tableObjects[item.Key];
                    }
                    else
                    {
                        ((TextBox)item.Value).Text = this.tableObjects[item.Key];
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> tableObjects = new Dictionary<string, string>();
            foreach(var item in fields)
            {
                string value = item.Key.Contains("_") ? ((ComboBox)item.Value).Text : ((TextBox)item.Value).Text;
                if (value.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("不能为空");
                    return;
                }
                if (item.Key.Contains("_"))
                {
                    value = comboTableObjects[item.Key][value];
                }
                tableObjects.Add(item.Key, value);
            }
            if(this.tableObjects != null)
            {
                tableObjects.Add("Id", this.tableObjects["Id"]);
            }
            this.parent.SaveTableObject(tableObjects);
            this.Close();
        }

       
    }
}
