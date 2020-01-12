using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addGameB_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();

            using (addGame)
            {
                addGame.ShowDialog();
            }
        }

        private void addUserB_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();

            using (addUser)
            {
                addUser.ShowDialog();
            }
        }

        private void verifyuserB_Click(object sender, EventArgs e)
        {
            Verify verifyUser = new Verify();

            using (verifyUser)
            {
                verifyUser.ShowDialog();
            }

        }

        private void requestsB_Click(object sender, EventArgs e)
        {
            Requests request = new Requests();

            using (request)
            {
                request.ShowDialog();
            }
        }
    }
}
