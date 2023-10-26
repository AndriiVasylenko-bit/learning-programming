namespace Lab4
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
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            tbX = new TextBox();
            tbY = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            label4 = new Label();
            tbYE = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Змінна X1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Змінна X2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(170, 20);
            label3.TabIndex = 2;
            label3.Text = "Результат розрахунку Y";
            label3.Click += label3_Click;
            // 
            // tbX1
            // 
            tbX1.Location = new Point(12, 32);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(188, 27);
            tbX1.TabIndex = 3;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(12, 85);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(188, 27);
            tbX2.TabIndex = 4;
            tbX2.TextChanged += tbX2_TextChanged;
            // 
            // tbX
            // 
            tbX.Location = new Point(12, 244);
            tbX.Name = "tbX";
            tbX.ReadOnly = true;
            tbX.Size = new Size(188, 27);
            tbX.TabIndex = 9;
            tbX.TextChanged += tbX_TextChanged;
            // 
            // tbY
            // 
            tbY.Location = new Point(12, 138);
            tbY.Name = "tbY";
            tbY.ReadOnly = true;
            tbY.Size = new Size(188, 27);
            tbY.TabIndex = 5;
            tbY.TextChanged += tbY_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 289);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(105, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Обчислити";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 324);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(123, 289);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(70, 64);
            btnExit.TabIndex = 8;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 10;
            label4.Text = "більше із значень x1, x2";
            label4.Click += label4_Click;
            // 
            // tbYE
            // 
            tbYE.Location = new Point(12, 191);
            tbYE.Name = "tbYE";
            tbYE.ReadOnly = true;
            tbYE.Size = new Size(188, 27);
            tbYE.TabIndex = 12;
            tbYE.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(181, 20);
            label5.TabIndex = 11;
            label5.Text = "Експоненційний формат";
            label5.Click += label5_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(213, 366);
            Controls.Add(tbYE);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(tbY);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbX);
            Name = "fMain";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbX;
        private TextBox tbY;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label label4;
        private TextBox tbYE;
        private Label label5;
    }
}