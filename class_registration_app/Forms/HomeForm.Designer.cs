namespace ClassRegistrationApp
{
    partial class HomeForm
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
            this.btnGoRegister = new System.Windows.Forms.Button();
            this.btnViewRegistered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoRegister
            // 
            this.btnGoRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoRegister.Font = new System.Drawing.Font("Prompt Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnGoRegister.Location = new System.Drawing.Point(150, 140);
            this.btnGoRegister.Name = "btnGoRegister";
            this.btnGoRegister.Size = new System.Drawing.Size(350, 50);
            this.btnGoRegister.TabIndex = 0;
            this.btnGoRegister.Text = "GO REGISTER";
            this.btnGoRegister.UseVisualStyleBackColor = true;
            this.btnGoRegister.Click += new System.EventHandler(this.btnGoRegister_Click);
            // 
            // btnViewRegistered
            // 
            this.btnViewRegistered.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewRegistered.Font = new System.Drawing.Font("Prompt Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnViewRegistered.Location = new System.Drawing.Point(150, 210);
            this.btnViewRegistered.Name = "btnViewRegistered";
            this.btnViewRegistered.Size = new System.Drawing.Size(350, 50);
            this.btnViewRegistered.TabIndex = 1;
            this.btnViewRegistered.Text = "VIEW CLASS REGISTERED";
            this.btnViewRegistered.UseVisualStyleBackColor = true;
            this.btnViewRegistered.Click += new System.EventHandler(this.btnViewRegistered_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.btnViewRegistered);
            this.Controls.Add(this.btnGoRegister);
            this.Font = new System.Drawing.Font("Prompt", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Registration - Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoRegister;
        private System.Windows.Forms.Button btnViewRegistered;
    }
}

