using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7Bike
{
    public partial class fBike : Form
    {
        public Bike _bike;

        public fBike(ref Bike bike)
        {
            _bike = bike;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            _bike._name = tbName.Text.Trim();
            _bike._cost = double.Parse(tbCost.Text.Trim());
            _bike._installment = double.Parse(tbInstallment.Text.Trim());
            _bike._diameterWheels = int.Parse(tbDiameterWheels.Text.Trim());
            _bike._sleeveStyle = tbSleeveStyle.Text.Trim();
            _bike._plugType = tbPlugType.Text.Trim();
            _bike._materialFrame = tbMaterialFrame.Text.Trim();
            _bike._typeBrakes = tbTypeBrakes.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fBike_Load(object sender, EventArgs e)
        {
            if (_bike != null)
            {
                tbName.Text = _bike._name;
                tbCost.Text = _bike._cost.ToString("0.00");
                tbInstallment.Text = _bike._installment.ToString("0.00");
                tbDiameterWheels.Text = _bike._diameterWheels.ToString("0");
                tbSleeveStyle.Text = _bike._sleeveStyle;
                tbPlugType.Text = _bike._plugType;
                tbMaterialFrame.Text = _bike._materialFrame;
                tbTypeBrakes.Text = _bike._typeBrakes;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
