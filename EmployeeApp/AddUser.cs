using DataLibrary.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendB_Click(object sender, EventArgs e)
        {
            bool verified = bool.Parse(verifiedTb.Text);
            int result = UserProcessor.CreateUser(0, emailTb.Text, nameTb.Text, surnameTb.Text, adressTb.Text, phoneTb.Text, birthdayTb.Text, verified, passwordTb.Text, usertypeTb.Text);
        }
    }
}
