namespace Lab7
{
    partial class fTown
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
            tbSquare = new TextBox();
            tbYearIncome = new TextBox();
            tbPopulation = new TextBox();
            tbRegion = new TextBox();
            tbCountry = new TextBox();
            tbName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            chbHasAirport = new CheckBox();
            chbHasPort = new CheckBox();
            btnOk = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbSquare);
            groupBox1.Controls.Add(tbYearIncome);
            groupBox1.Controls.Add(tbPopulation);
            groupBox1.Controls.Add(tbRegion);
            groupBox1.Controls.Add(tbCountry);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 225);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Загальні дані";
            // 
            // tbSquare
            // 
            tbSquare.Location = new Point(200, 188);
            tbSquare.Name = "tbSquare";
            tbSquare.Size = new Size(125, 27);
            tbSquare.TabIndex = 11;
            // 
            // tbYearIncome
            // 
            tbYearIncome.Location = new Point(200, 155);
            tbYearIncome.Name = "tbYearIncome";
            tbYearIncome.Size = new Size(125, 27);
            tbYearIncome.TabIndex = 10;
            // 
            // tbPopulation
            // 
            tbPopulation.Location = new Point(200, 122);
            tbPopulation.Name = "tbPopulation";
            tbPopulation.Size = new Size(125, 27);
            tbPopulation.TabIndex = 9;
            // 
            // tbRegion
            // 
            tbRegion.Location = new Point(200, 92);
            tbRegion.Name = "tbRegion";
            tbRegion.Size = new Size(125, 27);
            tbRegion.TabIndex = 8;
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(200, 61);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(125, 27);
            tbCountry.TabIndex = 7;
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
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Полщя, кв. км";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 162);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 4;
            label5.Text = "Річний дохід, грн";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 129);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 3;
            label4.Text = "Кількість мешканців";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 99);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Регіон";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 68);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Країна";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 0;
            label1.Text = "Назва міста";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chbHasAirport);
            groupBox2.Controls.Add(chbHasPort);
            groupBox2.Location = new Point(12, 260);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 102);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Транспорт";
            // 
            // chbHasAirport
            // 
            chbHasAirport.AutoSize = true;
            chbHasAirport.Location = new Point(23, 61);
            chbHasAirport.Name = "chbHasAirport";
            chbHasAirport.Size = new Size(171, 24);
            chbHasAirport.TabIndex = 1;
            chbHasAirport.Text = "Місто має аеропорт";
            chbHasAirport.UseVisualStyleBackColor = true;
            // 
            // chbHasPort
            // 
            chbHasPort.AutoSize = true;
            chbHasPort.Location = new Point(23, 31);
            chbHasPort.Name = "chbHasPort";
            chbHasPort.Size = new Size(137, 24);
            chbHasPort.TabIndex = 0;
            chbHasPort.Text = "Місто має порт";
            chbHasPort.UseVisualStyleBackColor = true;
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
            // fTown
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
            Name = "fTown";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Дані про нове місто";
            Load += fTown_Load;
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
        private TextBox tbSquare;
        private TextBox tbYearIncome;
        private TextBox tbPopulation;
        private TextBox tbRegion;
        private TextBox tbCountry;
        private TextBox tbName;
        private GroupBox groupBox2;
        private CheckBox chbHasAirport;
        private CheckBox chbHasPort;
        private Button btnOk;
        private Button btnCancel;
    }
}