using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public DbConnection(string connectionString)
        {
            if(connectionString != null)
                _connectionString = connectionString;
            else
                throw new InvalidOperationException("Empty connection string!");
        }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
