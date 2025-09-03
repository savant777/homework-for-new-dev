namespace ClassRegistrationApp
{
    partial class ClassDetailForm
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
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.lblClassDescription = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // picPoster
            // 
            this.picPoster.Location = new System.Drawing.Point(10, 50);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(250, 349);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Prompt Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 30);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(270, 50);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(119, 24);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "CLASS NAME";
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtClassName.Location = new System.Drawing.Point(270, 84);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.ReadOnly = true;
            this.txtClassName.Size = new System.Drawing.Size(350, 30);
            this.txtClassName.TabIndex = 5;
            this.txtClassName.TabStop = false;
            // 
            // txtClassDescription
            // 
            this.txtClassDescription.Font = new System.Drawing.Font("Prompt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtClassDescription.Location = new System.Drawing.Point(270, 168);
            this.txtClassDescription.Multiline = true;
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.ReadOnly = true;
            this.txtClassDescription.Size = new System.Drawing.Size(350, 181);
            this.txtClassDescription.TabIndex = 7;
            this.txtClassDescription.TabStop = false;
            // 
            // lblClassDescription
            // 
            this.lblClassDescription.AutoSize = true;
            this.lblClassDescription.Font = new System.Drawing.Font("Prompt Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblClassDescription.ForeColor = System.Drawing.Color.White;
            this.lblClassDescription.Location = new System.Drawing.Point(270, 134);
            this.lblClassDescription.Name = "lblClassDescription";
            this.lblClassDescription.Size = new System.Drawing.Size(119, 24);
            this.lblClassDescription.TabIndex = 6;
            this.lblClassDescription.Text = "CLASS NAME";
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Prompt Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRegister.Location = new System.Drawing.Point(522, 369);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // ClassDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtClassDescription);
            this.Controls.Add(this.lblClassDescription);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picPoster);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Registration - Class Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassDetailForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassDescription;
        private System.Windows.Forms.Label lblClassDescription;
        private System.Windows.Forms.Button btnRegister;
    }
}