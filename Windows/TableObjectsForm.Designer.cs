namespace Windows
{
    partial class TableObjectsForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.fieldGroupBox = new System.Windows.Forms.GroupBox();
            this.fieldTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fieldGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(279, 393);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 28);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fieldGroupBox
            // 
            this.fieldGroupBox.Controls.Add(this.fieldTableLayoutPanel);
            this.fieldGroupBox.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fieldGroupBox.Name = "fieldGroupBox";
            this.fieldGroupBox.Size = new System.Drawing.Size(350, 375);
            this.fieldGroupBox.TabIndex = 1;
            this.fieldGroupBox.TabStop = false;
            this.fieldGroupBox.Text = "属性";
            // 
            // fieldTableLayoutPanel
            // 
            this.fieldTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldTableLayoutPanel.AutoScroll = true;
            this.fieldTableLayoutPanel.AutoSize = true;
            this.fieldTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.fieldTableLayoutPanel.ColumnCount = 2;
            this.fieldTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.28834F));
            this.fieldTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.71165F));
            this.fieldTableLayoutPanel.Location = new System.Drawing.Point(6, 20);
            this.fieldTableLayoutPanel.Name = "fieldTableLayoutPanel";
            this.fieldTableLayoutPanel.RowCount = 2;
            this.fieldTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.627119F));
            this.fieldTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.37288F));
            this.fieldTableLayoutPanel.Size = new System.Drawing.Size(338, 349);
            this.fieldTableLayoutPanel.TabIndex = 0;
            // 
            // TableObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 433);
            this.Controls.Add(this.fieldGroupBox);
            this.Controls.Add(this.saveButton);
            this.Name = "TableObjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableObjectsForm";
            this.Load += new System.EventHandler(this.TableObjectsForm_Load);
            this.fieldGroupBox.ResumeLayout(false);
            this.fieldGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.GroupBox fieldGroupBox;
        private System.Windows.Forms.TableLayoutPanel fieldTableLayoutPanel;
    }
}