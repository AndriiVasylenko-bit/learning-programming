namespace Lab6
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Перетворення текстових рядків, які ввів користувач,
            // у змінні числового типу
            double x1min = double.Parse(tbx1min.Text);
            double x1max = double.Parse(tbx1max.Text);
            double x2min = double.Parse(tbx2min.Text);
            double x2max = double.Parse(tbx2max.Text);
            double dx1 = double.Parse(tbdx1.Text);
            double dx2 = double.Parse(tbdx2.Text);
            // Обчислення кількості рядків та стовпчиків таблиці

            gv.ColumnCount = (int)Math.Truncate((x2max - x2min) / dx2) + 2;
            int valueCC = gv.ColumnCount - 1;
            gv.RowCount = (int)Math.Truncate((x1max - x1min) / dx1) + 2;
            int valueRC = gv.RowCount - 1;
            // Вивід заголовків рядків та стовпців таблиці
            for (int i = 0; i < valueRC; i++)
                gv.Rows[i].HeaderCell.Value = (x1min + i * dx1).ToString("0.000");
            gv.RowHeadersWidth = 80;
            gv.Rows[valueRC].HeaderCell.Value = "Sum";
            for (int i = 0; i < valueCC; i++)
            {
                gv.Columns[i].HeaderCell.Value = (x2min + i *
                dx2).ToString("0.000");
                gv.Columns[i].Width = 60;
            }
            gv.Columns[valueCC].HeaderCell.Value = "Sum";
            gv.Columns[valueCC].Width = 60;
            // Для автоматичного підлаштування розмірів стовпчиків та рядків
            // можна використовувати ці методи
            //gv.AutoResizeColumns();
            //gv.AutoResizeRows();
            int cl, rw;
            double x1, x2, y, sumY = 0, sum = 0, zero;
            // Розрахунок і вивід результатів
            for (x1 = x1min, rw = 0; x1 <= x1max; rw++, x1 += dx1)
            {
                for (x2 = x2min, cl = 0; x2 <= x2max; cl++, x2 += dx2)
                {
                    zero = Math.Pow((x1 + 53 * x2), 2) != 0 ? Math.Pow((x1 + 53 * x2), 2) : 1;
                    y = Math.Pow(Math.Sin(x1 * (x2 / zero)), 2);
                    if (y < 0) sumY += y;
                    gv.Rows[rw].Cells[cl].Value = y.ToString();
                    sum += y;
                }
                gv.Rows[rw].Cells[valueCC].Value = sum.ToString();
                sum = 0;
            }
            tbSumY.Text = sumY.ToString();

            for (cl = 0; cl < valueCC; cl++)
            {
                for (rw = 0; rw < valueRC; rw++)
                {
                    sum += double.Parse((string)gv.Rows[rw].Cells[cl].Value);
                }
                gv.Rows[valueRC].Cells[cl].Value = sum.ToString();
                sum = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbx1min.Text = "";
            tbx1max.Text = "";
            tbx2min.Text = "";
            tbx2max.Text = "";
            tbdx1.Text = "";
            tbdx2.Text = "";
            gv.Rows.Clear();
            for (int Cl = 0; Cl < gv.ColumnCount; Cl++)
                gv.Columns[Cl].HeaderCell.Value = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити програму?", "Вихід з програми",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
                Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbSumY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}