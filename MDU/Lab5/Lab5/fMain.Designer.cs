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
            tbTabletInfo = new TextBox();
            btnAddTablet = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // tbTabletInfo
            // 
            tbTabletInfo.Location = new Point(12, 12);
            tbTabletInfo.Multiline = true;
            tbTabletInfo.Name = "tbTabletInfo";
            tbTabletInfo.ReadOnly = true;
            tbTabletInfo.Size = new Size(723, 419);
            tbTabletInfo.TabIndex = 0;
            // 
            // btnAddTablet
            // 
            btnAddTablet.Location = new Point(741, 12);
            btnAddTablet.Name = "btnAddTablet";
            btnAddTablet.Size = new Size(127, 29);
            btnAddTablet.TabIndex = 1;
            btnAddTablet.Text = "Додати місто";
            btnAddTablet.UseVisualStyleBackColor = true;
            btnAddTablet.Click += button1_Click;
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
            Controls.Add(btnAddTablet);
            Controls.Add(tbTabletInfo);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTabletInfo;
        private Button btnAddTablet;
        private Button btnClose;
    }
}