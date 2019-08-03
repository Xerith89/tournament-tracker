using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class TextConnector : IDataConnection
    {
        // TODO - Implement CreatePrize for text connections
        /// <summary>
        /// Saves a prize to a text file
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
