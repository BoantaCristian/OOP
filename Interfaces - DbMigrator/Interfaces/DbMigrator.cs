using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at "+ DateTime.UtcNow);
            
            Thread.Sleep(2000);

            _logger.LogInfo("Migration finished at "+ DateTime.UtcNow);
        }
    }
}
