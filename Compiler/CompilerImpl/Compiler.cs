using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostfixNotationImpl;

namespace CompilerImpl
{
    public class Compiler
    {
        string GetCommand(string operation)
        {
            switch (operation)
            {
                case "+":
                    return "A";
                case "-":
                    return "S";
                case "*":
                    return "M";
                case "/":
                    return "D";
                default:
                    return "";
            }
        }
        bool IsRegister(string operand)
        {
            return operand.Contains('R') && (operand.Length == 2);
        }
        public Queue<string> Translate(string expression)
        {
            Queue<string> output = new Queue<string>();
            InfToPostfConverter converter = new InfToPostfConverter();
            Queue<string> postfExpr = converter.ConvertToPostfixNotation(expression);
            Stack<string> calculating = new Stack<string>();
            int freeRegister = 0;
            string currToken, secondOperand, firstOperand, reassignment, nextOperand;
            while (postfExpr.Count > 0)
            {
                currToken = postfExpr.Dequeue();
                if (!(InfToPostfConverter.GetOperators().Contains(currToken)))
                    calculating.Push(currToken);
                else
                {
                    secondOperand = calculating.Pop();
                    firstOperand = calculating.Pop();
                    output.Enqueue("L " + firstOperand);
                    output.Enqueue(GetCommand(currToken) + " " + secondOperand);
                    if (postfExpr.Count > 0)
                    {
                        if (IsRegister(firstOperand))
                        {
                            reassignment = "ST " + firstOperand;
                            nextOperand = firstOperand;
                            if (IsRegister(secondOperand))
                                freeRegister = secondOperand[1] - '0';
                        }
                        else if (IsRegister(secondOperand))
                        {
                            reassignment = "ST " + secondOperand;
                            nextOperand = secondOperand;
                        }
                        else
                        {
                            reassignment = "ST R" + freeRegister;
                            nextOperand = "R" + freeRegister;
                            freeRegister++;
                        }
                        output.Enqueue(reassignment);
                        calculating.Push(nextOperand);
                    }
                }
            }
            return output;
        }
    }
}
