using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make Create prize method actualy save to database. 
        /// <summary>
        /// Saves a new prize to database.
        /// </summary>
        /// <param name="model">Prize information.</param>
        /// <returns>Prize information including unique Identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.id = 1;
            return model;
        }
    }
}
