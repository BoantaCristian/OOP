using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class OracleConnection : DbConnection
    {
        private readonly string _connectionString;
        public override void OpenConnection()
        {
            Console.WriteLine("Opened oracle connection {0} with connection string: ", _connectionString);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection closed!");
        }
        public OracleConnection(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
