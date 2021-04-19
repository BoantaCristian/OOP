using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger___Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            
            var installer = new Installer();

            dbMigrator.Migrate();
            installer.Install();

            Console.Read();
        }
    }
}
