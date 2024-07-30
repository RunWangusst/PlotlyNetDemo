using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlotlyNetDemo
{
    public partial class RowAndColumnControl : UserControl
    {
        public RowAndColumnControl()
        {
            InitializeComponent();
        }

        public int Rows
        {
            get
            {
                if (Int32.TryParse(this.txtRow.Text, out var row))
                {
                    return row;
                }
                else
                {
                    return 5;
                }
            }
            set
            {
                this.txtRow.Text = value.ToString();
            }
        }

        public int Columns
        {
            get
            {
                if (Int32.TryParse(this.txtColumn.Text, out var column))
                {
                    return column;
                }
                else
                {
                    return 5;
                }
            }
            set
            {
                this.txtColumn.Text = value.ToString();
            }
        }

        public bool HasColumns
        {
            get { return this.txtColumn.Visible; }
            set
            {
                this.txtColumn.Visible = value;
                this.label2.Visible = value;
            }
        }
    }
}