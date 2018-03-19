using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database == true)
            {
                // TODO - set up the sql connection properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles == true)
            {
                // TODO - set up the text connection properly
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
