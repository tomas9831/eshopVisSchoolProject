using DataLibrary.DAL;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Microsoft.VisualBasic;

namespace DataLibrary.BussinessLogic
{
    public class GameProcessor
    {
        private static Database db;
        public static int CreateGame(string name, int pegi, string description
            ,double pricen, double priceo, double pricep, string img, string availability )
        {
            db = new Database();
            GameModel data = new GameModel
            {
                Name = name,
                Pegi = pegi,
                Description = description,
                PriceNew = pricen,
                PriceOld = priceo,
                PricePurchase = pricep,
                CoverImage = img,
                Availability = availability,
            };
            LogUnit log;
            log.id = 1;
            log.message = DateTime.Now.Date.ToString() +" new game added: " + data.Name;
            LogGateway.LoadDocument(@"C:\vis\WebApplication\DataLibrary\test.xml");
            LogGateway.Insert(ref log);
            return GameGateway.Insert(db, data);
        }
        public static Collection<GameModel> GetAllResults()
        {
            db = new Database();
            return GameGateway.LoadAll(db);
        }
    }
   
}
