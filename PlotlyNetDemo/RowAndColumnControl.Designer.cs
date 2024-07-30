namespace PlotlyNetDemo
{
    partial class RowAndColumnControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            txtRow = new TextBox();
            label2 = new Label();
            txtColumn = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txtRow);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtColumn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(278, 29);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 0;
            label1.Text = "Row:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRow
            // 
            txtRow.Location = new Point(54, 3);
            txtRow.Name = "txtRow";
            txtRow.Size = new Size(68, 23);
            txtRow.TabIndex = 1;
            txtRow.Text = "5";
            txtRow.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.Location = new Point(128, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 2;
            label2.Text = "Column:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtColumn
            // 
            txtColumn.Location = new Point(195, 3);
            txtColumn.Name = "txtColumn";
            txtColumn.Size = new Size(77, 23);
            txtColumn.TabIndex = 3;
            txtColumn.Text = "5";
            txtColumn.TextAlign = HorizontalAlignment.Right;
            // 
            // RowAndColumnControl
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "RowAndColumnControl";
            Size = new Size(278, 29);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private TextBox txtRow;
        private Label label2;
        private TextBox txtColumn;
    }
}
