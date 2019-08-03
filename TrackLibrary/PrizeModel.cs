using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Represents where a team placed in a tournament.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Text representation of placement.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Monetary prize value.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Percentage of the prize amount.
        /// </summary>
        public double PrizePercentage { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public PrizeModel()
        {

        }

        /// <summary>
        /// Overloaded constructor that takes in strings and converts to numeric types
        /// </summary>
        /// <param name="placeNumber"></param>
        /// <param name="placeName"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
