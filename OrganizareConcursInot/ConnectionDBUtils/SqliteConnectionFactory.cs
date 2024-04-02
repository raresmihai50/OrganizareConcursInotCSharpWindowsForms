using System;
using System.Collections.Generic;

namespace organizareConcursInot.ConnectionDBUtils;
using log4net;
using Microsoft.Data.Sqlite;

public class SqliteConnectionFactory 
{
    private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
    public SqliteConnection createConnection(IDictionary<string,string> props)
    {

        String connectionString = props["ConnectionString"];
        Console.WriteLine("Opening a new connection to SQLite database {0}..", connectionString);
        logger.Info("Opening a new connection to SQLite database "+ connectionString+"...");
        return new SqliteConnection(connectionString);
    }
}