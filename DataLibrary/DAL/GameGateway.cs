using DataLibrary.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLibrary.DAL
{
    class GameGateway
    {
        public static String TABLE_NAME = "Games";

        public static String SQL_SELECT = "SELECT * FROM " + TABLE_NAME;

        public static String SQL_INSERT = "INSERT INTO "+TABLE_NAME+" VALUES" +
                                          "(@Name,@Pegi,@Decription,@PriceNew,@PriceOld,@PricePurchase,@CoverImage,@Availability)";

        public static int Insert(Database db, GameModel game)
        {
            db.Connect();

            SqlCommand command = db.CreateCommand(SQL_INSERT);
            PrepareCommand(command, game);

            int ret = db.ExecuteNonQuery(command);

            db.Close();

            return ret;
        }
        private static void PrepareCommand(SqlCommand command, GameModel game)
        {
            command.Parameters.AddWithValue("@Name", game.Name);
            command.Parameters.AddWithValue("@Pegi", game.Pegi);
            command.Parameters.AddWithValue("@Decription", game.Description);
            command.Parameters.AddWithValue("@PriceNew", game.PriceNew);
            command.Parameters.AddWithValue("@PriceOld", game.PriceOld);
            command.Parameters.AddWithValue("@PricePurchase", game.PricePurchase);
            command.Parameters.AddWithValue("@CoverImage", game.CoverImage);
            command.Parameters.AddWithValue("@Availability", game.Availability);

        }

        public static Collection<GameModel> LoadAll(Database db)
        {
            db.Connect();
            SqlCommand command = db.CreateCommand(SQL_SELECT);
            SqlDataReader reader = db.Select(command);

            Collection<GameModel> games = Read(reader);
            
            return games;
        }

        private static Collection<GameModel> Read(SqlDataReader reader)
        {

            Collection<GameModel> games = new Collection<GameModel>();

            while (reader.Read())
            {
                int i = -1;
                GameModel game = new GameModel();
                game.Id = reader.GetInt32(++i);
                game.Name = reader.GetString(++i);
                game.Pegi = reader.GetInt32(++i);
                game.Description = reader.GetString(++i);
                game.PriceNew = reader.GetDouble(++i);
                game.PriceOld = reader.GetDouble(++i);
                game.PricePurchase = reader.GetDouble(++i);
                game.CoverImage = reader.GetString(++i);
                game.Availability = reader.GetString(++i);
                games.Add(game);

            }
            return games;
        }
    }
}
