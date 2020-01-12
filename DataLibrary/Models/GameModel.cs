using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DataLibrary.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public int Pegi { get; set; }
        public string Description { get; set; }
        public double PriceNew { get; set; }
        public double PriceOld { get; set; }
        public double PricePurchase { get; set; }
        public string CoverImage { get; set; }
        public string Availability { get; set; }
    }
}
