using System;
using System.Collections.Generic;
using System.Text;

namespace TrackLibrary
{
    public class PrizeModel
    {
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
    }
}
