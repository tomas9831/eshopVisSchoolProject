using DataLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLibrary.DAL
{
    class RequestsDao
    {
        public static String TABLE_NAME = "Requests";

        public static String SQL_SELECT1 = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_INSERT = "INSERT INTO " + TABLE_NAME + " VALUES" +
                                          "(@UserId,@Request)";

        public static int Insert(Database db, RequestsModel orders)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, orders);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }
        private static void PrepareCommand(SqlCommand command, RequestsModel r)
        {
            command.Parameters.AddWithValue("@UserId", r.UserId);
            command.Parameters.AddWithValue("@Request", r.Request);

        }


        public static Collection<RequestsModel> LoadAll(Database db)
        {
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT1);
            SqlDataReader reader = db.Select(command);

            Collection<RequestsModel> orders = Read(reader);

            return orders;
        }

        private static Collection<RequestsModel> Read(SqlDataReader reader)
        {

            Collection<RequestsModel> requests = new Collection<RequestsModel>();

            while (reader.Read())
            {
                int i = -1;
                RequestsModel request = new RequestsModel();
                request.Id = reader.GetInt32(++i);
                request.UserId = reader.GetInt32(++i);
                request.Request = reader.GetString(++i);
                requests.Add(request);

            }
            return requests;
        }
    }
}
