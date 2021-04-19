using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class SqlConnection : DbConnection
    {
        private readonly string _connectionString;
        public override void OpenConnection()
        {
            Console.WriteLine("Opened sql connection {0} with connection string: ", _connectionString);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection closed!");
        }
        public SqlConnection(string connectionString) : base(connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
