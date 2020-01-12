using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLibrary.DAL;
using DataLibrary.Models;

namespace DataLibrary.BussinessLogic
{
    public class ProductOrderProcessor
    {
        private static Database db;
        public static int CreateProductOrder(int id, int productid, int orderid)
        {
            db = new Database();
            ProductOrderModel data = new ProductOrderModel()
            {
                ProductId = productid,
                OrderId = orderid,
            };

            return ProductOrderDao.Insert(db, data);
        }
        public static Collection<ProductOrderModel> GetAllResults()
        {
            db = new Database();
            return ProductOrderDao.LoadAll(db);
        }
    }
}
