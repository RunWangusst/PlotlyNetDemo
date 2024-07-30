namespace PlotlyNetDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            surfaceRowCol = new RowAndColumnControl();
            btn3DSurface = new Button();
            panel2 = new Panel();
            histRowCol = new RowAndColumnControl();
            btnHist = new Button();
            panel3 = new Panel();
            heatmapRowCol = new RowAndColumnControl();
            btnHeatmap = new Button();
            panel4 = new Panel();
            btnStackedBar = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1027, 655);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(surfaceRowCol);
            panel1.Controls.Add(btn3DSurface);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 330);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 322);
            panel1.TabIndex = 1;
            // 
            // surfaceRowCol
            // 
            surfaceRowCol.Columns = 100;
            surfaceRowCol.HasColumns = false;
            surfaceRowCol.Location = new Point(3, 3);
            surfaceRowCol.Name = "surfaceRowCol";
            surfaceRowCol.Rows = 100;
            surfaceRowCol.Size = new Size(132, 29);
            surfaceRowCol.TabIndex = 1;
            // 
            // btn3DSurface
            // 
            btn3DSurface.Location = new Point(141, 9);
            btn3DSurface.Name = "btn3DSurface";
            btn3DSurface.Size = new Size(114, 23);
            btn3DSurface.TabIndex = 0;
            btn3DSurface.Text = "3D surface";
            btn3DSurface.UseVisualStyleBackColor = true;
            btn3DSurface.Click += btn3DSurface_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(histRowCol);
            panel2.Controls.Add(btnHist);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 321);
            panel2.TabIndex = 3;
            // 
            // histRowCol
            // 
            histRowCol.Columns = 5;
            histRowCol.HasColumns = false;
            histRowCol.Location = new Point(9, 9);
            histRowCol.Name = "histRowCol";
            histRowCol.Rows = 5;
            histRowCol.Size = new Size(137, 29);
            histRowCol.TabIndex = 1;
            // 
            // btnHist
            // 
            btnHist.Location = new Point(152, 9);
            btnHist.Name = "btnHist";
            btnHist.Size = new Size(110, 23);
            btnHist.TabIndex = 0;
            btnHist.Text = "Histogram";
            btnHist.UseVisualStyleBackColor = true;
            btnHist.Click += btnHist_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(heatmapRowCol);
            panel3.Controls.Add(btnHeatmap);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(516, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(508, 321);
            panel3.TabIndex = 4;
            // 
            // heatmapRowCol
            // 
            heatmapRowCol.Columns = 5;
            heatmapRowCol.HasColumns = true;
            heatmapRowCol.Location = new Point(14, 8);
            heatmapRowCol.Name = "heatmapRowCol";
            heatmapRowCol.Rows = 5;
            heatmapRowCol.Size = new Size(278, 29);
            heatmapRowCol.TabIndex = 2;
            // 
            // btnHeatmap
            // 
            btnHeatmap.Location = new Point(314, 9);
            btnHeatmap.Name = "btnHeatmap";
            btnHeatmap.Size = new Size(100, 23);
            btnHeatmap.TabIndex = 0;
            btnHeatmap.Text = "Heatmap";
            btnHeatmap.UseVisualStyleBackColor = true;
            btnHeatmap.Click += btnHeatmap_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnStackedBar);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(516, 330);
            panel4.Name = "panel4";
            panel4.Size = new Size(508, 322);
            panel4.TabIndex = 5;
            // 
            // btnStackedBar
            // 
            btnStackedBar.Location = new Point(287, 9);
            btnStackedBar.Name = "btnStackedBar";
            btnStackedBar.Size = new Size(159, 23);
            btnStackedBar.TabIndex = 0;
            btnStackedBar.Text = "Stacked bar";
            btnStackedBar.UseVisualStyleBackColor = true;
            btnStackedBar.Click += btnStackedBar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 655);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_LoadAsync;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnHist;
        private Button btnHeatmap;
        private Button btnStackedBar;
        private Button btn3DSurface;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private RowAndColumnControl histRowCol;
        private RowAndColumnControl heatmapRowCol;
        private RowAndColumnControl surfaceRowCol;
    }
}
