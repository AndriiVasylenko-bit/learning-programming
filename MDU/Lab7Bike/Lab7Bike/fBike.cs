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
            _bike.Name = tbName.Text.Trim();
            _bike.Cost = double.Parse(tbCost.Text.Trim());
            _bike.Installment = double.Parse(tbInstallment.Text.Trim());
            _bike.DiameterWheels = int.Parse(tbDiameterWheels.Text.Trim());
            _bike.SleeveStyle = tbSleeveStyle.Text.Trim();
            _bike.PlugType = tbPlugType.Text.Trim();
            _bike.MaterialFrame = tbMaterialFrame.Text.Trim();
            _bike.TypeBrakes = tbTypeBrakes.Text.Trim();
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
                tbName.Text = _bike.Name;
                tbCost.Text = _bike.Cost.ToString("0.00");
                tbInstallment.Text = _bike.Installment.ToString("0.00");
                tbDiameterWheels.Text = _bike.DiameterWheels.ToString("0");
                tbSleeveStyle.Text = _bike.SleeveStyle;
                tbPlugType.Text = _bike.PlugType;
                tbMaterialFrame.Text = _bike.MaterialFrame;
                tbTypeBrakes.Text = _bike.TypeBrakes;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
