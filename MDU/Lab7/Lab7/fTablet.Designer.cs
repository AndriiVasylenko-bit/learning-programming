namespace Lab7
{
    partial class fTablet
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
            groupBox1 = new GroupBox();
            tbConnecteur = new TextBox();
            label7 = new Label();
            tbCamera = new TextBox();
            tbProcessor = new TextBox();
            tbSize = new TextBox();
            tbInstallment = new TextBox();
            tbCost = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chbHasFaceID = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbConnecteur);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbCamera);
            groupBox1.Controls.Add(tbProcessor);
            groupBox1.Controls.Add(tbSize);
            groupBox1.Controls.Add(tbInstallment);
            groupBox1.Controls.Add(tbCost);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Main";
            // 
            // tbConnecteur
            // 
            tbConnecteur.Location = new Point(200, 221);
            tbConnecteur.Name = "tbConnecteur";
            tbConnecteur.Size = new Size(125, 27);
            tbConnecteur.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 228);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 12;
            label7.Text = "Connecteur";
            // 
            // tbCamera
            // 
            tbCamera.Location = new Point(200, 188);
            tbCamera.Name = "tbCamera";
            tbCamera.Size = new Size(125, 27);
            tbCamera.TabIndex = 11;
            // 
            // tbProcessor
            // 
            tbProcessor.Location = new Point(200, 155);
            tbProcessor.Name = "tbProcessor";
            tbProcessor.Size = new Size(125, 27);
            tbProcessor.TabIndex = 10;
            // 
            // tbSize
            // 
            tbSize.Location = new Point(200, 122);
            tbSize.Name = "tbSize";
            tbSize.Size = new Size(125, 27);
            tbSize.TabIndex = 9;
            // 
            // tbInstallment
            // 
            tbInstallment.Location = new Point(200, 92);
            tbInstallment.Name = "tbInstallment";
            tbInstallment.Size = new Size(125, 27);
            tbInstallment.TabIndex = 8;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(200, 61);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(125, 27);
            tbCost.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(200, 28);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 195);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Camera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 162);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 4;
            label5.Text = "Processor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 129);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Size";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 2;
            label3.Text = "Installment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Cost";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbHasFaceID);
            groupBox2.Location = new Point(12, 291);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 71);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Secure";
            // 
            // chbHasFaceID
            // 
            chbHasFaceID.AutoSize = true;
            chbHasFaceID.Location = new Point(23, 31);
            chbHasFaceID.Name = "chbHasFaceID";
            chbHasFaceID.Size = new Size(75, 24);
            chbHasFaceID.TabIndex = 0;
            chbHasFaceID.Text = "FaceID";
            chbHasFaceID.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(356, 21);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 28);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(356, 55);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 28);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fTbalet
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(452, 377);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "fTbalet";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tablet data";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbCamera;
        private TextBox tbProcessor;
        private TextBox tbSize;
        private TextBox tbInstallment;
        private TextBox tbCost;
        private TextBox tbName;
        private GroupBox groupBox2;
        private CheckBox chbHasFaceID;
        private Button btnOk;
        private Button btnCancel;
        private TextBox tbConnecteur;
        private Label label7;
    }
}