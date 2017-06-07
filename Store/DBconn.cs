using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public sealed class DBconn
    {
        private static readonly string connectionString = @"Driver={SQL Server}; Server=LAPTOP-NUI4UC8C\SQLEXPRESS; Database=c_store";
        private static readonly Lazy<DBconn> lazy = new Lazy<DBconn>(() => new DBconn());
        private static OdbcConnection conn = null;

        public static DBconn Instance{get { return lazy.Value; } }

        private DBconn()
        {
            conn = new OdbcConnection(connectionString);
            conn.Open();
        }

        public OdbcDataReader GetReader(String sql)
        {
            OdbcCommand command = conn.CreateCommand();
            command.CommandText = sql;
            return command.ExecuteReader();
        }


    }
}
