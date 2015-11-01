using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostfixNotationImpl;

namespace PostfixNotation
{
    class Program
    {
        static void Main(string[] args)
        {
            InfToPostfConverter converter = new InfToPostfConverter();
            string s = Console.ReadLine();
            Console.WriteLine(converter.ConvertToPostfixNotation(s));
            Console.ReadKey();
        }
    }
}
