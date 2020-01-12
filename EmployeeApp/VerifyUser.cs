using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class VerifyUser : Form
    {
        public VerifyUser()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.Clear();
            listView1.TabIndex = 0;
            listView1.View = System.Windows.Forms.View.Details;
            listView1.MultiSelect = true;
            listView1.GridLines = true;

            ColumnHeader ID = new ColumnHeader();
            ID.Text = "ID";
            ID.TextAlign = HorizontalAlignment.Center;
            ID.Width = 142;

            ColumnHeader email = new ColumnHeader();
            email.Text = "Email";
            email.TextAlign = HorizontalAlignment.Center;
            email.Width = 142;


            ColumnHeader name = new ColumnHeader();
            name.Text = "Name";
            name.TextAlign = HorizontalAlignment.Center;
            name.Width = 142;

            ColumnHeader surname = new ColumnHeader();
            surname.Text = "Surname";
            surname.TextAlign = HorizontalAlignment.Center;
            surname.Width = 142;

            ColumnHeader phone = new ColumnHeader();
            phone.Text = "Phone";
            phone.TextAlign = HorizontalAlignment.Center;
            phone.Width = 142;

            ColumnHeader adress = new ColumnHeader();
            adress.Text = "Adress";
            adress.TextAlign = HorizontalAlignment.Center;
            adress.Width = 142;

            ColumnHeader birthday = new ColumnHeader();
            birthday.Text = "Birthday";
            birthday.TextAlign = HorizontalAlignment.Center;
            birthday.Width = 142;

            ColumnHeader verified = new ColumnHeader();
            verified.Text = "Verified";
            verified.TextAlign = HorizontalAlignment.Center;
            verified.Width = 142;

            ColumnHeader password = new ColumnHeader();
            password.Text = "Password";
            password.TextAlign = HorizontalAlignment.Center;
            password.Width = 142;

            ColumnHeader usertype = new ColumnHeader();
            usertype.Text = "Usertype";
            usertype.TextAlign = HorizontalAlignment.Center;
            usertype.Width = 142;

            this.listView1.Columns.Add(ID);
            this.listView1.Columns.Add(email);
            this.listView1.Columns.Add(name);
            this.listView1.Columns.Add(surname);
            this.listView1.Columns.Add(phone);
            this.listView1.Columns.Add(adress);
            this.listView1.Columns.Add(birthday);
            this.listView1.Columns.Add(verified);
            this.listView1.Columns.Add(password);
            this.listView1.Columns.Add(usertype);


        }

        private void VerifyUser_Load(object sender, EventArgs e)
        {

        }
    }
}
