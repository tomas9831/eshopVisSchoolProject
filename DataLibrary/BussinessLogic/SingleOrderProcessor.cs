using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLibrary.DAL;
using DataLibrary.Models;

namespace DataLibrary.BussinessLogic
{
    public class SingleOrderProcessor
    {
        private static Database db;
        public static int CreateSingleOrder(int id, int customerid, string paymenttype, string adress, string deliverytype, double price)
        {
            db = new Database();
            SingleOrderModel data = new SingleOrderModel()
            {
                CustomerId = customerid,
                PaymentType =  paymenttype,
                Adress = adress,
                DeliveryType = deliverytype,
                Price = price,
            };

            return SingleOrderDao.Insert(db, data);
        }
        public static Collection<SingleOrderModel> GetAllResults()
        {
            db = new Database();
            return SingleOrderDao.LoadAll(db);
        }
    }
}
