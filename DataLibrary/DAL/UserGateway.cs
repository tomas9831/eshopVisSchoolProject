using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using DataLibrary.Models;
using Microsoft.Data.SqlClient;

namespace DataLibrary.DAL
{
    class UserGateway
    {
        public static String TABLE_NAME = "UsersTable";

        public static String SQL_SELECT1 = "SELECT * FROM " + TABLE_NAME;
        public static String SQL_SELECT_LOGIN = "SELECT * FROM " + TABLE_NAME + " WHERE email= " + 
            "@email" + " AND password = " + "@password";

        public static String SQL_INSERT = "INSERT INTO "+ TABLE_NAME + " VALUES" +
                                          "(@Email,@Name,@Surname,@Phone,@Adress,@Birthday,@Verified,@Password,@UserType)";
        public static String SQL_UPDATE = "UPDATE " + TABLE_NAME + " SET VERIFIED = 1 WHERE ID = @id";

        public static int Insert(Database db, UserModel user)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, user);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }
        private static void PrepareCommand(SqlCommand command, UserModel user)
        {
            command.Parameters.AddWithValue("@Email", user.Email);
            command.Parameters.AddWithValue("@Name", user.Name);
            command.Parameters.AddWithValue("@Surname", user.Surname);
            command.Parameters.AddWithValue("@Phone", user.Phone);
            command.Parameters.AddWithValue("@Adress", user.Adress);
            command.Parameters.AddWithValue("@Birthday", user.Birthday);
            command.Parameters.AddWithValue("@Verified", user.Verified);
            command.Parameters.AddWithValue("@Password", user.Password);
            command.Parameters.AddWithValue("@UserType", user.UserType);
        }

        public static int Update(Database db, int id)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_UPDATE);
            command.Parameters.AddWithValue("@id", id);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }


        public static Collection<UserModel> LoadAll(Database db)
        {
                db.Connect();
                SqlCommand command = db.CreateCommand(SQL_SELECT1);
                SqlDataReader reader = db.Select(command);

                Collection<UserModel> users = Read(reader);

                return users;
        }

        private static Collection<UserModel> Read(SqlDataReader reader)
        {

            Collection<UserModel> users = new Collection<UserModel>();

            while (reader.Read())
            {
                int i = -1;
                UserModel user = new UserModel();
                user.Id = reader.GetInt32(++i);
                user.Email = reader.GetString(++i);
                user.Name = reader.GetString(++i);
                user.Surname = reader.GetString(++i);
                user.Phone = reader.GetString(++i);
                user.Adress = reader.GetString(++i);
                user.Birthday = reader.GetString(++i);
                user.Verified = reader.GetBoolean(++i);
                user.Password = reader.GetString(++i);
                user.UserType = reader.GetString(++i);
                users.Add(user);

            }
            return users;
        }

    }

}
