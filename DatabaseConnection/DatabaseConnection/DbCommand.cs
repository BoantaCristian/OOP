using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private Instruction _instruction { get; set; }
        public DbCommand(DbConnection dbConnection, Instruction instruction)
        {
            if(dbConnection != null)
            {
                _dbConnection = dbConnection;
            }
            else
                throw new InvalidOperationException("Empty connection string!");

            if (instruction != null)
            {
                _instruction = instruction;
            }
            else
                throw new InvalidOperationException("No instruction!");
        }
        public void Run(Instruction instruction)
        {
            Console.WriteLine("{0} instruction {1} runned",instruction.Type, instruction.Instr);
        }
        public void Execute()
        {
            _dbConnection.OpenConnection();
            Run(_instruction);
            _dbConnection.CloseConnection();
            Console.WriteLine();
        }
    }
}
