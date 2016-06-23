using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class TableObjectsForm : Form
    {
        public TableObjectsForm(StartForm parent)
        {
            InitializeComponent();
            ShowTableObjects();
        }

        private void TableObjectsForm_Load(object sender, EventArgs e)
        {
            ShowTableObjects();
        }

        private void ShowTableObjects()
        {
            this.datalistView.Columns.Add("列标题1", 120, HorizontalAlignment.Left);
            this.datalistView.Columns.Add("列标题2", 120, HorizontalAlignment.Left);
            this.datalistView.Columns.Add("列标题3", 120, HorizontalAlignment.Left);
            #region 添加数据
            this.datalistView.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            for (int i = 0; i < 10; i++)   //添加10行数据 
            {
                ListViewItem lvi = new ListViewItem();
                //lvi.ImageIndex = i;     //通过与imageList绑定，显示imageList中第i项图标 
                lvi.Text = "subitem" + i;
                lvi.SubItems.Add("第2列,第" + i + "行");
                lvi.SubItems.Add("第3列,第" + i + "行");
                lvi.SubItems.Add("第4列,第" + i + "行");
                this.datalistView.Items.Add(lvi);
            }
            this.datalistView.EndUpdate();  //结束数据处理，UI界面一次性绘制。
            #endregion
        }
    }
}
