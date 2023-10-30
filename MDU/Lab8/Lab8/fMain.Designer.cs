namespace Lab8
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
            pnMain = new Panel();
            pnTools = new Panel();
            btnLeftFar = new Button();
            btnRightFar = new Button();
            btnRight = new Button();
            btnLeft = new Button();
            btnCollapse = new Button();
            btnExpand = new Button();
            btnDown = new Button();
            btnUp = new Button();
            btnDownFar = new Button();
            btnUpFar = new Button();
            btnShow = new Button();
            btnHide = new Button();
            btnCreateNew = new Button();
            cbCircles = new ComboBox();
            label1 = new Label();
            pnTools.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = SystemColors.ControlLightLight;
            pnMain.BorderStyle = BorderStyle.FixedSingle;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(845, 715);
            pnMain.TabIndex = 0;
            // 
            // pnTools
            // 
            pnTools.Controls.Add(btnLeftFar);
            pnTools.Controls.Add(btnRightFar);
            pnTools.Controls.Add(btnRight);
            pnTools.Controls.Add(btnLeft);
            pnTools.Controls.Add(btnCollapse);
            pnTools.Controls.Add(btnExpand);
            pnTools.Controls.Add(btnDown);
            pnTools.Controls.Add(btnUp);
            pnTools.Controls.Add(btnDownFar);
            pnTools.Controls.Add(btnUpFar);
            pnTools.Controls.Add(btnShow);
            pnTools.Controls.Add(btnHide);
            pnTools.Controls.Add(btnCreateNew);
            pnTools.Controls.Add(cbCircles);
            pnTools.Controls.Add(label1);
            pnTools.Dock = DockStyle.Right;
            pnTools.Location = new Point(550, 0);
            pnTools.Name = "pnTools";
            pnTools.Size = new Size(295, 715);
            pnTools.TabIndex = 1;
            pnTools.Paint += pnTools_Paint;
            // 
            // btnLeftFar
            // 
            btnLeftFar.Location = new Point(17, 367);
            btnLeftFar.Name = "btnLeftFar";
            btnLeftFar.Size = new Size(30, 100);
            btnLeftFar.TabIndex = 14;
            btnLeftFar.Text = "⇇";
            btnLeftFar.UseVisualStyleBackColor = true;
            btnLeftFar.Click += btnLeftFar_Click;
            // 
            // btnRightFar
            // 
            btnRightFar.Location = new Point(251, 367);
            btnRightFar.Name = "btnRightFar";
            btnRightFar.Size = new Size(30, 100);
            btnRightFar.TabIndex = 13;
            btnRightFar.Text = "⇉";
            btnRightFar.UseVisualStyleBackColor = true;
            btnRightFar.Click += btnRightFar_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(205, 367);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(40, 100);
            btnRight.TabIndex = 12;
            btnRight.Text = "→";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(53, 367);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(40, 100);
            btnLeft.TabIndex = 11;
            btnLeft.Text = "←";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnCollapse
            // 
            btnCollapse.Location = new Point(99, 413);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new Size(100, 40);
            btnCollapse.TabIndex = 10;
            btnCollapse.Text = "-";
            btnCollapse.UseVisualStyleBackColor = true;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnExpand
            // 
            btnExpand.Location = new Point(99, 367);
            btnExpand.Name = "btnExpand";
            btnExpand.Size = new Size(100, 40);
            btnExpand.TabIndex = 9;
            btnExpand.Text = "+";
            btnExpand.UseVisualStyleBackColor = true;
            btnExpand.Click += btnExpand_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(99, 459);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(100, 40);
            btnDown.TabIndex = 8;
            btnDown.Text = "↓";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(99, 321);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(100, 40);
            btnUp.TabIndex = 7;
            btnUp.Text = "↑";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDownFar
            // 
            btnDownFar.Location = new Point(99, 505);
            btnDownFar.Name = "btnDownFar";
            btnDownFar.Size = new Size(100, 30);
            btnDownFar.TabIndex = 6;
            btnDownFar.Text = "⇊";
            btnDownFar.UseVisualStyleBackColor = true;
            btnDownFar.Click += btnDownFar_Click;
            // 
            // btnUpFar
            // 
            btnUpFar.Location = new Point(99, 285);
            btnUpFar.Name = "btnUpFar";
            btnUpFar.Size = new Size(100, 30);
            btnUpFar.TabIndex = 5;
            btnUpFar.Text = "⇈";
            btnUpFar.UseVisualStyleBackColor = true;
            btnUpFar.Click += btnUpFar_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(0, 199);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(310, 29);
            btnShow.TabIndex = 4;
            btnShow.Text = "Показати об'єкт";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(0, 164);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(310, 29);
            btnHide.TabIndex = 3;
            btnHide.Text = "Приховати об'єкт";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(0, 129);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(310, 29);
            btnCreateNew.TabIndex = 2;
            btnCreateNew.Text = "Створити новий об'єкт";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // cbCircles
            // 
            cbCircles.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Location = new Point(0, 67);
            cbCircles.Name = "cbCircles";
            cbCircles.Size = new Size(310, 28);
            cbCircles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 44);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Перелік Об'єктів";
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 715);
            Controls.Add(pnTools);
            Controls.Add(pnMain);
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №11";
            Load += fMain_Load;
            pnTools.ResumeLayout(false);
            pnTools.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnTools;
        private ComboBox cbCircles;
        private Label label1;
        private Button btnCreateNew;
        private Button btnHide;
        private Button btnShow;
        private Button btnDownFar;
        private Button btnUpFar;
        private Button btnExpand;
        private Button btnDown;
        private Button btnUp;
        private Button btnRight;
        private Button btnLeft;
        private Button btnCollapse;
        private Button btnLeftFar;
        private Button btnRightFar;
    }
}