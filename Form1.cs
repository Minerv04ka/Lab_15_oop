namespace Lab_15
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            double x1_min = double.Parse(tbX1min.Text);
            double x2_min = double.Parse(tbX2min.Text);
            double x1_max = double.Parse(tbX1max.Text);
            double x2_max = double.Parse(tbX2max.Text);
            double dx1 = double.Parse(tbDx1.Text);
            double dx2 = double.Parse(tbDx2.Text);

            gv.ColumnCount = (int)Math.Truncate((x2_max - x2_min) / dx2) + 2;
            gv.RowCount = (int)Math.Truncate((x1_max - x1_min) / dx1) + 2;

            for (int i = 0; i < gv.RowCount - 1; i++)
            {
                gv.Rows[i].HeaderCell.Value = (x1_min + i * dx1).ToString("0.000");
                gv.RowHeadersWidth = 80;
            }

            for (int i = 0; i < gv.ColumnCount - 1; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2_min + i * dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }
            gv.Columns[gv.ColumnCount - 1].Width = 60;

            int col, row = 0, row_c;
            double x1 = x1_min, x2, y;
            double row_av;
            double[] col_av = new double[gv.ColumnCount]; 
            while (x1 <= x1_max)
            {
                x2 = x2_min;
                col = 0;
                row_av = 0;
                row_c = 0;
                while (x2 <= x2_max)
                {
                    y = x1 + x2;
                    gv.Rows[row].Cells[col].Value = y.ToString("0.000");
                    x2 += dx2;
                    row_av += y;
                    col_av[col] += y;
                    row_c += 1;
                    col++;
                }
                gv.Rows[row].Cells[col].Value = (row_av / row_c).ToString("0.000");
                
                x1 += dx1;
                row++;
            }
            double av;
            for (int i = 0; i <= col_av.Length - 1; i++)
            {
                av = col_av[i] / (gv.RowCount - 1);
                gv.Rows[gv.RowCount - 1].Cells[i].Value = av.ToString("0.000");
            }
            gv.Rows[gv.RowCount - 1].Cells[gv.ColumnCount - 1].Value = "";
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            tbX1min.Text = "";
            tbX2min.Text = "";
            tbX1max.Text = "";
            tbX2max.Text = "";
            tbDx1.Text = "";
            tbDx2.Text = "";
            gv.Rows.Clear();
            for (int Col = 0; Col < gv.ColumnCount; Col++)
            {
                gv.Columns[Col].HeaderCell.Value = "";
            }
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
