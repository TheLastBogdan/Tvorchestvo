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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = Convert.ToString(LoginBox.Text);
            string Password = Convert.ToString(PasswordBox.Text);


            if (Login == "" | Password == "")
            {
                ErrorLable.Visible=true;
                ErrorLable.Text = "Введите данные";
            };


            if (Login == "admin" | Password == "admin")

            {
                this.Hide();
                ShopPage shopPage = new ShopPage();
                shopPage.ChangeButton.Visible = true;
                shopPage.AddButton.Visible = true;
                shopPage.DeleteButton.Visible = true;
                shopPage.LoginLable.Text = Login;
                shopPage.ShowDialog();

            };

            if (Login != "" & Password != "")
            {
                this.Hide();
                ShopPage shopPageUser = new ShopPage();
                shopPageUser.LoginLable.Text = Login;
                shopPageUser.ShowDialog();
            };
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationPage reg = new RegistrationPage();
            reg.ShowDialog();
        }
    }
}
