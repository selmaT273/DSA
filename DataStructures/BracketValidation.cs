using System;
using DataStructures.Stack;

namespace DataStructures
{
    public class BracketValidation
    {
        public bool MultiBracketValidation(string BracketString)
        {
            bool error = false;
            Stack<char> stack = new Stack<char>();
            foreach (var item in BracketString.ToCharArray())
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    stack.Push(item);
                }
                else if (item == ')' || item == '}' || item == ']')
                {
                    if (stack.Peek() != GetComplementBracket(item))
                    {
                        error = true;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            if (error || !stack.IsEmpty())
                return false;
            else
                return true;
        }

        private static char GetComplementBracket(char item)
        {
            return item switch
            {
                ')' => '(',
                '}' => '{',
                ']' => '[',
                _ => ' ',
            };
        }
    }
}
