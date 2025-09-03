using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegistrationApp
{
    public partial class ViewRegisteredForm : Form
    {
        private Form previousForm;

        public ViewRegisteredForm(Form prev)
        {
            InitializeComponent();
            previousForm = prev;
        }

        private void ViewRegisteredForm_Load(object sender, EventArgs e)
        {
            LoadRegisteredClasses();
        }

        private void LoadRegisteredClasses()
        {
            pnlRegistered.Controls.Clear();

            DataTable dt = DBHelper.GetRegisteredClasses();

            foreach (DataRow row in dt.Rows)
            {
                int classId = Convert.ToInt32(row["ClassID"]);
                string className = row["ClassName"].ToString();

                Label lbl = new Label();
                lbl.Text = className;
                lbl.Font = new Font("Prompt", 12, FontStyle.Regular);
                lbl.ForeColor = Color.White;
                lbl.AutoSize = false;
                lbl.Size = new Size(500, 40);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Padding = new Padding(10);

                Button btnCancel = new Button();
                btnCancel.Text = "Cancel";
                btnCancel.BackColor = Color.FromArgb(245, 50, 50);
                btnCancel.ForeColor = Color.Black;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnCancel.FlatAppearance.BorderSize = 0;
                btnCancel.Font = new Font("Prompt", 12, FontStyle.Regular);
                btnCancel.Cursor = Cursors.Hand;
                btnCancel.Tag = classId;
                btnCancel.Width = 100;
                btnCancel.Height = 40;
                btnCancel.Click += BtnCancel_Click;

                pnlRegistered.Controls.Add(lbl);
                pnlRegistered.Controls.Add(btnCancel);
            }

            if (dt.Rows.Count == 0)
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "No registered classes.";
                lblEmpty.Font = new Font("Prompt", 12, FontStyle.Italic);
                lblEmpty.ForeColor = Color.Gray;
                lblEmpty.Size = new Size(609, 40);
                lblEmpty.TextAlign = ContentAlignment.MiddleCenter;
                pnlRegistered.Controls.Add(lblEmpty);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int classId = Convert.ToInt32(btn.Tag);

            DialogResult result = MessageBox.Show(
                "Do you want to cancel this registration?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                DBHelper.CancelRegistration(classId);
                MessageBox.Show("Registration cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegisteredClasses();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm?.Show();
        }

        private void ViewRegisteredForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
