namespace Lab5Bike
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
            tbBikeInfo = new TextBox();
            btnClose = new Button();
            btnAddBike = new Button();
            SuspendLayout();
            // 
            // tbBikeInfo
            // 
            tbBikeInfo.Location = new Point(12, 11);
            tbBikeInfo.Multiline = true;
            tbBikeInfo.Name = "tbBikeInfo";
            tbBikeInfo.ReadOnly = true;
            tbBikeInfo.Size = new Size(824, 426);
            tbBikeInfo.TabIndex = 0;
            tbBikeInfo.UseSystemPasswordChar = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(842, 411);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(59, 25);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnAddBike
            // 
            btnAddBike.Location = new Point(842, 11);
            btnAddBike.Name = "btnAddBike";
            btnAddBike.Size = new Size(59, 25);
            btnAddBike.TabIndex = 3;
            btnAddBike.Text = "Add";
            btnAddBike.UseVisualStyleBackColor = true;
            btnAddBike.Click += btnAddBike_Click;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 449);
            Controls.Add(btnClose);
            Controls.Add(btnAddBike);
            Controls.Add(tbBikeInfo);
            MaximizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info";
            Load += fMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBikeInfo;
        private Button btnClose;
        private Button btnAddBike;
    }
}