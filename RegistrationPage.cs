using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Творчество
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void LoginBoxReg_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(this.LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);
            string ConfirmPassword = Convert.ToString(ConfirmPasswordBox.Text);
            bool ConfirmIsSuccess = Password == ConfirmPassword;

            if (Login == "" | Password == "" | ConfirmPassword == "")
            {
                ErrorLableReg.Visible = true;
                ErrorLableReg.Text = "Введите данные";
            };

            if (ConfirmIsSuccess == false)
            {
                ErrorLableReg.Visible = true;
                ErrorLableReg.Text = "Пороли не совпадают!";
            };

            if (Login != "" & Password != "" & ConfirmPassword != "" & ConfirmIsSuccess == true)
            {
                this.Hide();
                LoginPage confirm = new LoginPage();
                confirm.ShowDialog();
            };

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage frm = new LoginPage();
            frm.ShowDialog();
        }
    }
}
