using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class SQLConnector : IDataConnection
    {
        // TODO - Make CreatePrize save to database
        /// <summary>
        /// Saves a new prize to the database
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
