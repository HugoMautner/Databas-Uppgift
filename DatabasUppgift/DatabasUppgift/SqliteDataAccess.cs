using System;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Linq;
using System.Collections.Generic;

namespace DatabasUppgift
{
    class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
