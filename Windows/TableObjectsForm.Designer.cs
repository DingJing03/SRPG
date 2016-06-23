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
            this.datalistView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // datalistView
            // 
            this.datalistView.Location = new System.Drawing.Point(12, 12);
            this.datalistView.Name = "datalistView";
            this.datalistView.Size = new System.Drawing.Size(1133, 568);
            this.datalistView.TabIndex = 0;
            this.datalistView.UseCompatibleStateImageBehavior = false;
            this.datalistView.View = System.Windows.Forms.View.Details;
            // 
            // TableObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 592);
            this.Controls.Add(this.datalistView);
            this.Name = "TableObjectsForm";
            this.Text = "TableObjectsForm";
            this.Load += new System.EventHandler(this.TableObjectsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView datalistView;
    }
}