using DataLibrary.BussinessLogic;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class Requests : Form
    {
        public Requests()
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

            ColumnHeader ID2 = new ColumnHeader();
            ID2.Text = "ID";
            ID2.TextAlign = HorizontalAlignment.Center;
            ID2.Width = 142;

            ColumnHeader UserId = new ColumnHeader();
            UserId.Text = "UserId";
            UserId.TextAlign = HorizontalAlignment.Center;
            UserId.Width = 142;

            ColumnHeader Request = new ColumnHeader();
            Request.Text = "Request";
            Request.TextAlign = HorizontalAlignment.Center;
            Request.Width = 142;

            this.listView1.Columns.Add(ID2);
            this.listView1.Columns.Add(UserId);
            this.listView1.Columns.Add(Request);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeListView();

            Collection<RequestsModel> requests = RequestsProcessor.GetAllResults();
            if (requests == null) return;
            foreach (RequestsModel request in requests)
            {
                ListViewItem item = new ListViewItem(request.Id.ToString());
                item.SubItems.Add(request.UserId.ToString());
                item.SubItems.Add(request.Request);

                listView1.Items.Add(item);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
