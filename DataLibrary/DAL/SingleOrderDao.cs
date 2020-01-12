using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLibrary.Models;
using Microsoft.Data.SqlClient;

namespace DataLibrary.DAL
{
    class SingleOrderDao
    {
        public static String TABLE_NAME = "SingleOrder";

        public static String SQL_SELECT1 = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_SELECT_LATEST = "SELECT TOP 1 * FROM " + TABLE_NAME + " ORDER BY ID DESC ";

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES" +
                                          "(@CustomerId,@PaymentType,@Adress,@DeliveryType,@Price)";


        public static int Insert(Database db, SingleOrderModel singleOrder)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, singleOrder);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }
        private static void PrepareCommand(SqlCommand command, SingleOrderModel singleOrder)
        {
            command.Parameters.AddWithValue("@CustomerId", singleOrder.CustomerId);
            command.Parameters.AddWithValue("@PaymentType", singleOrder.PaymentType);
            command.Parameters.AddWithValue("@Adress", singleOrder.Adress);
            command.Parameters.AddWithValue("@DeliveryType", singleOrder.DeliveryType);
            command.Parameters.AddWithValue("@Price", singleOrder.Price);

        }


        public static Collection<SingleOrderModel> LoadAll(Database db)
        {
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT_LATEST);
            SqlDataReader reader = db.Select(command);

            Collection<SingleOrderModel> orders = Read(reader);
 
            return orders;
        }

        private static Collection<SingleOrderModel> Read(SqlDataReader reader)
        {

            Collection<SingleOrderModel> orders = new Collection<SingleOrderModel>();

            while (reader.Read())
            {
                int i = -1;
                SingleOrderModel order = new SingleOrderModel();
                order.Id = reader.GetInt32(++i);
                   order.CustomerId = reader.GetInt32(++i);
                   order.PaymentType = reader.GetString(++i);
                   order.Adress = reader.GetString(++i);
                   order.DeliveryType = reader.GetString(++i);
                   order.Price = reader.GetDouble(++i);
                   orders.Add(order);
            }
            return orders;
        }
    }
}
