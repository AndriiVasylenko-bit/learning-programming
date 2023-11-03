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
            Tablet tablet = new Tablet();
            fTablet ft = new fTablet(tablet);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbTabletInfo.Text +=
                string.Format("• {0}, {1:0.00} hrn, {2:0.00} hrn. Size: {3}\". Processor: {4}. FaceID: {5}. Camera {6} Connecteur {7} | Number Payments: {8} months.\r\n",
                    tablet._name,
                    tablet._cost,
                    tablet._installment,
                    tablet._size,
                    tablet._processor,
                    tablet._faceID ? "Є" : "Немає",
                    tablet._сamera,
                    tablet._connecteur,
                    tablet.NumberPayments());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                "Припинити роботу", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}