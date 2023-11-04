namespace Lab7
{
    public partial class fTablet : Form
    {
        public Tablet tablet;

        public fTablet(ref Tablet t)
        {
            tablet = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tablet.Name = tbName.Text.Trim();
            tablet.Cost = double.Parse(tbCost.Text.Trim());
            tablet.Installment = double.Parse(tbInstallment.Text.Trim());
            tablet.Size = double.Parse(tbSize.Text.Trim());
            tablet.Processor = tbProcessor.Text.Trim();
            tablet.FaceID = chbHasFaceID.Checked;
            tablet.Camera = tbCamera.Text.Trim();
            tablet.Connecteur = tbConnecteur.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fTablet_Load(object sender, EventArgs e)
        {
            if (tablet != null)
            {
                tbName.Text = tablet.Name;
                tbCost.Text = tablet.Cost.ToString("0.00");
                tbInstallment.Text = tablet.Installment.ToString("0.00");
                tbSize.Text = tablet.Size.ToString("0");
                tbProcessor.Text = tablet.Processor;
                chbHasFaceID.Checked = tablet.FaceID;
                tbCamera.Text = tablet.Camera;
                tbConnecteur.Text = tablet.Connecteur;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
