namespace Lab5Bike
{
    partial class fBike
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            tbName = new TextBox();
            tbCost = new TextBox();
            tbInstallment = new TextBox();
            tbDiameterWheels = new TextBox();
            tbSleeveStyle = new TextBox();
            tbPlugType = new TextBox();
            tbMaterialFrame = new TextBox();
            tbTypeBrakes = new TextBox();
            groupBox2 = new GroupBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 62);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 94);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Installment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 33);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 3;
            label4.Text = "Diameter Wheels";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 62);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Sleeve Style";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 95);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 5;
            label6.Text = "Plug Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 128);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 6;
            label7.Text = "Material Frame";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 161);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 7;
            label8.Text = "Type Brakes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(tbCost);
            groupBox1.Controls.Add(tbInstallment);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 127);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "First";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tbName
            // 
            tbName.Location = new Point(168, 22);
            tbName.Name = "tbName";
            tbName.Size = new Size(170, 27);
            tbName.TabIndex = 9;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(168, 55);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(170, 27);
            tbCost.TabIndex = 10;
            // 
            // tbInstallment
            // 
            tbInstallment.Location = new Point(168, 87);
            tbInstallment.Name = "tbInstallment";
            tbInstallment.Size = new Size(170, 27);
            tbInstallment.TabIndex = 11;
            // 
            // tbDiameterWheels
            // 
            tbDiameterWheels.Location = new Point(168, 26);
            tbDiameterWheels.Name = "tbDiameterWheels";
            tbDiameterWheels.Size = new Size(170, 27);
            tbDiameterWheels.TabIndex = 12;
            // 
            // tbSleeveStyle
            // 
            tbSleeveStyle.Location = new Point(168, 59);
            tbSleeveStyle.Name = "tbSleeveStyle";
            tbSleeveStyle.Size = new Size(170, 27);
            tbSleeveStyle.TabIndex = 13;
            // 
            // tbPlugType
            // 
            tbPlugType.Location = new Point(168, 92);
            tbPlugType.Name = "tbPlugType";
            tbPlugType.Size = new Size(170, 27);
            tbPlugType.TabIndex = 14;
            // 
            // tbMaterialFrame
            // 
            tbMaterialFrame.Location = new Point(168, 125);
            tbMaterialFrame.Name = "tbMaterialFrame";
            tbMaterialFrame.Size = new Size(170, 27);
            tbMaterialFrame.TabIndex = 15;
            // 
            // tbTypeBrakes
            // 
            tbTypeBrakes.Location = new Point(168, 158);
            tbTypeBrakes.Name = "tbTypeBrakes";
            tbTypeBrakes.Size = new Size(170, 27);
            tbTypeBrakes.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbTypeBrakes);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(tbMaterialFrame);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbPlugType);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tbSleeveStyle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tbDiameterWheels);
            groupBox2.Location = new Point(12, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 193);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Second";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(362, 12);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(87, 27);
            btnOk.TabIndex = 13;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(362, 45);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 27);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fBike
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(453, 351);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "fBike";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data from to new Bike";
            Load += fBike_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox groupBox1;
        private TextBox tbName;
        private TextBox tbCost;
        private TextBox tbInstallment;
        private TextBox tbDiameterWheels;
        private TextBox tbSleeveStyle;
        private TextBox tbPlugType;
        private TextBox tbMaterialFrame;
        private TextBox tbTypeBrakes;
        private GroupBox groupBox2;
        private Button btnOk;
        private Button btnCancel;
    }
}