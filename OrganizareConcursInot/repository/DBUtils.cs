using Microsoft.Data.Sqlite;
using organizareConcursInot.ConnectionDBUtils;

namespace OrganizareConcursInot.repository;

using System;
using System.Data;
using System.Collections.Generic;


public static class DBUtils
{
	

    private static IDbConnection instance = null;


    public static IDbConnection getConnection(IDictionary<string,string> props)
    {
        if (instance == null || instance.State == System.Data.ConnectionState.Closed)
        {
            instance = getNewConnection(props);
            instance.Open();
        }
        return instance;
    }

    private static IDbConnection getNewConnection(IDictionary<string,string> props)
    {
		
        SqliteConnectionFactory factory = new SqliteConnectionFactory();
        return factory.createConnection(props);

        //return new SqliteConnection("Data Source=D:\\downloads\\Faculta_2_Sem_2\\MPP\\BazaDeDateConcursInot\\ConcursInot.db");


    }
}