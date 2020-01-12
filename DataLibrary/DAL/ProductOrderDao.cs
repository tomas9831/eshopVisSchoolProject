using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLibrary.Models;
using Microsoft.Data.SqlClient;

namespace DataLibrary.DAL
{
    class ProductOrderDao
    {
        public static String TABLE_NAME = "ProductOrder";

        public static String SQL_SELECT1 = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES" +
                                          "(@ProductId,@OrderId)";

        public static int Insert(Database db, ProductOrderModel orders)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, orders);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }
        private static void PrepareCommand(SqlCommand command, ProductOrderModel product)
        {
            command.Parameters.AddWithValue("@ProductId", product.ProductId);
            command.Parameters.AddWithValue("@OrderId", product.OrderId);

        }


        public static Collection<ProductOrderModel> LoadAll(Database db)
        {
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT1);
            SqlDataReader reader = db.Select(command);

            Collection<ProductOrderModel> orders = Read(reader);

            return orders;
        }

        private static Collection<ProductOrderModel> Read(SqlDataReader reader)
        {

            Collection<ProductOrderModel> orders = new Collection<ProductOrderModel>();

            while (reader.Read())
            {
                int i = -1;
                ProductOrderModel order = new ProductOrderModel();
                order.ProductId= reader.GetInt32(++i);
                order.OrderId = reader.GetInt32(++i);
                orders.Add(order);

            }
            return orders;
        }
    }
}
