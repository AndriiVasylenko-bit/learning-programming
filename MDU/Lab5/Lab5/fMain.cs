namespace Lab5
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

        private void button1_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            fTown ft = new fTown(town);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTownsInfo.Text +=
                string.Format("{0}, {1}, {2}. ���������: {3}. г���� �����: {4:0.00} ���. �����: {5:0.000} ��.��. [{6} | {7}] | г���� ����� �� ��������: {8:0.00}���\r\n",
                    town.Name,
                    town.Country,
                    town.Region,
                    town.Population,
                    town.YearIncome,
                    town.Square,
                    town.HasPort ? "� ����" : "���� �����",
                    town.HasAirport ? "� ��������" : "���� ���������",
                    town.GetYearIncomePerInhabitant());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("��������� ������ ����������?",
                "��������� ������", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}