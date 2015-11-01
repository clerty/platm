using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableGenerator
{
    public class FieldInfo
    {
        public string Name { get; set; }
        public string Caption { get; set; }
        public char Type { get; set; }
        public int Length { get; set; }
        public int Decimals { get; set; }     
    }
}
