using DataLibrary.DAL;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLibrary.BussinessLogic
{
    public class RequestsProcessor
    {
        private static Database db;
        public static int CreateRequest(int id, int userid, string request)
        {
            db = new Database();
            RequestsModel data = new RequestsModel()
            {
                UserId = userid,
                Request = request,
            };

            return RequestsDao.Insert(db, data);
        }
        public static Collection<RequestsModel> GetAllResults()
        {
            db = new Database();
            return RequestsDao.LoadAll(db);
        }
    }
}
