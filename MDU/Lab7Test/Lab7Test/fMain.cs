namespace Lab7Test
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvBikes.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "�����";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Country";
            column.Name = "�����";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Region";
            column.Name = "�����";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Population";
            column.Name = "���������";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "YearIncome";
            column.Name = "г��. �����";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Square";
            column.Name = "�����";
            column.Width = 80;
            gvBikes.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasPort";
            column.Name = "����";
            column.Width = 60;
            gvBikes.Columns.Add(column);
            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasAirport";
            column.Name = "��������";
            column.Width = 60;
            gvBikes.Columns.Add(column);
            bindSrcBikes.Add(new Bike("f", "f", "a ���.", 2,
            2040000, 4300, false, true));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        public void bindSrcBikes_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            fBike fbike = new fBike(ref bike);
            if (fbike.ShowDialog() == DialogResult.OK)
            {
                bindSrcBikes.Add(bike);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bike bike = (Bike)bindSrcBikes.List[bindSrcBikes.Position];
            fBike fbike = new fBike(ref bike);
            if (fbike.ShowDialog() == DialogResult.OK)
            {
                bindSrcBikes.List[bindSrcBikes.Position] = bike;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�������� �������� �����?",
                "��������� ������", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcBikes.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "�������� �������?\n\n�� ��� ������ �������",
                "�������� �����", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcBikes.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("������� ����������?", "����� � ��������",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}