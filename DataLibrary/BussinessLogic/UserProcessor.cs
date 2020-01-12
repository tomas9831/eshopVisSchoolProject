using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DataLibrary.DAL;
using DataLibrary.Models;

namespace DataLibrary.BussinessLogic
{
    public class UserProcessor
    {
        private static Database db;
        public static int CreateUser(int id, string email, string name, string surname,
            string phone, string adress,  string bday, bool verified, string password, string usertype )
        {
            db = new Database();
            UserModel data = new UserModel
            {
                Id = id,
                Email = email,
                Name = name,
                Surname = surname,
                Phone = phone,
                Adress = adress,        
                Birthday = bday,
                Verified = verified,
                Password = password,
                UserType = usertype,
            };
            return UserGateway.Insert(db, data);
        }
        public static Collection<UserModel> GetAllResults()
        {
            db = new Database();
            return UserGateway.LoadAll(db);
        }
        public static int VerifyUser(int id)
        {
            db = new Database();
            return UserGateway.Update(db, id);
        }
    }  
}