namespace ClassRegistrationApp
{
    partial class ViewRegisteredForm
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
            this.btnHome = new System.Windows.Forms.Button();
            this.lblView = new System.Windows.Forms.Label();
            this.pnlRegistered = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegistered.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Prompt Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHome.Location = new System.Drawing.Point(10, 10);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(80, 30);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblView
            // 
            this.lblView.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblView.ForeColor = System.Drawing.Color.White;
            this.lblView.Location = new System.Drawing.Point(10, 50);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(612, 24);
            this.lblView.TabIndex = 5;
            this.lblView.Text = "VIEW CLASS REGISTERED";
            this.lblView.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlRegistered
            // 
            this.pnlRegistered.BackColor = System.Drawing.Color.DarkGray;
            this.pnlRegistered.Controls.Add(this.label1);
            this.pnlRegistered.Location = new System.Drawing.Point(10, 84);
            this.pnlRegistered.Name = "pnlRegistered";
            this.pnlRegistered.Size = new System.Drawing.Size(612, 315);
            this.pnlRegistered.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(609, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewRegisteredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pnlRegistered);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.btnHome);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewRegisteredForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Registration - View Registered";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewRegisteredForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewRegisteredForm_Load);
            this.pnlRegistered.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.FlowLayoutPanel pnlRegistered;
        private System.Windows.Forms.Label label1;
    }
}