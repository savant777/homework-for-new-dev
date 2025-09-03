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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnGoRegister_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm(this);
            regForm.Show();
            this.Hide();
        }

        private void btnViewRegistered_Click(object sender, EventArgs e)
        {
            ViewRegisteredForm viewForm = new ViewRegisteredForm(this);
            viewForm.Show();
            this.Hide();
        }
    }
}
