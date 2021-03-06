﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostfixNotationImpl
{
    public class InfToPostfConverter
    {
        public InfToPostfConverter()
        {
            operators = new List<string>(standartOperators);
            operators.Add("sin");
            operators.Add("F");
            
        }
        private List<string> operators;
        private List<string> standartOperators =
            new List<string>(new string[] { "(", ")", "+", "-", "*", "/"});
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
                case "^":
                    return 3;
                default:
                    return 4;
            }
        }
        public string ConvertToPostfixNotation(string input)
        {
            Queue<string> splittedOutputExpression = new Queue<string>();
            Stack<string> stack = new Stack<string>();
            foreach (string c in Split(input))
            {
                if (!operators.Contains(c))
                    splittedOutputExpression.Enqueue(c);
                else
                {
                    if (c == ",")
                    {
                        while (stack.Count > 0 && stack.Peek() != "(")
                            splittedOutputExpression.Enqueue(stack.Pop());
                    }
                    else if (c == "(")
                        stack.Push(c);
                    else if (c == ")")
                    {
                        while (stack.Count > 0 && stack.Peek() != "(")
                            splittedOutputExpression.Enqueue(stack.Pop());
                        stack.Pop();
                    }
                    else
                    {
                        while (stack.Count > 0 && GetPriority(c) <= GetPriority(stack.Peek()))
                            splittedOutputExpression.Enqueue(stack.Pop());
                        stack.Push(c);
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
            return String.Join(" ", splittedOutputExpression);
        }
    }
}
