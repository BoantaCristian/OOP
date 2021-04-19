using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var oracle = new OracleConnection("Server=local/(express);Database=DBORACLE;Trusted=True");
            var sql = new SqlConnection("Server=local/(express);Database=DBSQL;Trusted=True");

            oracle.OpenConnection();
            oracle.Timeout = new TimeSpan(0, 0, 0, 0, 2000);
            Thread.Sleep(oracle.Timeout);
            oracle.CloseConnection();

            Console.WriteLine();

            sql.OpenConnection();
            sql.Timeout = new TimeSpan(0, 0, 0, 0, 4000);
            Thread.Sleep(sql.Timeout);
            sql.CloseConnection();

            Console.WriteLine();

            var instructionSQL = new Instruction("sql show databases", "SQL");
            var instructionOracle = new Instruction("oracle databases list", "Oracle");

            var dbComandSQL = new DbCommand(sql, instructionSQL);
            var dbComandOracle = new DbCommand(oracle, instructionOracle);

            dbComandSQL.Execute();
            dbComandOracle.Execute();

            Console.Read();
        }
    }
}
