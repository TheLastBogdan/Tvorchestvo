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
    public partial class ShopPage : Form
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage confirmPage = new LoginPage();
            confirmPage.ShowDialog();
        }

        private void LoginLable_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
