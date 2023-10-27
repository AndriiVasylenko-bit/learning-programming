using System.Drawing;
using System.Xml.Linq;

namespace Lab5Bike
{
    public partial class fMain : Form
    {

        public fMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void fMain_Load(object sender, EventArgs e)
        {
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();

            fBike fb = new fBike(bike);

            if (fb.ShowDialog() == DialogResult.OK)
            {
                tbBikeInfo.Text +=
                    string.Format("— {0}, Cost: {1:0.00} hrn, Installment: {2:0.00} hrn, diameter Wheels: {3:00}\", Sleeve Style: {4}, Plug Type: {5}, Material Frame: {6}, Type Brakes: {7}, Number Payments {8:0.0} month \r\n",
                    bike._name,
                    bike._cost,
                    bike._installment,
                    bike._diameterWheels,
                    bike._sleeveStyle,
                    bike._plugType,
                    bike._materialFrame,
                    bike._typeBrakes,
                    bike.NumberPayments());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to stop the application?",
                "Shut down", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}