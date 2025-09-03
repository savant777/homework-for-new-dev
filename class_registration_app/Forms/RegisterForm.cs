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
    public partial class RegisterForm : Form
    {
        private Form previousForm;

        public RegisterForm(Form prev)
        {
            InitializeComponent();
            previousForm = prev;
            LoadMonths();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            lstMonths.SelectedIndex = 0;
            LoadClassesByMonth(1);
        }

        private void LoadMonths()
        {
            string[] months = new string[]
            {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };
            lstMonths.Items.AddRange(months);
        }

        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedMonth = lstMonths.SelectedIndex + 1;
            LoadClassesByMonth(selectedMonth);
        }

        private void LoadClassesByMonth(int month)
        {
            pnlClasses.Controls.Clear();
            DataTable dt = DBHelper.GetClassesByMonth(month);

            foreach (DataRow row in dt.Rows)
            {
                Button btnClass = new Button();
                btnClass.Text = row["ClassName"].ToString();
                btnClass.Width = 444;
                btnClass.Height = 50;
                btnClass.Tag = row["ClassID"];
                btnClass.BackColor = Color.DarkGray;
                btnClass.Cursor = Cursors.Hand;
                btnClass.FlatStyle = FlatStyle.Flat;
                btnClass.FlatAppearance.BorderSize = 0;
                btnClass.Font = new Font("Prompt", 12, FontStyle.Regular);
                btnClass.ForeColor = Color.White;

                btnClass.Click += BtnClass_Click;

                pnlClasses.Controls.Add(btnClass);
            }
        }

        private void BtnClass_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int classId = Convert.ToInt32(btn.Tag);

            ClassDetailForm detailForm = new ClassDetailForm(classId, this);
            detailForm.ShowDialog();

            int selectedMonth = lstMonths.SelectedIndex + 1;
            LoadClassesByMonth(selectedMonth);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm?.Show();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
