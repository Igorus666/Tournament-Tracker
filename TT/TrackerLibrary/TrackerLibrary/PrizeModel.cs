using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }
        //place ranking of the reciver of the prize
        public String? PlaceName { get; set; }
        //the name of the team in the place
        public decimal PrizeAmount { get; set; }
        //the amount the place is going to recive
        public double PrizePercentage { get; set; }
        //the percentage of money the place is going to recive
    }
}
