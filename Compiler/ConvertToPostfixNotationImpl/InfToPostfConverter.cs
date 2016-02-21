using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostfixNotationImpl
{
    public class InfToPostfConverter
    {
        private static List<string> operators =
            new List<string>(new string[] { "(", ")", "+", "-", "*", "/" });
        public static List<string> GetOperators()
        {
            return operators;
        }
        private List<string> Split(string inp)
        {
            List<string> splittedInputExpression = new List<string>();
            int pos = 0;
            while (pos < inp.Length)
            {
                string s = string.Empty + inp[pos];
                if (!operators.Contains(inp[pos].ToString()))
                    if (Char.IsDigit(inp[pos]))
                        for (int i = pos + 1; i < inp.Length && (Char.IsDigit(inp[i]) || inp[i] == ',' || inp[i] == '.'); i++)
                            s += inp[i];
                    else if (Char.IsLetter(inp[pos]))
                        for (int i = pos + 1; i < inp.Length && (Char.IsLetter(inp[i]) || Char.IsDigit(inp[i])); i++)
                            s += inp[i];
                if (s != " ")
                    splittedInputExpression.Add(s);
                pos += s.Length;
            }
            return splittedInputExpression;
        }
        private int GetPriority(string s)
        {
            switch (s)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    return 3;
            }
        }
        public Queue<string> ConvertToPostfixNotation(string input)
        {
            Queue<string> splittedOutputExpression = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            foreach (string c in Split(input))
            {
                if (!operators.Contains(c))
                    splittedOutputExpression.Enqueue(c);
                else
                {
                    switch (c)
                    {
                        case ",":
                            while (stack.Count > 0 && stack.Peek() != "(")
                                splittedOutputExpression.Enqueue(stack.Pop());
                            break;
                        case "(":
                            stack.Push(c);
                            break;
                        case ")":
                            while (stack.Count > 0 && stack.Peek() != "(")
                                splittedOutputExpression.Enqueue(stack.Pop());
                            stack.Pop();
                            break;
                        default:
                            while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                                splittedOutputExpression.Enqueue(stack.Pop());
                            stack.Push(c);
                            break;
                    }
                }
            }
            if (stack.Count > 0)
            {
                foreach (string c in stack)
                {
                    splittedOutputExpression.Enqueue(c);
                }
            }
            return splittedOutputExpression;
        }
    }
}
