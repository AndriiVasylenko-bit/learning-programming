namespace Lab7
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            toolStrip1 = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            tsSeparator1 = new ToolStripSeparator();
            btnDel = new ToolStripButton();
            btnClear = new ToolStripButton();
            tsSeparator2 = new ToolStripSeparator();
            btnExit = new ToolStripButton();
            bindSrcTowns = new BindingSource(components);
            gvTowns = new DataGridView();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcTowns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvTowns).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, tsSeparator1, btnDel, btnClear, tsSeparator2, btnExit });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 24);
            btnAdd.Text = "Додати запис про місто";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(29, 24);
            btnEdit.Text = "Редагувати запис";
            btnEdit.Click += btnEdit_Click;
            // 
            // tsSeparator1
            // 
            tsSeparator1.Name = "tsSeparator1";
            tsSeparator1.Size = new Size(6, 27);
            // 
            // btnDel
            // 
            btnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDel.Image = (Image)resources.GetObject("btnDel.Image");
            btnDel.ImageTransparentColor = Color.Magenta;
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(29, 24);
            btnDel.Text = "Видалити запис";
            btnDel.Click += btnDel_Click;
            // 
            // btnClear
            // 
            btnClear.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnClear.Image = (Image)resources.GetObject("btnClear.Image");
            btnClear.ImageTransparentColor = Color.Magenta;
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(29, 24);
            btnClear.Text = "Очистити дані";
            btnClear.Click += btnClear_Click;
            // 
            // tsSeparator2
            // 
            tsSeparator2.Name = "tsSeparator2";
            tsSeparator2.Size = new Size(6, 27);
            // 
            // btnExit
            // 
            btnExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 24);
            btnExit.Text = "Вийти з програми";
            btnExit.Click += btnExit_Click;
            // 
            // bindSrcTowns
            // 
            bindSrcTowns.CurrentChanged += bindSrcTowns_CurrentChanged;
            // 
            // gvTowns
            // 
            gvTowns.AllowUserToAddRows = false;
            gvTowns.AllowUserToDeleteRows = false;
            gvTowns.AutoGenerateColumns = false;
            gvTowns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvTowns.DataSource = bindSrcTowns;
            gvTowns.Dock = DockStyle.Fill;
            gvTowns.Location = new Point(0, 27);
            gvTowns.Name = "gvTowns";
            gvTowns.ReadOnly = true;
            gvTowns.RowHeadersWidth = 51;
            gvTowns.RowTemplate.Height = 29;
            gvTowns.Size = new Size(800, 423);
            gvTowns.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gvTowns);
            Controls.Add(toolStrip1);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №10";
            Load += Form1_Load;
            Resize += fMain_Resize;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindSrcTowns).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvTowns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDel;
        private ToolStripSeparator tsSeparator1;
        private ToolStripButton btnClear;
        private ToolStripSeparator tsSeparator2;
        private ToolStripButton btnExit;
        private DataGridView gvTowns;
        public BindingSource bindSrcTowns;
    }
}