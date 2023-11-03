namespace Lab5
{
    public partial class fTablet : Form
    {
        public Tablet TheTablet;

        public fTablet(Tablet t)
        {
            TheTablet = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheTablet._name = tbName.Text.Trim();
            TheTablet._cost = double.Parse(tbCost.Text.Trim());
            TheTablet._installment = double.Parse(tbInstallment.Text.Trim());
            TheTablet._size = double.Parse(tbSize.Text.Trim());
            TheTablet._processor = tbProcessor.Text.Trim();
            TheTablet._faceID = chbHasFaceID.Checked;
            TheTablet._сamera = tbCamera.Text.Trim();
            TheTablet._connecteur = tbConnecteur.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTablet_Load(object sender, EventArgs e)
        {
            if (TheTablet != null)
            {
                tbName.Text = TheTablet._name;
                tbCost.Text = TheTablet._cost.ToString("0.00");
                tbInstallment.Text = TheTablet._installment.ToString("0.00");
                tbSize.Text = TheTablet._size.ToString("0");
                tbProcessor.Text = TheTablet._processor;
                chbHasFaceID.Checked = TheTablet._faceID;
                tbCamera.Text = TheTablet._сamera;
                tbConnecteur.Text = TheTablet._connecteur;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
