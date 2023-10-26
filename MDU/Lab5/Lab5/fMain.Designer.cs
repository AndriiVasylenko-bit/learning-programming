namespace Lab5
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
            tbTownsInfo = new TextBox();
            btnAddTown = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbTownsInfo
            // 
            tbTownsInfo.Location = new Point(12, 12);
            tbTownsInfo.Multiline = true;
            tbTownsInfo.Name = "tbTownsInfo";
            tbTownsInfo.ReadOnly = true;
            tbTownsInfo.Size = new Size(723, 419);
            tbTownsInfo.TabIndex = 0;
            // 
            // btnAddTown
            // 
            btnAddTown.Location = new Point(741, 12);
            btnAddTown.Name = "btnAddTown";
            btnAddTown.Size = new Size(127, 29);
            btnAddTown.TabIndex = 1;
            btnAddTown.Text = "Додати місто";
            btnAddTown.UseVisualStyleBackColor = true;
            btnAddTown.Click += button1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(741, 402);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(127, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрити";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 444);
            Controls.Add(btnClose);
            Controls.Add(btnAddTown);
            Controls.Add(tbTownsInfo);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №8";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTownsInfo;
        private Button btnAddTown;
        private Button btnClose;
    }
}