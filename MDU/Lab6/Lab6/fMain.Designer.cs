namespace Lab6
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbx1min = new TextBox();
            tbx2min = new TextBox();
            tbx1max = new TextBox();
            tbx2max = new TextBox();
            tbdx1 = new TextBox();
            tbdx2 = new TextBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnExit = new Button();
            gv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "X1min";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 55);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "X2min";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 21);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "X1max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(224, 55);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "X2max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(433, 21);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 4;
            label5.Text = "dX1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(433, 55);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 5;
            label6.Text = "dX2";
            // 
            // tbx1min
            // 
            tbx1min.Location = new Point(79, 18);
            tbx1min.Name = "tbx1min";
            tbx1min.Size = new Size(125, 27);
            tbx1min.TabIndex = 6;
            // 
            // tbx2min
            // 
            tbx2min.Location = new Point(77, 52);
            tbx2min.Name = "tbx2min";
            tbx2min.Size = new Size(125, 27);
            tbx2min.TabIndex = 7;
            // 
            // tbx1max
            // 
            tbx1max.Location = new Point(280, 18);
            tbx1max.Name = "tbx1max";
            tbx1max.Size = new Size(125, 27);
            tbx1max.TabIndex = 8;
            // 
            // tbx2max
            // 
            tbx2max.Location = new Point(280, 52);
            tbx2max.Name = "tbx2max";
            tbx2max.Size = new Size(125, 27);
            tbx2max.TabIndex = 9;
            // 
            // tbdx1
            // 
            tbdx1.Location = new Point(489, 18);
            tbdx1.Name = "tbdx1";
            tbdx1.Size = new Size(125, 27);
            tbdx1.TabIndex = 10;
            // 
            // tbdx2
            // 
            tbdx2.Location = new Point(489, 52);
            tbdx2.Name = "tbdx2";
            tbdx2.Size = new Size(125, 27);
            tbdx2.TabIndex = 11;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(637, 96);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 12;
            btnCalc.Text = "Розрахувати";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(637, 146);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Витерти";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(637, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Вийти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // gv
            // 
            gv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv.Location = new Point(23, 96);
            gv.Name = "gv";
            gv.RowHeadersWidth = 51;
            gv.RowTemplate.Height = 29;
            gv.Size = new Size(593, 320);
            gv.TabIndex = 15;
            gv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 440);
            Controls.Add(gv);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(tbdx2);
            Controls.Add(tbdx1);
            Controls.Add(tbx2max);
            Controls.Add(tbx1max);
            Controls.Add(tbx2min);
            Controls.Add(tbx1min);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fMain";
            Text = "fMain";
            Load += fMain_Load;
            ((System.ComponentModel.ISupportInitialize)gv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx1min;
        private TextBox tbx2min;
        private TextBox tbx1max;
        private TextBox tbx2max;
        private TextBox tbdx1;
        private TextBox tbdx2;
        private Button btnCalc;
        private Button btnClear;
        private Button btnExit;
        private DataGridView gv;
    }
}