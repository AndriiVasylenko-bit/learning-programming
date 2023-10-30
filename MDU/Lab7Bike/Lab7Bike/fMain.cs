namespace Lab7Bike
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvBikes.AutoGenerateColumns = false;
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Name";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Cost";
            column.Name = "Cost";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Installment";
            column.Name = "Installment";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "DiameterWheels";
            column.Name = "Diameter Wheels";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SleeveStyle";
            column.Name = "Sleeve Style";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "PlugType";
            column.Name = "Plug Type";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "MaterialFrame";
            column.Name = "Material Frame";
            gvBikes.Columns.Add(column);
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "TypeBrakes";
            column.Name = "Type Brakes";
            gvBikes.Columns.Add(column);
            bindSrcBike.Add(new Bike("Kinetic 29\" CRYSTAL 2023", 17238, 2463, 29,
            "Касета", "Пружина еластична", "Алюміній", "Дискові"));
            bindSrcBike.Add(new Bike("Kinetic 29\" CRYSTAL 2023", 17238, 2463, 29,
            "Касета", "Пружина еластична", "Алюміній", "Дискові"));
            bindSrcBike.Add(new Bike("Kinetic 29\" CRYSTAL 2023", 17238, 2463, 29,
            "Касета", "Пружина еластична", "Алюміній", "Дискові"));

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            fBike fbike = new fBike(ref bike);
            if (fbike.ShowDialog() == DialogResult.OK)
            {
                bindSrcBike.Add(bike);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Bike bike = (Bike)bindSrcBike.List[bindSrcBike.Position];
            fBike fbike = new fBike(ref bike);
            if (fbike.ShowDialog() == DialogResult.OK)
            {
                bindSrcBike.List[bindSrcBike.Position] = bike;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?",
                "Видалення запису", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcBike.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcBike.Clear();
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

        private void gvBikes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindSrcBike_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}