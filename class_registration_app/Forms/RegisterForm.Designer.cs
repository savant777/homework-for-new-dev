namespace ClassRegistrationApp
{
    partial class RegisterForm
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
            this.pnlClasses = new System.Windows.Forms.FlowLayoutPanel();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlClasses
            // 
            this.pnlClasses.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlClasses.Location = new System.Drawing.Point(170, 84);
            this.pnlClasses.Name = "pnlClasses";
            this.pnlClasses.Size = new System.Drawing.Size(450, 316);
            this.pnlClasses.TabIndex = 0;
            // 
            // lstMonths
            // 
            this.lstMonths.BackColor = System.Drawing.Color.DarkGray;
            this.lstMonths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMonths.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lstMonths.ForeColor = System.Drawing.Color.White;
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.ItemHeight = 24;
            this.lstMonths.Location = new System.Drawing.Point(10, 84);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(150, 288);
            this.lstMonths.TabIndex = 1;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Prompt Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHome.Location = new System.Drawing.Point(10, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 30);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMonth.ForeColor = System.Drawing.Color.White;
            this.lblMonth.Location = new System.Drawing.Point(10, 50);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(151, 24);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "CHOOSE MONTH";
            // 
            // lblClass
            // 
            this.lblClass.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(167, 50);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(450, 24);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "CLASS NAME";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lstMonths);
            this.Controls.Add(this.pnlClasses);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Registration - Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlClasses;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblClass;
    }
}