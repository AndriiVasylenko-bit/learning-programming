namespace Lab7
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Name";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Cost";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Installment";
            column.Name = "Installment";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Size";
            column.Name = "Size";
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Processor";
            gvTowns.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "FaceID";
            column.Name = "FaceID";
            column.Width = 80;
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Camera";
            column.Name = "Camera";
            column.Width = 60;
            gvTowns.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Connecteur";
            column.Name = "Connecteur";
            column.Width = 60;
            gvTowns.Columns.Add(column);
            bindSrcTablet.Add(new Tablet("iPad mini", 18058, 3400, 8.3,
            "A15 Bionic chip", false, "12MP Wide camera", "USB‑C connector"));


            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        public void bindSrcTowns_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tablet tablet = new Tablet();
            fTablet ft = new fTablet(ref tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTablet.Add(tablet);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Tablet tablet = (Tablet)bindSrcTablet.List[bindSrcTablet.Position];
            fTablet ft = new fTablet(ref tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTablet.List[bindSrcTablet.Position] = tablet;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
                "Видалення запису", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTablet.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTablet.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}