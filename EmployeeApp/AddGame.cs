using DataLibrary.BussinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class AddGame : Form
    {
        Bitmap img;
        public AddGame()
        {
            InitializeComponent();
        }

        private void AddGame_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void saveB_Click(object sender, EventArgs e)
        {
            int pegi = int.Parse(pegiTB.Text);
            float priceNew = float.Parse(priceNewTB.Text);
            float priceOld = float.Parse(priceOldTB.Text);
            float pricePurchase = float.Parse(pricePurchaseTB.Text);
            int result = GameProcessor.CreateGame(nameTB.Text,pegi,descriptionTB.Text,
                priceNew,priceOld,pricePurchase,imageTB.Text,availabilityTB.Text);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
