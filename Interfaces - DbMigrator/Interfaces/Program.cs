using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator2 = new DbMigrator(new FileLogger("C:\\Users\\crist\\OneDrive\\Desktop\\log.txt"));
            dbMigrator.Migrate();
            dbMigrator2.Migrate();
            Console.Read();
        }
    }
}
