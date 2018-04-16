using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connectons { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Create SQL connection.
                SqlConnector sql = new SqlConnector();
                Connectons.Add(sql);
            }

            if (textFiles)
            {
                // TODO: Create Text connection.
                TextConnection text = new TextConnection();
                Connectons.Add(text);
            }
        }
    }
}
