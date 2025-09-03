using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassRegistrationApp
{
    public partial class ClassDetailForm : Form
    {
        private int classId;
        private Form previousForm;

        public ClassDetailForm(int classId, Form prev)
        {
            InitializeComponent();
            this.classId = classId;
            previousForm = prev;
            LoadClassDetail();
        }

        private void LoadClassDetail()
        {
            DataTable dt = DBHelper.GetClassById(classId);
            if (dt.Rows.Count == 0) return;

            DataRow row = dt.Rows[0];

            txtClassName.Text = row["ClassName"].ToString();
            txtClassDescription.Text = row["Description"].ToString();

            string posterPath = row["PosterPath"].ToString();
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\", posterPath.Replace("/", Path.DirectorySeparatorChar.ToString()));
            fullPath = Path.GetFullPath(fullPath);

            if (File.Exists(fullPath))
            {
                picPoster.Image = Image.FromFile(fullPath);
            }
            else
            {
                picPoster.Image = null;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousForm?.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (DBHelper.IsClassRegistered(classId))
            {
                MessageBox.Show(
                    $"You have already registered for \"{txtClassName.Text}\".",
                    "Duplicate Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Do you want to register for \"{txtClassName.Text}\"?",
                "Confirm Registration",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                DBHelper.RegisterClass(classId);
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                previousForm?.Show();
            }
        }

        private void ClassDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
