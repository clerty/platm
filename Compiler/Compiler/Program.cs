using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostfixNotationImpl;
using CompilerImpl;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            InfToPostfConverter converter = new InfToPostfConverter();
            string s = Console.ReadLine();
            Console.WriteLine(string.Join(" ", converter.ConvertToPostfixNotation(s)));
            Compiler compiler = new Compiler();
            Console.WriteLine(string.Join("\n", compiler.Translate(s)));
            Console.ReadKey();
        }
    }
}
