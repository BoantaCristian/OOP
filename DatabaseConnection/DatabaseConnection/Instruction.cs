using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnection
{
    public class Instruction
    {
        public string Instr { get; set; }
        public string Type { get; set; } //sql or oracle

        public Instruction(string instruction, string type)
        {
            Instr = instruction;
            Type = type;
        }
    }
}
